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
    public partial class NghiPhep : Form
    {
        System.Data.SqlClient.SqlConnection con;
        SqlCommand cmd;
        string str = @"Data Source=LAPTOP-8EBELOTL;Initial Catalog=NhanVien;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tb = new DataTable();
        void loaddata()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from NghiPhep";
            adapter.SelectCommand = cmd;
            tb.Clear();
            adapter.Fill(tb);
            
        }
        public NghiPhep()
        {
            InitializeComponent();
        }

        private void NghiPhep_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            loaddata();
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into NghiPhep values('" + txtMaNV.Text + "', '" + txtTenNV.Text + "','" + txtTu.Text + "','" + txtDen.Text + "','" + txtLyDo.Text + "','" + txtXacNhan.Text + "')";
            cmd.ExecuteNonQuery();
            loaddata();
            con.Close();
            MessageBox.Show("Da gui thanh cong");
        }
    }
}
