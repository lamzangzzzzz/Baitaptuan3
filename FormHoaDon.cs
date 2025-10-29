using System;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Baitaptuan3_cau3
{
    public partial class FormHoaDon : Form
    {
        decimal tongTien = 0;
        PrintDocument printDoc = new PrintDocument();

        public FormHoaDon()
        {
            InitializeComponent();
            LoadSanPhamList();
            dtNgayLap.Value = DateTime.Now;
            numSoLuong.Minimum = 1;
            numSoLuong.Value = 1;

            printDoc.PrintPage += PrintDoc_PrintPage;
        }

        // CLASS SP
        public class SanPham
        {
            public string Ten { get; set; }
            public decimal Gia { get; set; }

            public override string ToString()
            {
                return $"{Ten} - {Gia:N0}đ";
            }
        }

        // Load sample items
        private void LoadSanPhamList()
        {
            clbSanPham.Items.Add(new SanPham() { Ten = "Bánh mì", Gia = 15000 });
            clbSanPham.Items.Add(new SanPham() { Ten = "Trứng gà", Gia = 30000 });
            clbSanPham.Items.Add(new SanPham() { Ten = "Coca-Cola", Gia = 12000 });
            clbSanPham.Items.Add(new SanPham() { Ten = "Nước suối", Gia = 7000 });
            clbSanPham.Items.Add(new SanPham() { Ten = "Snack Lay's", Gia = 18000 });
        }

        // ADD MULTIPLE
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (clbSanPham.CheckedItems.Count == 0)
                return;

            int sl = (int)numSoLuong.Value;

            foreach (var obj in clbSanPham.CheckedItems)
            {
                SanPham sp = (SanPham)obj;
                decimal thanhTien = sp.Gia * sl;

                ListViewItem item = new ListViewItem(sp.Ten);
                item.SubItems.Add(sl.ToString());
                item.SubItems.Add(sp.Gia.ToString("N0"));
                item.SubItems.Add(thanhTien.ToString("N0"));

                lvHoaDon.Items.Add(item);

                tongTien += thanhTien;
            }

            lblTong.Text = tongTien.ToString("N0") + " VNĐ";

            for (int i = 0; i < clbSanPham.Items.Count; i++)
                clbSanPham.SetItemChecked(i, false);
        }

        // REMOVE SELECTED
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvHoaDon.SelectedItems.Count == 0) return;

            foreach (ListViewItem item in lvHoaDon.SelectedItems)
            {
                tongTien -= decimal.Parse(item.SubItems[3].Text.Replace(".", ""));
                lvHoaDon.Items.Remove(item);
            }

            lblTong.Text = tongTien.ToString("N0") + " VNĐ";
        }

        // PRINT
        private void btnIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKhachHang.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!");
                return;
            }

            PrintPreviewDialog pp = new PrintPreviewDialog();
            pp.Document = printDoc;
            pp.ShowDialog();
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            float y = 20;
            Font f = new Font("Arial", 12);

            e.Graphics.DrawString("HÓA ĐƠN BÁN HÀNG", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, 20, y);
            y += 40;

            e.Graphics.DrawString("Khách hàng: " + txtKhachHang.Text, f, Brushes.Black, 20, y); y += 25;
            e.Graphics.DrawString("Ngày lập : " + dtNgayLap.Value, f, Brushes.Black, 20, y); y += 25;
            e.Graphics.DrawString("-------------------------------------", f, Brushes.Black, 20, y); y += 25;

            foreach (ListViewItem row in lvHoaDon.Items)
            {
                string line = $"{row.Text} x{row.SubItems[1].Text} = {row.SubItems[3].Text}";
                e.Graphics.DrawString(line, f, Brushes.Black, 20, y);
                y += 20;
            }

            y += 10;
            e.Graphics.DrawString("-------------------------------------", f, Brushes.Black, 20, y); y += 25;
            e.Graphics.DrawString("Tổng tiền: " + tongTien.ToString("N0") + " VNĐ", f, Brushes.Black, 20, y);
        }

        // SAVE TXT
        private void btnLuu_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File|*.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    sw.WriteLine("HÓA ĐƠN BÁN HÀNG");
                    sw.WriteLine("Khách hàng: " + txtKhachHang.Text);
                    sw.WriteLine("Ngày lập: " + dtNgayLap.Value);
                    sw.WriteLine("-------------------------------------");

                    foreach (ListViewItem row in lvHoaDon.Items)
                    {
                        sw.WriteLine($"{row.Text} x{row.SubItems[1].Text} = {row.SubItems[3].Text}");
                    }

                    sw.WriteLine("-------------------------------------");
                    sw.WriteLine("Tổng tiền: " + tongTien.ToString("N0") + " VNĐ");
                }

                MessageBox.Show("Lưu thành công!");
            }
        }
    }
}
