using System.Windows.Forms;

namespace Baitaptuan3_cau3
{
    partial class FormSanPham
    {
        private System.ComponentModel.IContainer components = null;
        private SplitContainer splitContainer1;
        private TreeView treeView1;
        private ListView listView1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem xemChiTietToolStripMenuItem;
        private ToolStripMenuItem xoaSanPhamToolStripMenuItem;
        private Button btnImport;
        private Button btnExport;
        private Button btnMoPhong;
        private ProgressBar progressBar1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.splitContainer1 = new SplitContainer();
            this.treeView1 = new TreeView();
            this.listView1 = new ListView();
            this.contextMenuStrip1 = new ContextMenuStrip(this.components);
            this.xemChiTietToolStripMenuItem = new ToolStripMenuItem("Xem chi tiết");
            this.xoaSanPhamToolStripMenuItem = new ToolStripMenuItem("Xóa sản phẩm");
            this.btnImport = new Button();
            this.btnExport = new Button();
            this.btnMoPhong = new Button();
            this.progressBar1 = new ProgressBar();

            // SplitContainer
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.SplitterDistance = 200;

            splitContainer1.Panel1.Controls.Add(treeView1);
            splitContainer1.Panel2.Controls.Add(listView1);

            // ===== THÊM CÁC NÚT VÀO PANEL2 =====
            splitContainer1.Panel2.Controls.Add(btnImport);
            splitContainer1.Panel2.Controls.Add(btnExport);
            splitContainer1.Panel2.Controls.Add(btnMoPhong);
            splitContainer1.Panel2.Controls.Add(progressBar1);

            // TreeView
            treeView1.Dock = DockStyle.Fill;
            treeView1.AfterSelect += new TreeViewEventHandler(this.treeView1_AfterSelect);

            // ListView
            listView1.View = View.Details;
            listView1.Columns.Add("Mã", 80);
            listView1.Columns.Add("Tên", 150);
            listView1.Columns.Add("Giá", 80);
            listView1.Columns.Add("Tồn kho", 80);
            listView1.Dock = DockStyle.Bottom;
            listView1.Height = 350; // tránh che nút

            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.MultiSelect = false;
            listView1.HideSelection = false;
            listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);

            // ContextMenu
            contextMenuStrip1.Items.AddRange(new ToolStripItem[]
            {
                xemChiTietToolStripMenuItem, xoaSanPhamToolStripMenuItem
            });
            listView1.ContextMenuStrip = contextMenuStrip1;

            // Hook context menu events
            xemChiTietToolStripMenuItem.Click += new System.EventHandler(this.xemChiTietToolStripMenuItem_Click);
            xoaSanPhamToolStripMenuItem.Click += new System.EventHandler(this.xoaSanPhamToolStripMenuItem_Click);

            // Buttons
            btnImport.Text = "Import";
            btnExport.Text = "Export";
            btnMoPhong.Text = "Mô phỏng Export";

            btnImport.Top = 5;
            btnExport.Top = 5;
            btnMoPhong.Top = 5;

            btnImport.Left = 10;
            btnExport.Left = 90;
            btnMoPhong.Left = 170;

            btnImport.Click += new System.EventHandler(this.btnImport_Click);
            btnExport.Click += new System.EventHandler(this.btnExport_Click);
            btnMoPhong.Click += new System.EventHandler(this.btnMoPhong_Click);

            // ProgressBar
            progressBar1.Top = 35;
            progressBar1.Left = 10;
            progressBar1.Width = 300;
            progressBar1.Value = 0;

            // Form
            Controls.Add(splitContainer1);

            Text = "Quản lý sản phẩm";
            Width = 720;
            Height = 500;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
