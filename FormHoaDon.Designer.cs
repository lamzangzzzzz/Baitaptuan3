using System.Drawing;

namespace Baitaptuan3_cau3
{
    partial class FormHoaDon
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox clbSanPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ListView lvHoaDon;
        private System.Windows.Forms.ColumnHeader colTen;
        private System.Windows.Forms.ColumnHeader colSl;
        private System.Windows.Forms.ColumnHeader colGia;
        private System.Windows.Forms.ColumnHeader colThanhTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtNgayLap;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnLuu;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clbSanPham = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lvHoaDon = new System.Windows.Forms.ListView();
            this.colTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.lblTong = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtNgayLap = new System.Windows.Forms.DateTimePicker();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khách hàng:";
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Location = new System.Drawing.Point(140, 18);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(200, 22);
            this.txtKhachHang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sản phẩm:";
            // 
            // clbSanPham
            // 
            this.clbSanPham.Location = new System.Drawing.Point(140, 90);
            this.clbSanPham.Name = "clbSanPham";
            this.clbSanPham.Size = new System.Drawing.Size(200, 89);
            this.clbSanPham.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số lượng:";
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(140, 195);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(80, 22);
            this.numSoLuong.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(240, 195);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(320, 195);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa SP";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lvHoaDon
            // 
            this.lvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTen,
            this.colSl,
            this.colGia,
            this.colThanhTien});
            this.lvHoaDon.HideSelection = false;
            this.lvHoaDon.Location = new System.Drawing.Point(20, 240);
            this.lvHoaDon.Name = "lvHoaDon";
            this.lvHoaDon.Size = new System.Drawing.Size(450, 200);
            this.lvHoaDon.TabIndex = 8;
            this.lvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lvHoaDon.View = System.Windows.Forms.View.Details;
            // 
            // colTen
            // 
            this.colTen.Text = "Tên SP";
            this.colTen.Width = 150;
            // 
            // colSl
            // 
            this.colSl.Text = "SL";
            this.colSl.Width = 50;
            // 
            // colGia
            // 
            this.colGia.Text = "Đơn giá";
            this.colGia.Width = 100;
            // 
            // colThanhTien
            // 
            this.colThanhTien.Text = "Thành tiền";
            this.colThanhTien.Width = 120;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tổng tiền:";
            // 
            // lblTong
            // 
            this.lblTong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTong.Location = new System.Drawing.Point(120, 450);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(100, 23);
            this.lblTong.TabIndex = 10;
            this.lblTong.Text = "0 VNĐ";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(20, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ngày lập:";
            // 
            // dtNgayLap
            // 
            this.dtNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dtNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayLap.Location = new System.Drawing.Point(140, 50);
            this.dtNgayLap.Name = "dtNgayLap";
            this.dtNgayLap.Size = new System.Drawing.Size(200, 22);
            this.dtNgayLap.TabIndex = 12;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(20, 490);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(75, 23);
            this.btnThanhToan.TabIndex = 13;
            this.btnThanhToan.Text = "Thanh toán";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(140, 490);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 14;
            this.btnIn.Text = "In hóa đơn";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(260, 490);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "Lưu TXT";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // FormHoaDon
            // 
            this.ClientSize = new System.Drawing.Size(500, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKhachHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clbSanPham);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numSoLuong);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lvHoaDon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtNgayLap);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnLuu);
            this.Name = "FormHoaDon";
            this.Text = "Tạo hóa đơn bán hàng";
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
