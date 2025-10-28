using System.Windows.Forms;

namespace Baitaptuan3_cau3
{
    partial class FormHoaDon
    {
        private Button btnIn;

        private void InitializeComponent()
        {
            btnIn = new Button();

            btnIn.Text = "In hóa đơn";
            btnIn.Top = 20;
            btnIn.Left = 20;
            btnIn.Width = 120;

            btnIn.Click += btnIn_Click;

            Text = "Hóa đơn bán hàng";
            Controls.Add(btnIn);
        }
    }
}
