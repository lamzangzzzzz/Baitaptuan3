using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitaptuan3_cau3
{
    public partial class FormSanPham : Form
    {
        private readonly Dictionary<string, List<SanPham>> _danhMuc =
            new Dictionary<string, List<SanPham>>();

        public FormSanPham()
        {
            InitializeComponent();
            KhoiTaoDuLieu();
            LoadTree();
        }

        private void LoadTree()
        {
            TreeNode root = new TreeNode("Danh mục sản phẩm");
            root.Nodes.Add("Thực phẩm");
            root.Nodes.Add("Đồ uống");
            root.Nodes.Add("Gia vị");
            root.Nodes.Add("Đồ gia dụng");

            treeView1.Nodes.Add(root);
            root.Expand();
            treeView1.AfterSelect -= treeView1_AfterSelect;
            treeView1.AfterSelect += treeView1_AfterSelect;
        }

        private void KhoiTaoDuLieu()
        {
            _danhMuc["Thực phẩm"] = new List<SanPham>()
            {
                new SanPham("TP01","Bánh mì",15000,120),
                new SanPham("TP02","Trứng gà",30000,80),
                new SanPham("TP03","Cơm hộp",25000,60)
            };

            _danhMuc["Đồ uống"] = new List<SanPham>()
            {
                new SanPham("DU01","Coca-Cola",12000,100),
                new SanPham("DU02","Trà xanh",10000,80),
                new SanPham("DU03","Nước suối",7000,150)
            };

            _danhMuc["Gia vị"] = new List<SanPham>()
            {
                new SanPham("GV01","Muối ăn",5000,200),
                new SanPham("GV02","Đường",10000,180),
                new SanPham("GV03","Tiêu xay",12000,90)
            };

            _danhMuc["Đồ gia dụng"] = new List<SanPham>()
            {
                new SanPham("GD01","Chảo chống dính",250000,40),
                new SanPham("GD02","Bếp gas mini",350000,25),
                new SanPham("GD03","Bình nước",80000,70)
            };
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string dm = e.Node.Text;

            listView1.Items.Clear();
            if (!_danhMuc.ContainsKey(dm))
                return;

            foreach (var sp in _danhMuc[dm])
            {
                var item = new ListViewItem(sp.Ma);
                item.SubItems.Add(sp.Ten);
                item.SubItems.Add(sp.Gia.ToString("N0", CultureInfo.InvariantCulture));
                item.SubItems.Add(sp.TonKho.ToString());
                item.Tag = sp;
                listView1.Items.Add(item);
            }
        }

        private void xemChiTietToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemChiTiet();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            XemChiTiet();
        }

        private void XemChiTiet()
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var item = listView1.SelectedItems[0];
            if (item.Tag is SanPham sp)
            {
                MessageBox.Show(
                    $"Mã: {sp.Ma}\nTên: {sp.Ten}\nGiá: {sp.Gia:N0} VNĐ\nTồn kho: {sp.TonKho}",
                    "Chi tiết sản phẩm",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void xoaSanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            var item = listView1.SelectedItems[0];
            if (!(item.Tag is SanPham sp)) return;

            var result = MessageBox.Show(
                $"Bạn có chắc muốn xóa '{sp.Ten}' không?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string danhMuc = treeView1.SelectedNode?.Text ?? "";
                if (_danhMuc.ContainsKey(danhMuc))
                {
                    _danhMuc[danhMuc].Remove(sp);
                }
                listView1.Items.Remove(item);
            }
        }

      
        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var lines = File.ReadAllLines(ofd.FileName);

                foreach (var line in lines.Skip(1)) 
                {
                    var c = line.Split(',');
                    var sp = new SanPham(c[0], c[1], decimal.Parse(c[2]), int.Parse(c[3]));
                    string dm = c[4];

                    if (!_danhMuc.ContainsKey(dm))
                        _danhMuc[dm] = new List<SanPham>();

                    _danhMuc[dm].Add(sp);
                }

                MessageBox.Show("Import thành công!");

                if (treeView1.SelectedNode != null)
                    treeView1_AfterSelect(null, new TreeViewEventArgs(treeView1.SelectedNode));
            }
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV|*.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (var sw = new StreamWriter(sfd.FileName))
                {
                    sw.WriteLine("DanhMuc,Ma,Ten,Gia,TonKho,DoanhThu");

                    foreach (var dm in _danhMuc)
                    {
                        foreach (var sp in dm.Value)
                        {
                            decimal dt = sp.Gia * sp.TonKho;
                            sw.WriteLine($"{dm.Key},{sp.Ma},{sp.Ten},{sp.Gia},{sp.TonKho},{dt}");
                        }
                    }
                }

                MessageBox.Show("Xuất báo cáo doanh thu thành công!");
            }
        }


        private async void btnMoPhong_Click(object sender, EventArgs e)
        {
            var all = _danhMuc.Values.Sum(list => list.Count);
            progressBar1.Value = 0;
            int done = 0;

            foreach (var dm in _danhMuc.Values)
            {
                foreach (var sp in dm)
                {
                    await Task.Delay(1000);
                    done++;
                    progressBar1.Value = (done * 100) / all;
                }
            }

            MessageBox.Show("Mô phỏng xuất hoàn tất!");
        }

        private class SanPham
        {
            public string Ma { get; }
            public string Ten { get; }
            public decimal Gia { get; }
            public int TonKho { get; set; }

            public SanPham(string ma, string ten, decimal gia, int tonKho)
            {
                Ma = ma;
                Ten = ten;
                Gia = gia;
                TonKho = tonKho;
            }
        }
    }
}
