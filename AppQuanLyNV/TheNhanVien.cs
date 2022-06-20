using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyNV
{
    public partial class TheNhanVien : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = @"Data Source=LAPTOP-8EBELOTL;Initial Catalog=NhanVien;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tb = new DataTable();


        public TheNhanVien()
        {
            InitializeComponent();

        }
        void loaddata()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from NhanVien";
            adapter.SelectCommand = cmd;
            tb.Clear();
            adapter.Fill(tb);
            dgvNhanVien.DataSource = tb;
        }

        private void TheNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nhanVienDataSet.NhanVien' table. You can move, or remove it, as needed.
            
            con = new SqlConnection(str);
            loaddata();
            con.Open();
        }



        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from NhanVien where MaNV='" + txtTimKiem.Text + "'";
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvNhanVien.DataSource = dt;
        }

        /*private void btnQR_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator qr = new QRCoder.QRCodeGenerator();
            var Mydata = qr.CreateQrCode(txtMaNV.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(Mydata);
            ptbQR.Image = code.GetGraphic(50);
        }*/

        PrintPreviewDialog ppd = new PrintPreviewDialog();
        PrintDocument pd = new PrintDocument();
        public void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            pnlTheNV = pnl;
            getprintarea(pnl);
            ppd.Document = pd;
            pd.PrintPage += new PrintPageEventHandler(pd_printpage);
            ppd.ShowDialog();
        }

        public void pd_printpage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memorying, (pagearea.Width / 2) - (this.pnlTheNV.Width / 2), this.pnlTheNV.Location.Y);
        }
        Bitmap memorying;
        public void getprintarea(Panel pnl)
        {
            memorying = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memorying, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator qr = new QRCoder.QRCodeGenerator();
            var Mydata = qr.CreateQrCode(txtMaNV.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(Mydata);
            ptbQR.Image = code.GetGraphic(50);
            Print(this.pnlTheNV);
        }
        string imgLocation = "";
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All file(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                imgLocation = dialog.FileName.ToString();
                ptbAnh.ImageLocation = imgLocation;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvNhanVien.CurrentRow.Index;
            txtMaNV.Text = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
            txtTenNV.Text = dgvNhanVien.Rows[i].Cells[1].Value.ToString();
            txtNgaySinh.Text = dgvNhanVien.Rows[i].Cells[2].Value.ToString();
            txtGioiTinh.Text = dgvNhanVien.Rows[i].Cells[6].Value.ToString();

        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTenNV_Click(object sender, EventArgs e)
        {

        }
    }
}
