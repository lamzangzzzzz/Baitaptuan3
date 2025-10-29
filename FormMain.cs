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

        private void MdiShow<T>() where T : Form, new()
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is T)
                {
                    frm.Activate();
                    return;
                }
            }
            T f = new T();
            f.MdiParent = this;
            f.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdiShow<FormSanPham>();
            toolStripStatusLabelForm.Text = "Form: Sản phẩm";
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdiShow<FormHoaDon>();
            toolStripStatusLabelForm.Text = "Form: Hóa đơn";
        }

        

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
                Application.Exit();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelUser.Text = "Người dùng: Admin";
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelUser.Text = "Người dùng: (Chưa đăng nhập)";
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ứng dụng Quản lý cửa hàng mini.\nUEH - WinForms", "Giới thiệu");
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Email hỗ trợ: tuannm@ueh.edu.vn", "Liên hệ");
        }
    }
}
