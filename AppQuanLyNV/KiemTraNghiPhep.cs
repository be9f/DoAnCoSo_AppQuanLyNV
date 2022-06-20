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
    public partial class KiemTraNghiPhep : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = @"Data Source=LAPTOP-8EBELOTL;Initial Catalog=NhanVien;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tb = new DataTable();
        void loaddata()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select *from NghiPhep ";
            adapter.SelectCommand = cmd;
            tb.Clear();
            adapter.Fill(tb);
            dgvThongTin.DataSource = tb;
        }
        public KiemTraNghiPhep()
        {
            InitializeComponent();
        }

        private void KiemTraNghiPhep_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nhanVienDataSet2.NghiPhep' table. You can move, or remove it, as needed.
            this.nghiPhepTableAdapter.Fill(this.nhanVienDataSet2.NghiPhep);
            con = new SqlConnection(str);
            loaddata();
            con.Open();

        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from NghiPhep where MaNV = '" + txtMaNV.Text + "'";
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvThongTin.DataSource = dt;
        }

     /*   private void dgvThongTin_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex > 0 && e.ColumnIndex == this.dgvThongTin.Columns["XacNhanChoNghi"].Index)
            {
                if (e.Value != null)
                {
                    string CNumColour = e.Value.ToString();
                    if (CNumColour == "Khong chap nhan" )
                    {
                        this.dgvThongTin.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                    }
                }

            }
        }*/
    }
}
