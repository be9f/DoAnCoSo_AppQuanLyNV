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

namespace AppQuanLyNV
{
    public partial class XacNhan : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = @"Data Source=LAPTOP-8EBELOTL;Initial Catalog=NhanVien;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tb = new DataTable();
        void loaddata()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from DangNhap where TrangThaiDangNhap = 'Di tre'";
            adapter.SelectCommand = cmd;
            tb.Clear();
            adapter.Fill(tb);
            dgvThongTin.DataSource = tb;
        }
        public XacNhan()
        {
            InitializeComponent();
        }

        private void XacNhan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nhanVienDataSet4.DangNhap' table. You can move, or remove it, as needed.
            this.dangNhapTableAdapter1.Fill(this.nhanVienDataSet4.DangNhap);
            // TODO: This line of code loads data into the 'nhanVienDataSet3.DangXuat' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'nhanVienDataSet1.DangNhap' table. You can move, or remove it, as needed.

            con = new SqlConnection(str);
            loaddata();
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "Update DangNhap set TreGioCoPhep='" + cbxCoPhep.Text + "' where MaNV = '"+txtMaNV.Text+ "'and NgayDangNhap = '" + dtpNgayDangNhap.Text + "'and ThoiGianDangNhap = '" + txtThoiGian.Text + "' and TrangThaiDangNhap = 'Di tre'";
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void dgvThongTin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvThongTin.CurrentRow.Index;
            txtMaNV.Text = dgvThongTin.Rows[i].Cells[0].Value.ToString();
            dtpNgayDangNhap.Text = dgvThongTin.Rows[i].Cells[1].Value.ToString();
            txtThoiGian.Text = dgvThongTin.Rows[i].Cells[2].Value.ToString();
            txtTrangThai.Text = dgvThongTin.Rows[i].Cells[3].Value.ToString();
            cbxCoPhep.Text = dgvThongTin.Rows[i].Cells[4].Value.ToString();
            
        }
    }
}
