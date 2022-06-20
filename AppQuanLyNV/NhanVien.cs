using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace AppQuanLyNV
{
    public partial class NhanVien : Form
    {
            SqlConnection con;
            SqlCommand cmd;
            string str = @"Data Source=LAPTOP-8EBELOTL;Initial Catalog=NhanVien;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable tb = new DataTable();

            void loaddata()
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "select * from NhanVien";
                adapter.SelectCommand = cmd;
                tb.Clear();
                adapter.Fill(tb);
                dgvNhanVien.DataSource = tb;
            }
        public NhanVien()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nhanVienDataSet.NhanVien' table. You can move, or remove it, as needed.
            
            con = new SqlConnection(str);
            loaddata();
            con.Open();
            
        }

        

        private void btnThem_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into NhanVien values('" + txtMaNV.Text + "', '" + txtTenNV.Text + "','" + dtpNgaySinh.Text + "','" + txtDiaChi.Text + "','" + txtSDT.Text + "','" + txtCMND.Text + "','" + cbxGioiTinh.Text + "','" + txtChucVu.Text + "')";
            cmd.ExecuteNonQuery(); 
            loaddata();
            con.Close();
        }
   
        private void btnXoa_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "Delete from NhanVien where MaNV='"+txtMaNV.Text+"'";
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "Update NhanVien set TenNV='" + txtTenNV.Text + "',NgaySinhNV='" + dtpNgaySinh.Text + "',DiaChiNV='" + txtDiaChi.Text + "',SDT='" + txtSDT.Text + "',CMND='" + txtCMND.Text + "',GioiTinh='" + cbxGioiTinh.Text + "',ChucVu='" + txtChucVu.Text + "' where MaNV='" + txtMaNV.Text + "'";
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvNhanVien.CurrentRow.Index;
            txtMaNV.Text = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
            txtTenNV.Text = dgvNhanVien.Rows[i].Cells[1].Value.ToString();
            dtpNgaySinh.Text = dgvNhanVien.Rows[i].Cells[2].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.Rows[i].Cells[3].Value.ToString();
            txtSDT.Text = dgvNhanVien.Rows[i].Cells[4].Value.ToString();
            txtCMND.Text = dgvNhanVien.Rows[i].Cells[5].Value.ToString();
            cbxGioiTinh.Text = dgvNhanVien.Rows[i].Cells[6].Value.ToString();
            txtChucVu.Text = dgvNhanVien.Rows[i].Cells[7].Value.ToString();
        }
    }
}
