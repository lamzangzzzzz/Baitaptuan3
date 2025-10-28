using System;
using System.Windows.Forms;

namespace Baitaptuan3_cau3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelUser.Text = "Người dùng: Admin";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelTime.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSanPham f = new FormSanPham();
            f.MdiParent = this;
            f.Show();
            toolStripStatusLabelForm.Text = "Form: Sản phẩm";
        }

    
        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHoaDon f = new FormHoaDon();
            f.MdiParent = this;
            f.Show();
            toolStripStatusLabelForm.Text = "Form: Hóa đơn";
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
                Application.Exit();
        }
        

    }
}
