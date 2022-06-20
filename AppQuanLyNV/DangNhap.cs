using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyNV
{
    public partial class DangNhap : Form
    {

        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text=="admin"&& txtPassword.Text == "admin")
            {
                new MenuAdmin().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nhập sai tên tài khoản hoặc mật khẩu: Thử nhập lại");
                txtLogin.Clear();
                txtPassword.Clear();
                txtLogin.Focus();
                
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Select().Show();
        }
    }
}
