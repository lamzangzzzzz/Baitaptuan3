using System.Windows.Forms;
using System.Drawing;

namespace Baitaptuan3_cau3
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
        private ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private ToolStripMenuItem giớiThiệuToolStripMenuItem;
        private ToolStripMenuItem liênHệToolStripMenuItem;

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelUser;
        private ToolStripStatusLabel toolStripStatusLabelForm;
        private ToolStripStatusLabel toolStripStatusLabelTime;
        private Timer timer1;

        private ToolStrip toolStrip1;
        private ToolStripButton btnNV;
        private ToolStripButton btnSP;
        private ToolStripButton btnHD;

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem("Hệ thống (&H)");
            đăngNhậpToolStripMenuItem = new ToolStripMenuItem("Đăng nhập");
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem("Đăng xuất");
            thoátToolStripMenuItem = new ToolStripMenuItem("Thoát (&X)");

            quảnLýToolStripMenuItem = new ToolStripMenuItem("Quản lý (&Q)");
            nhânViênToolStripMenuItem = new ToolStripMenuItem("Nhân viên (&N)");
            sảnPhẩmToolStripMenuItem = new ToolStripMenuItem("Sản phẩm (&S)");
            hóaĐơnToolStripMenuItem = new ToolStripMenuItem("Hóa đơn (&H)");

            trợGiúpToolStripMenuItem = new ToolStripMenuItem("Trợ giúp (&T)");
            giớiThiệuToolStripMenuItem = new ToolStripMenuItem("Giới thiệu");
            liênHệToolStripMenuItem = new ToolStripMenuItem("Liên hệ");

            hệThốngToolStripMenuItem.DropDownItems.AddRange(
                new ToolStripItem[] { đăngNhậpToolStripMenuItem, đăngXuấtToolStripMenuItem, thoátToolStripMenuItem });

            quảnLýToolStripMenuItem.DropDownItems.AddRange(
                new ToolStripItem[] { nhânViênToolStripMenuItem, sảnPhẩmToolStripMenuItem, hóaĐơnToolStripMenuItem });

            trợGiúpToolStripMenuItem.DropDownItems.AddRange(
                new ToolStripItem[] { giớiThiệuToolStripMenuItem, liênHệToolStripMenuItem });

            menuStrip1.Items.AddRange(
                new ToolStripItem[] { hệThốngToolStripMenuItem, quảnLýToolStripMenuItem, trợGiúpToolStripMenuItem });

            // Shortcuts
            đăngNhậpToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.L;
            sảnPhẩmToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            hóaĐơnToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;
            nhânViênToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            thoátToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;

            // Event binding
            sảnPhẩmToolStripMenuItem.Click += sảnPhẩmToolStripMenuItem_Click;
            hóaĐơnToolStripMenuItem.Click += hóaĐơnToolStripMenuItem_Click;
            //nhânViênToolStripMenuItem.Click += nhânViênToolStripMenuItem_Click;
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            đăngNhậpToolStripMenuItem.Click += đăngNhậpToolStripMenuItem_Click;
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            giớiThiệuToolStripMenuItem.Click += giớiThiệuToolStripMenuItem_Click;
            liênHệToolStripMenuItem.Click += liênHệToolStripMenuItem_Click;

            // ToolStrip
            toolStrip1 = new ToolStrip();
            //btnNV = new ToolStripButton("NV", null, nhânViênToolStripMenuItem_Click);
            btnSP = new ToolStripButton("SP", null, sảnPhẩmToolStripMenuItem_Click);
            btnHD = new ToolStripButton("HD", null, hóaĐơnToolStripMenuItem_Click);

            toolStrip1.Items.AddRange(new ToolStripItem[] { btnSP, btnHD });

            // StatusStrip
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelUser = new ToolStripStatusLabel("Người dùng:");
            toolStripStatusLabelForm = new ToolStripStatusLabel("Form:");
            toolStripStatusLabelTime = new ToolStripStatusLabel("");

            statusStrip1.Items.AddRange(
                new ToolStripItem[] { toolStripStatusLabelUser, toolStripStatusLabelForm, toolStripStatusLabelTime });

            // Timer
            timer1 = new Timer(components);
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;

            // Dock
            menuStrip1.Dock = DockStyle.Top;
            toolStrip1.Dock = DockStyle.Top;
            statusStrip1.Dock = DockStyle.Bottom;

            // Form
            IsMdiContainer = true;
            Text = "QUẢN LÝ CỬA HÀNG MINI";
            WindowState = FormWindowState.Maximized;

            Controls.Add(menuStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);

            MainMenuStrip = menuStrip1;
            Load += FormMain_Load;
        }
    }
}
