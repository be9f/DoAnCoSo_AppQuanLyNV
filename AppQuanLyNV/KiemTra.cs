using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace AppQuanLyNV
{
    public partial class KiemTra : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = @"Data Source=LAPTOP-8EBELOTL;Initial Catalog=NhanVien;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tb = new DataTable();

        void loaddata()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select DangNhap.MaNV as MãNV, DangNhap.NgayDangNhap as NgàyVào, DangNhap.ThoiGianDangNhap as ThờiGianVào,DangNhap.TrangThaiDangNhap as TrạngTháiVào,DangNhap.TreGioCoPhep as CóPhép,DangXuat.ThoiGianDangXuat as ThờiGianRa, DangXuat.TrangThaiDangXuat as TrạngTháiRa from DangNhap join DangXuat on DangXuat.NgayDangXuat = DangNhap.NgayDangNhap and DangXuat.MaNV = DangNhap.MaNV";
            adapter.SelectCommand = cmd;
            tb.Clear();
            adapter.Fill(tb);
            dgvBaoDanh.DataSource = tb;
        }
        public KiemTra()
        {
            InitializeComponent();
        }

        private void KiemTra_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            loaddata();
            con.Open();
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from DangNhap where TrangThaiDangNhap= '" + cbxTrangThaiDangNhap.Text + "'";
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvBaoDanh.DataSource = dt;
            
        }

        private void dgvBaoDanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnTimKiem2_Click_1(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from DangXuat where TrangThaiDangXuat= '" + cbxTrangThaiDangXuat.Text + "'";
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvBaoDanh.DataSource = dt;
        }
    }
}
//where NgayDangNhap = '" + dateTimePicker1.Text + "'
