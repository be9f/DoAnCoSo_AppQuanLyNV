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
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
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

        private void báoDanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TheNhanVien());
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhanVien());
        }

        private void nhậpThôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KiemTra());
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Select().Show();
        }

        private void xacNhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void diTreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new XacNhan());
        }

        private void nghiPhepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new XacNhanNghiPhep());
        }
    }
}
