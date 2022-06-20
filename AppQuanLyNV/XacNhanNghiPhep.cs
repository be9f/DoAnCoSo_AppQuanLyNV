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
    public partial class XacNhanNghiPhep : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = @"Data Source=LAPTOP-8EBELOTL;Initial Catalog=NhanVien;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tb = new DataTable();

        public XacNhanNghiPhep()
        {
            InitializeComponent();
        }
        void loaddata()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from NghiPhep";
            adapter.SelectCommand = cmd;
            tb.Clear();
            adapter.Fill(tb);
            dgvThongTin.DataSource = tb;
        }
        
        private void XacNhanNghiPhep_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nhanVienDataSet5.NghiPhep' table. You can move, or remove it, as needed.
            this.nghiPhepTableAdapter.Fill(this.nhanVienDataSet5.NghiPhep);
            con = new SqlConnection(str);
            loaddata();
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "Update NghiPhep set XacNhanChoNghi='" + cbxCoPhep.Text + "'where NghiTuNgay='"+txtTu.Text+ "'and NghiDenNgay='" + txtDen.Text + "'and MaNV='" + txtMaNV.Text + "'";
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void dgvThongTin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvThongTin.CurrentRow.Index;
            txtMaNV.Text = dgvThongTin.Rows[i].Cells[0].Value.ToString();
            txtTenNV.Text = dgvThongTin.Rows[i].Cells[1].Value.ToString();
            txtLyDo.Text = dgvThongTin.Rows[i].Cells[4].Value.ToString();
            txtTu.Text = dgvThongTin.Rows[i].Cells[2].Value.ToString();
            txtDen.Text = dgvThongTin.Rows[i].Cells[3].Value.ToString();
            cbxCoPhep.Text = dgvThongTin.Rows[i].Cells[5].Value.ToString();
        }
    }
    
}
