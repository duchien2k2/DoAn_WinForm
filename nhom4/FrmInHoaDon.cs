using Microsoft.Reporting.WinForms;
using nhom4.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nhom4
{
    public partial class FrmInHoaDon : Form
    {
        private readonly HoaDonReportVM _vm;
        public FrmInHoaDon(HoaDonReportVM vm)
        {
            InitializeComponent();
            _vm = vm;
        }

        private void FrmInHoaDon_Load(object sender, EventArgs e)
        {
            // Đường dẫn RDLC
            string rdlcPath = Path.Combine(Application.StartupPath, "Reports", "HoaDon.rdlc");
            this.rptHoaDon.ProcessingMode = ProcessingMode.Local;
            this.rptHoaDon.LocalReport.ReportPath = rdlcPath;

            // Gán datasource (Tên phải đúng với Dataset Name trong RDLC)
            var rds = new ReportDataSource("InvoiceLineDataSet", _vm.Lines);
            this.rptHoaDon.LocalReport.DataSources.Clear();
            this.rptHoaDon.LocalReport.DataSources.Add(rds);

            // Tham số
            var ps = new ReportParameter[]
            {
                new ReportParameter("pTenCuaHang", "PetShop"),
                new ReportParameter("pDiaChi", "123 Đường 3/2, Q.10, TP.HCM"),
                new ReportParameter("pHotline", "Hotline: 0900 123 456"),
                new ReportParameter("pSoHoaDon", _vm.SoHoaDon.ToString()),
                new ReportParameter("pNgayLap", _vm.NgayLap.ToString("dd/MM/yyyy HH:mm")),
                new ReportParameter("pNhanVien", _vm.NhanVien ?? ""),
                new ReportParameter("pHinhThuc", _vm.HinhThucThanhToan ?? "")
            };

            if (!File.Exists(rdlcPath))
            {
                MessageBox.Show("Không tìm thấy RDLC: " + rdlcPath);
                return;
            }

            this.rptHoaDon.LocalReport.SetParameters(ps);

            this.rptHoaDon.RefreshReport();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {

        }
    }
}
