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
    public partial class MenuNhanVient : Form
    {
        public MenuNhanVient()
        {
            InitializeComponent();
        }
        private Form currentChildForm;
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDestop.Controls.Add(childForm);
            panelDestop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void MenuQuet_Load(object sender, EventArgs e)
        {

        }

        private void thoatToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new BaoDanh());
        }

        private void thoatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Select().Show();
        }

        private void vaoDangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BaoXuat());
        }

        private void kiemTraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void nghiPhepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NghiPhep());
        }

        private void lịchSửĐăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KiemTraChoNV());
        }

        private void nghỉPhépToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KiemTraNghiPhep());
        }
    }
}
