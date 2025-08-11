namespace nhom4
{
    partial class FrmTrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrangChu));
            this.BtnHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.BtnSanPham = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGioHang = new DevExpress.XtraEditors.SimpleButton();
            this.BtnHotel = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSpa = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKhachHang = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNhanVien = new DevExpress.XtraEditors.SimpleButton();
            this.imageSlider2 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnHoaDon
            // 
            this.BtnHoaDon.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHoaDon.Appearance.ForeColor = System.Drawing.Color.Red;
            this.BtnHoaDon.Appearance.Options.UseFont = true;
            this.BtnHoaDon.Appearance.Options.UseForeColor = true;
            this.BtnHoaDon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnHoaDon.ImageOptions.Image")));
            this.BtnHoaDon.Location = new System.Drawing.Point(297, 641);
            this.BtnHoaDon.Name = "BtnHoaDon";
            this.BtnHoaDon.Size = new System.Drawing.Size(200, 94);
            this.BtnHoaDon.TabIndex = 5;
            this.BtnHoaDon.Text = "Hóa Đơn";
            this.BtnHoaDon.Click += new System.EventHandler(this.BtnHoaDon_Click);
            // 
            // searchControl1
            // 
            this.searchControl1.Location = new System.Drawing.Point(57, 207);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Size = new System.Drawing.Size(923, 20);
            this.searchControl1.TabIndex = 26;
            this.searchControl1.SelectedIndexChanged += new System.EventHandler(this.searchControl1_SelectedIndexChanged);
            // 
            // BtnSanPham
            // 
            this.BtnSanPham.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSanPham.Appearance.ForeColor = System.Drawing.Color.Red;
            this.BtnSanPham.Appearance.Options.UseFont = true;
            this.BtnSanPham.Appearance.Options.UseForeColor = true;
            this.BtnSanPham.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSanPham.ImageOptions.Image")));
            this.BtnSanPham.Location = new System.Drawing.Point(57, 252);
            this.BtnSanPham.Name = "BtnSanPham";
            this.BtnSanPham.Size = new System.Drawing.Size(200, 95);
            this.BtnSanPham.TabIndex = 1;
            this.BtnSanPham.Text = "Sản phẩm";
            this.BtnSanPham.Click += new System.EventHandler(this.BtnSanPham_Click);
            // 
            // BtnGioHang
            // 
            this.BtnGioHang.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGioHang.Appearance.ForeColor = System.Drawing.Color.Red;
            this.BtnGioHang.Appearance.Options.UseFont = true;
            this.BtnGioHang.Appearance.Options.UseForeColor = true;
            this.BtnGioHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGioHang.ImageOptions.Image")));
            this.BtnGioHang.Location = new System.Drawing.Point(780, 252);
            this.BtnGioHang.Name = "BtnGioHang";
            this.BtnGioHang.Size = new System.Drawing.Size(200, 95);
            this.BtnGioHang.TabIndex = 4;
            this.BtnGioHang.Text = "Giỏ Hàng";
            this.BtnGioHang.Click += new System.EventHandler(this.BtnGioHang_Click);
            // 
            // BtnHotel
            // 
            this.BtnHotel.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHotel.Appearance.ForeColor = System.Drawing.Color.Red;
            this.BtnHotel.Appearance.Options.UseFont = true;
            this.BtnHotel.Appearance.Options.UseForeColor = true;
            this.BtnHotel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnHotel.ImageOptions.Image")));
            this.BtnHotel.Location = new System.Drawing.Point(540, 252);
            this.BtnHotel.Name = "BtnHotel";
            this.BtnHotel.Size = new System.Drawing.Size(200, 95);
            this.BtnHotel.TabIndex = 3;
            this.BtnHotel.Text = "Hotel";
            this.BtnHotel.Click += new System.EventHandler(this.BtnHotel_Click);
            // 
            // BtnSpa
            // 
            this.BtnSpa.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSpa.Appearance.ForeColor = System.Drawing.Color.Red;
            this.BtnSpa.Appearance.Options.UseFont = true;
            this.BtnSpa.Appearance.Options.UseForeColor = true;
            this.BtnSpa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSpa.ImageOptions.Image")));
            this.BtnSpa.Location = new System.Drawing.Point(297, 252);
            this.BtnSpa.Name = "BtnSpa";
            this.BtnSpa.Size = new System.Drawing.Size(200, 95);
            this.BtnSpa.TabIndex = 2;
            this.BtnSpa.Text = "Spa";
            this.BtnSpa.Click += new System.EventHandler(this.BtnSpa_Click);
            // 
            // BtnKhachHang
            // 
            this.BtnKhachHang.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKhachHang.Appearance.ForeColor = System.Drawing.Color.Red;
            this.BtnKhachHang.Appearance.Options.UseFont = true;
            this.BtnKhachHang.Appearance.Options.UseForeColor = true;
            this.BtnKhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKhachHang.ImageOptions.Image")));
            this.BtnKhachHang.Location = new System.Drawing.Point(780, 640);
            this.BtnKhachHang.Name = "BtnKhachHang";
            this.BtnKhachHang.Size = new System.Drawing.Size(200, 95);
            this.BtnKhachHang.TabIndex = 7;
            this.BtnKhachHang.Text = "Khách Hàng";
            this.BtnKhachHang.Click += new System.EventHandler(this.BtnKhachHang_Click);
            // 
            // BtnNhanVien
            // 
            this.BtnNhanVien.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNhanVien.Appearance.ForeColor = System.Drawing.Color.Red;
            this.BtnNhanVien.Appearance.Options.UseFont = true;
            this.BtnNhanVien.Appearance.Options.UseForeColor = true;
            this.BtnNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnNhanVien.ImageOptions.Image")));
            this.BtnNhanVien.Location = new System.Drawing.Point(540, 640);
            this.BtnNhanVien.Name = "BtnNhanVien";
            this.BtnNhanVien.Size = new System.Drawing.Size(200, 95);
            this.BtnNhanVien.TabIndex = 6;
            this.BtnNhanVien.Text = "Nhân viên";
            this.BtnNhanVien.Click += new System.EventHandler(this.BtnNhanVien_Click);
            // 
            // imageSlider2
            // 
            this.imageSlider2.AnimationTime = 4;
            this.imageSlider2.CurrentImageIndex = 0;
            this.imageSlider2.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider2.Images"))));
            this.imageSlider2.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider2.Images1"))));
            this.imageSlider2.Location = new System.Drawing.Point(57, 388);
            this.imageSlider2.Name = "imageSlider2";
            this.imageSlider2.Size = new System.Drawing.Size(923, 215);
            this.imageSlider2.TabIndex = 16;
            this.imageSlider2.Text = "imageSlider2";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1047, 200);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::nhom4.Properties.Resources.pet_shop;
            this.pictureBox1.Location = new System.Drawing.Point(350, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(57, 699);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(112, 36);
            this.btn_Exit.TabIndex = 28;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // FrmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1047, 748);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnHoaDon);
            this.Controls.Add(this.searchControl1);
            this.Controls.Add(this.BtnSanPham);
            this.Controls.Add(this.BtnGioHang);
            this.Controls.Add(this.BtnHotel);
            this.Controls.Add(this.BtnSpa);
            this.Controls.Add(this.BtnKhachHang);
            this.Controls.Add(this.BtnNhanVien);
            this.Controls.Add(this.imageSlider2);
            this.Name = "FrmTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            this.Load += new System.EventHandler(this.FrmTrangChu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton BtnGioHang;
        private DevExpress.XtraEditors.SimpleButton BtnHotel;
        private DevExpress.XtraEditors.SimpleButton BtnSpa;
        private DevExpress.XtraEditors.SimpleButton BtnKhachHang;
        private DevExpress.XtraEditors.SimpleButton BtnNhanVien;
        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider2;
        private DevExpress.XtraEditors.SimpleButton BtnSanPham;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraEditors.SimpleButton BtnHoaDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton btn_Exit;
    }
}

