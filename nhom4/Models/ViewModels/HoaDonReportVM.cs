using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nhom4.Models.ViewModels
{
    public class HoaDonReportVM
    {
        public int SoHoaDon { get; set; }
        public DateTime NgayLap { get; set; }
        public string NhanVien { get; set; }
        public string HinhThucThanhToan { get; set; }
        public List<InvoiceLineVM> Lines { get; set; } = new List<InvoiceLineVM>();
        public decimal TongTien => Lines.Sum(x => x.ThanhTien);
    }
}
