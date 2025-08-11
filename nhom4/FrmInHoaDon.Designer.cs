namespace nhom4
{
    partial class FrmInHoaDon
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
            this.rptHoaDon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnInHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // rptHoaDon
            // 
            this.rptHoaDon.Location = new System.Drawing.Point(12, 12);
            this.rptHoaDon.Name = "rptHoaDon";
            this.rptHoaDon.ServerReport.BearerToken = null;
            this.rptHoaDon.Size = new System.Drawing.Size(776, 551);
            this.rptHoaDon.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(258, 569);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHoaDon.Appearance.Options.UseFont = true;
            this.btnInHoaDon.Location = new System.Drawing.Point(482, 569);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(75, 23);
            this.btnInHoaDon.TabIndex = 2;
            this.btnInHoaDon.Text = "In Hóa Đơn";
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // FrmInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 604);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.rptHoaDon);
            this.Name = "FrmInHoaDon";
            this.Text = "FrmInHoaDon";
            this.Load += new System.EventHandler(this.FrmInHoaDon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptHoaDon;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnInHoaDon;
    }
}