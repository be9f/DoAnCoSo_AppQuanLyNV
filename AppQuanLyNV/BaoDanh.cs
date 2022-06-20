using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;

namespace AppQuanLyNV
{
    public partial class BaoDanh : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = @"Data Source=LAPTOP-8EBELOTL;Initial Catalog=NhanVien;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tb = new DataTable();
        void loaddata()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from DangNhap";
            adapter.SelectCommand = cmd;
            tb.Clear();
            adapter.Fill(tb);
        }

        public BaoDanh()
        {
            InitializeComponent();
            timer2.Start();
        }

        
        FilterInfoCollection CaptureDevice;
        VideoCaptureDevice FinalFrame;
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[cbxDevice.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            ptbCam.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader Reader = new BarcodeReader();
            Result result = Reader.Decode((Bitmap)ptbCam.Image);
            try
            {
                string decoded = result.ToString().Trim();
                if (decoded != "")
                    timer1.Stop();
                txtLog.Text = result.ToString();
                cmd = con.CreateCommand();
                cmd.CommandText = "insert into DangNhap values('" + txtLog.Text + "', '" + lblDate.Text + "','" + lblTime.Text + "','" + lblTrangThai.Text + "','" + txtTre.Text + "')";
                if (cmd.ExecuteNonQuery() > 0)
                {
                    loaddata();
                    MessageBox.Show("Da Diem Danh Thanh Cong");
                }
                con.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Kiem tra lai");
            }
            catch (Exception)
            {

            }
        }
        private void BaoDanh_Load(object sender, EventArgs e)
        {
            txtHour.Text = Properties.Settings.Default.HourIn;
            txtMin.Text= Properties.Settings.Default.MinIn;
            con = new SqlConnection(str);
            loaddata();
            con.Open();
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                cbxDevice.Items.Add(Device.Name);
            }

            cbxDevice.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();

            
            int hour = DateTime.Now.Hour;
            this.Text = txtHour.Text;
            int min = DateTime.Now.Minute;
            this.Text = txtMin.Text;
            
            
            if (hour > int.Parse(txtHour.Text)||min >int.Parse(txtMin.Text) )
            {
                lblTrangThai.Text = "Di tre";
            }
            else
            {
                lblTrangThai.Text = "Dung gio";
            }
        }

        private void BaoDanh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
            }
            Properties.Settings.Default.HourIn = txtHour.Text;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.MinIn = txtMin.Text;
            Properties.Settings.Default.Save();
        }

        private void btnShowCode_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }
        
        private void btnThayDoi_Click(object sender, EventArgs e)
        {   
            this.Text = txtHour.Text;
            this.Text= txtMin.Text;
            MessageBox.Show("Da cap nhat thanh cong");
            this.Controls.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "mannothot") 
            {
                pnlCaiDat.Visible = true;
                pnlLogin.Hide();
            }
            else
            {
                MessageBox.Show("Nhap sai mat khau");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = false;
        }
    }
}
