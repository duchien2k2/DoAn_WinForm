using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nhom4.Models.ViewModels
{
    public class InvoiceLineVM
    {
        public int STT { get; set; }
        public string Loai { get; set; }      // "Sản phẩm" | "DV Spa" | "Gửi thú"
        public string Ten { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien => SoLuong * DonGia;
    }
}
