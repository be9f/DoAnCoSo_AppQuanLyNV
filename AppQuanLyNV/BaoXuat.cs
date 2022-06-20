using AForge.Video;
using AForge.Video.DirectShow;
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
using ZXing;

namespace AppQuanLyNV
{
    public partial class BaoXuat : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = @"Data Source=LAPTOP-8EBELOTL;Initial Catalog=NhanVien;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tb = new DataTable();
        public BaoXuat()
        {
            InitializeComponent();
            timer1.Start();
        }
        void loaddata()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from DangXuat";
            adapter.SelectCommand = cmd;
            tb.Clear();
            adapter.Fill(tb);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }
        FilterInfoCollection CaptureDevice;
        VideoCaptureDevice FinalFrame;

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            ptbCam.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            BarcodeReader Reader = new BarcodeReader();
            Result result = Reader.Decode((Bitmap)ptbCam.Image);
            try
            {
                string decoded = result.ToString().Trim();
                if (decoded != "")
                    timer2.Stop();
                txtLog.Text = result.ToString();
                cmd = con.CreateCommand();
                cmd.CommandText = "insert into DangXuat values('" + txtLog.Text + "', '" + lblDate.Text + "','" + lblTime.Text + "','" + lblTrangThai.Text + "')";
                if (cmd.ExecuteNonQuery() > 0)
                {
                    loaddata();
                    MessageBox.Show("Da Dang Xuat Thanh Cong");
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

        private void BaoXuat_Load(object sender, EventArgs e)
        {
            txtHourOut.Text = Properties.Settings.Default.HourOut;
            txtMinOut.Text = Properties.Settings.Default.MinOut;
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
            this.Text = txtHourOut.Text;
            int min = DateTime.Now.Minute;
            this.Text = txtMinOut.Text;


            if (hour >= int.Parse(txtHourOut.Text)|| min==int.Parse(txtMinOut.Text))
            {
                lblTrangThai.Text = "Dung gio";
            }
            else
            {
                lblTrangThai.Text = "Ve som";
            }
        }

        private void BaoXuat_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
            }
            Properties.Settings.Default.HourOut = txtHourOut.Text;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.MinOut= txtMinOut.Text;
            Properties.Settings.Default.Save();

        }

        private void btnShowCode_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer2.Start();
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[cbxDevice.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            this.Text = txtHourOut.Text;
            this.Text = txtMinOut.Text;
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
