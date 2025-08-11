namespace nhom4
{
    partial class FrmSpa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSpa));
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupChucNang = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.BtnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.BtnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.BtnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroupThaoTac = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.BtnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.BtnSave = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroupThoat = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.BtnExit = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.Dgvsanpham = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtMoTa = new System.Windows.Forms.RichTextBox();
            this.CbbDanhmuc = new System.Windows.Forms.ComboBox();
            this.TxtGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CbbLoaidv = new System.Windows.Forms.Label();
            this.TxtTenSanPham = new System.Windows.Forms.TextBox();
            this.TxtTendv = new System.Windows.Forms.Label();
            this.btnThemGioHang = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvsanpham)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupChucNang,
            this.ribbonPageGroupThaoTac,
            this.ribbonPageGroupThoat});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Chức Năng";
            // 
            // ribbonPageGroupChucNang
            // 
            this.ribbonPageGroupChucNang.ItemLinks.Add(this.BtnAdd);
            this.ribbonPageGroupChucNang.ItemLinks.Add(this.BtnUpdate);
            this.ribbonPageGroupChucNang.ItemLinks.Add(this.BtnDelete);
            this.ribbonPageGroupChucNang.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.ribbonPageGroupChucNang.Name = "ribbonPageGroupChucNang";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Caption = "Thêm";
            this.BtnAdd.Id = 8;
            this.BtnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.ImageOptions.Image")));
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.BtnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAdd_ItemClick);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Caption = "Sửa";
            this.BtnUpdate.Id = 9;
            this.BtnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUpdate.ImageOptions.Image")));
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.BtnUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnUpdate_ItemClick);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Caption = "Xóa";
            this.BtnDelete.Id = 10;
            this.BtnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.ImageOptions.Image")));
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.BtnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnDelete_ItemClick);
            // 
            // ribbonPageGroupThaoTac
            // 
            this.ribbonPageGroupThaoTac.ItemLinks.Add(this.BtnCancel);
            this.ribbonPageGroupThaoTac.ItemLinks.Add(this.BtnSave);
            this.ribbonPageGroupThaoTac.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.ribbonPageGroupThaoTac.Name = "ribbonPageGroupThaoTac";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Caption = "Hủy";
            this.BtnCancel.Id = 11;
            this.BtnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancel.ImageOptions.Image")));
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.BtnCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnCancel_ItemClick);
            // 
            // BtnSave
            // 
            this.BtnSave.Caption = "Lưu";
            this.BtnSave.Id = 12;
            this.BtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.ImageOptions.Image")));
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.BtnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnSave_ItemClick);
            // 
            // ribbonPageGroupThoat
            // 
            this.ribbonPageGroupThoat.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            this.ribbonPageGroupThoat.ItemLinks.Add(this.btnThemGioHang);
            this.ribbonPageGroupThoat.ItemLinks.Add(this.BtnExit);
            this.ribbonPageGroupThoat.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.ribbonPageGroupThoat.Name = "ribbonPageGroupThoat";
            // 
            // BtnExit
            // 
            this.BtnExit.Caption = "Thoát";
            this.BtnExit.Id = 13;
            this.BtnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.ImageOptions.Image")));
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.BtnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnExit_ItemClick);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.BtnAdd,
            this.BtnUpdate,
            this.BtnDelete,
            this.BtnCancel,
            this.BtnSave,
            this.BtnExit,
            this.btnThemGioHang});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 15;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(989, 150);
            // 
            // Dgvsanpham
            // 
            this.Dgvsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgvsanpham.Location = new System.Drawing.Point(332, 157);
            this.Dgvsanpham.Name = "Dgvsanpham";
            this.Dgvsanpham.Size = new System.Drawing.Size(644, 442);
            this.Dgvsanpham.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtMoTa);
            this.groupBox1.Controls.Add(this.CbbDanhmuc);
            this.groupBox1.Controls.Add(this.TxtGia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CbbLoaidv);
            this.groupBox1.Controls.Add(this.TxtTenSanPham);
            this.groupBox1.Controls.Add(this.TxtTendv);
            this.groupBox1.Location = new System.Drawing.Point(12, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 443);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // TxtMoTa
            // 
            this.TxtMoTa.Location = new System.Drawing.Point(122, 215);
            this.TxtMoTa.Name = "TxtMoTa";
            this.TxtMoTa.Size = new System.Drawing.Size(172, 100);
            this.TxtMoTa.TabIndex = 19;
            this.TxtMoTa.Text = "";
            // 
            // CbbDanhmuc
            // 
            this.CbbDanhmuc.FormattingEnabled = true;
            this.CbbDanhmuc.Location = new System.Drawing.Point(122, 108);
            this.CbbDanhmuc.Name = "CbbDanhmuc";
            this.CbbDanhmuc.Size = new System.Drawing.Size(121, 21);
            this.CbbDanhmuc.TabIndex = 18;
            // 
            // TxtGia
            // 
            this.TxtGia.Location = new System.Drawing.Point(122, 162);
            this.TxtGia.Name = "TxtGia";
            this.TxtGia.Size = new System.Drawing.Size(100, 20);
            this.TxtGia.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(18, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(18, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mô tả";
            // 
            // CbbLoaidv
            // 
            this.CbbLoaidv.AutoSize = true;
            this.CbbLoaidv.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CbbLoaidv.ForeColor = System.Drawing.Color.Red;
            this.CbbLoaidv.Location = new System.Drawing.Point(18, 111);
            this.CbbLoaidv.Name = "CbbLoaidv";
            this.CbbLoaidv.Size = new System.Drawing.Size(88, 17);
            this.CbbLoaidv.TabIndex = 10;
            this.CbbLoaidv.Text = "Loại dịch vụ";
            // 
            // TxtTenSanPham
            // 
            this.TxtTenSanPham.Location = new System.Drawing.Point(122, 53);
            this.TxtTenSanPham.Name = "TxtTenSanPham";
            this.TxtTenSanPham.Size = new System.Drawing.Size(172, 20);
            this.TxtTenSanPham.TabIndex = 9;
            // 
            // TxtTendv
            // 
            this.TxtTendv.AutoSize = true;
            this.TxtTendv.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TxtTendv.ForeColor = System.Drawing.Color.Red;
            this.TxtTendv.Location = new System.Drawing.Point(18, 53);
            this.TxtTendv.Name = "TxtTendv";
            this.TxtTendv.Size = new System.Drawing.Size(85, 17);
            this.TxtTendv.TabIndex = 8;
            this.TxtTendv.Text = "Tên dịch vụ";
            // 
            // btnThemGioHang
            // 
            this.btnThemGioHang.Caption = "Thêm vào giỏ";
            this.btnThemGioHang.Id = 14;
            this.btnThemGioHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemGioHang.ImageOptions.Image")));
            this.btnThemGioHang.Name = "btnThemGioHang";
            this.btnThemGioHang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnThemGioHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemGioHang_ItemClick);
            // 
            // FrmSpa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 611);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.Dgvsanpham);
            this.Name = "FrmSpa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spa";
            this.Load += new System.EventHandler(this.FrmSpa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvsanpham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private System.Windows.Forms.DataGridView Dgvsanpham;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CbbDanhmuc;
        private System.Windows.Forms.TextBox TxtGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CbbLoaidv;
        private System.Windows.Forms.TextBox TxtTenSanPham;
        private System.Windows.Forms.Label TxtTendv;
        private System.Windows.Forms.RichTextBox TxtMoTa;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupChucNang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupThaoTac;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupThoat;
        private DevExpress.XtraBars.BarButtonItem BtnAdd;
        private DevExpress.XtraBars.BarButtonItem BtnUpdate;
        private DevExpress.XtraBars.BarButtonItem BtnDelete;
        private DevExpress.XtraBars.BarButtonItem BtnCancel;
        private DevExpress.XtraBars.BarButtonItem BtnSave;
        private DevExpress.XtraBars.BarButtonItem BtnExit;
        private DevExpress.XtraBars.BarButtonItem btnThemGioHang;
    }
}