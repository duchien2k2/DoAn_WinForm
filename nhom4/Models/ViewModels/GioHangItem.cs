using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nhom4.Models
{
    public class GioHangItem
    {
        // Tên sản phẩm/dịch vụ
        public string Ten { get; set; }

        // Loại mặt hàng: "Sản phẩm", "Spa", "Hotel"
        public string Loai { get; set; }

        // ID của sản phẩm/dịch vụ
        public int ID { get; set; }

        // Số lượng đặt mua/đặt dịch vụ
        public int SoLuong { get; set; }

        // Đơn giá của từng sản phẩm/dịch vụ
        public decimal DonGia { get; set; }

        // Thành tiền = Số lượng * Đơn giá
        public decimal ThanhTien => SoLuong * DonGia;
    }
}
