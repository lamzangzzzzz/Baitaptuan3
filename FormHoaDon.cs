using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Baitaptuan3_cau3
{
    public partial class FormHoaDon : Form
    {
        PrintDocument printDocument = new PrintDocument();

        public FormHoaDon()
        {
            InitializeComponent();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Tên khách: Nguyễn Văn A", new Font("Arial", 14), Brushes.Black, 50, 50);
            e.Graphics.DrawString("Sản phẩm: Coca x2", new Font("Arial", 12), Brushes.Black, 50, 80);
            e.Graphics.DrawString("Tổng tiền: 24.000đ", new Font("Arial", 12), Brushes.Black, 50, 110);
            e.Graphics.DrawString(DateTime.Now.ToString(), new Font("Arial", 12), Brushes.Black, 50, 140);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = printDocument;
            dlg.ShowDialog();
        }
    }
}
