using nhom4.Models;
using nhom4.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace nhom4
{
    public partial class FrmSanPham : Form
    {
        private readonly SanPhamService service = new SanPhamService();
        private List<SanPham> danhSachSanPham = new List<SanPham>();

        // Định nghĩa enum trạng thái hoạt động
        private enum FormMode { None, Add, Edit, Delete }
        private FormMode currentMode = FormMode.None;


        public FrmSanPham()
        {
            InitializeComponent();
        }

        /// Xử lý sự kiện form được tải lần đầu
        private void frmsanpham_Load(object sender, EventArgs e)
        {
            LoadDanhMuc();
            LoadTatCaSanPham();
            CbbDanhmuc.SelectedIndexChanged += CbbDanhmuc_SelectedIndexChanged;

            BtnAdd.ItemClick += BtnAdd_ItemClick;
            BtnUpdate.ItemClick += BtnUpdate_ItemClick;
            BtnDelete.ItemClick += BtnDelete_ItemClick;
            BtnSave.ItemClick += BtnSave_ItemClick;
            BtnCancel.ItemClick += BtnCancel_ItemClick;

            SetControlState(); // Khởi đầu: tất cả đều khóa
        }

        /// Tải danh sách danh mục sản phẩm vào ComboBox
        /// Thêm một lựa chọn mặc định "-- Chọn danh mục --" vào đầu danh sách
        private void LoadDanhMuc()
        {
            var danhMucs = service.LayTatCaDanhMuc();
            danhMucs.Insert(0, new DanhMucSanPham { ID_LoaiSP = -1, TenLoai = "-- Chọn danh mục --" });

            CbbDanhmuc.DataSource = danhMucs;
            CbbDanhmuc.DisplayMember = "TenLoai";
            CbbDanhmuc.ValueMember = "ID_LoaiSP";
        }

        /// Tải và hiển thị tất cả sản phẩm lên DataGridView
        private void LoadTatCaSanPham()
        {
            danhSachSanPham = service.LayTatCaSanPham();

            // Chuyển đổi dữ liệu để hiển thị trên DataGridView
            Dgvsanpham.DataSource = danhSachSanPham.Select(sp => new
            {
                sp.ID_SanPham,
                sp.TenSanPham,
                sp.DonGia,
                sp.SoLuongTonKho,
                sp.MoTa,
                TenLoai = sp.DanhMucSanPham?.TenLoai
            }).ToList();

            SetDataGridHeaders();
        }

        /// Xử lý sự kiện khi người dùng chọn danh mục từ ComboBox
        /// Lọc và hiển thị sản phẩm theo danh mục được chọn
        private void CbbDanhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbbDanhmuc.SelectedValue is int id && id != -1)
            {
                danhSachSanPham = service.LaySanPhamTheoDanhMuc(id);

                // Cập nhật DataGridView với danh sách sản phẩm đã lọc
                Dgvsanpham.DataSource = danhSachSanPham.Select(sp => new
                {
                    sp.ID_SanPham,
                    sp.TenSanPham,
                    sp.DonGia,
                    sp.SoLuongTonKho,
                    sp.MoTa,
                    TenLoai = sp.DanhMucSanPham?.TenLoai
                }).ToList();

                SetDataGridHeaders();
            }
        }

        /// Xử lý sự kiện khi người dùng click vào một ô trong DataGridView
        /// Hiển thị thông tin chi tiết sản phẩm được chọn lên các control
        private void Dgvsanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var id = Convert.ToInt32(Dgvsanpham.Rows[e.RowIndex].Cells["ID_SanPham"].Value);
                var sp = danhSachSanPham.FirstOrDefault(x => x.ID_SanPham == id);
                if (sp != null)
                {
                    // Điền thông tin sản phẩm vào các control
                    TxtTenSanPham.Text = sp.TenSanPham;
                    TxtGia.Text = sp.DonGia.ToString("N0");
                    TxtSoLuong.Text = sp.SoLuongTonKho?.ToString();
                    TxtMoTa.Text = sp.MoTa;
                    CbbDanhmuc.SelectedValue = sp.IDLoaiSP;
                }
            }
        }

        /// Thiết lập tiêu đề cho các cột trong DataGridView
        private void SetDataGridHeaders()
        {
            Dgvsanpham.Columns["ID_SanPham"].HeaderText = "Mã SP";
            Dgvsanpham.Columns["TenSanPham"].HeaderText = "Tên sản phẩm";
            Dgvsanpham.Columns["DonGia"].HeaderText = "Đơn giá";
            Dgvsanpham.Columns["SoLuongTonKho"].HeaderText = "Số lượng tồn kho";
            Dgvsanpham.Columns["MoTa"].HeaderText = "Mô tả";
            Dgvsanpham.Columns["TenLoai"].HeaderText = "Loại sản phẩm";
        }

        /// Thiết lập trạng thái các control dựa trên chế độ hiện tại (Thêm, Sửa, Xóa)
        private void SetControlState()
        {
            bool isEditing = currentMode == FormMode.Add || currentMode == FormMode.Edit;
            bool isDeleting = currentMode == FormMode.Delete;
            bool isBusy = isEditing || isDeleting;

            // Bật/tắt nhập liệu
            TxtTenSanPham.Enabled = isEditing;
            TxtGia.Enabled = isEditing;
            TxtSoLuong.Enabled = isEditing;
            TxtMoTa.Enabled = isEditing;
            CbbDanhmuc.Enabled = isEditing;

            // Chức năng Lưu/Hủy (ribbon group xử lý)
            BtnSave.Enabled = isBusy;
            BtnCancel.Enabled = isBusy;

            // Ribbon chức năng chính (hiện mờ khi đang xử lý)
            BtnAdd.Enabled = !isBusy;
            BtnUpdate.Enabled = !isBusy;
            BtnDelete.Enabled = !isBusy;
        }

        /// Xóa nội dung các control nhập liệu
        private void ClearInputs()
        {
            TxtTenSanPham.Text = "";
            TxtGia.Text = "";
            TxtSoLuong.Text = "";
            TxtMoTa.Text = "";
            CbbDanhmuc.SelectedIndex = 0;
        }


        private void BtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            currentMode = FormMode.Add;
            ClearInputs();
            SetControlState();
        }

        private void BtnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Dgvsanpham.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để sửa.");
                return;
            }

            currentMode = FormMode.Edit;
            SetControlState();
        }

        private void BtnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Dgvsanpham.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa.");
                return;
            }

            currentMode = FormMode.Delete;
            SetControlState();
        }

        private void BtnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ClearInputs();
            currentMode = FormMode.None;
            SetControlState();
        }

        private void BtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (currentMode == FormMode.Add)
                {
                    var sp = new SanPham
                    {
                        TenSanPham = TxtTenSanPham.Text,
                        DonGia = decimal.Parse(TxtGia.Text),
                        SoLuongTonKho = int.Parse(TxtSoLuong.Text),
                        MoTa = TxtMoTa.Text,
                        IDLoaiSP = (int)CbbDanhmuc.SelectedValue
                    };
                    service.ThemSanPham(sp);
                    MessageBox.Show("Đã thêm sản phẩm.");
                }
                else if (currentMode == FormMode.Edit)
                {
                    int id = Convert.ToInt32(Dgvsanpham.CurrentRow.Cells["ID_SanPham"].Value);
                    var sp = service.LaySanPhamTheoId(id); // đây là truy từ DB

                    if (sp != null)
                    {
                        sp.TenSanPham = TxtTenSanPham.Text;
                        sp.DonGia = decimal.Parse(TxtGia.Text);
                        sp.SoLuongTonKho = int.Parse(TxtSoLuong.Text);
                        sp.MoTa = TxtMoTa.Text;
                        sp.IDLoaiSP = (int)CbbDanhmuc.SelectedValue;

                        service.CapNhatSanPham(sp);
                    }
                    MessageBox.Show("Đã cập nhật sản phẩm.");
                }
                else if (currentMode == FormMode.Delete)
                {
                    int id = Convert.ToInt32(Dgvsanpham.CurrentRow.Cells["ID_SanPham"].Value);
                    var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        service.XoaSanPham(id);
                        MessageBox.Show("Đã xóa sản phẩm.");
                    }
                }

                LoadTatCaSanPham();
                ClearInputs();
                currentMode = FormMode.None;
                SetControlState();
            }
            catch (Exception ex)
            {
                string message = ex.InnerException?.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Lỗi: " + message);
            }
        }

        private void BtnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnThemGioHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Dgvsanpham.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm.");
                return;
            }

            int id = Convert.ToInt32(Dgvsanpham.CurrentRow.Cells["ID_SanPham"].Value);
            var sp = danhSachSanPham.FirstOrDefault(x => x.ID_SanPham == id);
            if (sp == null)
            {
                MessageBox.Show("Không tìm thấy sản phẩm.");
                return;
            }

            // Số lượng mua: mặc định 1. (Nếu bạn có ô nhập riêng thì lấy từ đó)
            int soLuongMua = 1;

            GioHangService.ThemVaoGio(new GioHangItem
            {
                ID = sp.ID_SanPham,
                Ten = sp.TenSanPham,
                Loai = "Sản phẩm",
                SoLuong = soLuongMua,
                DonGia = sp.DonGia
            });

            MessageBox.Show("Đã thêm vào giỏ.");
        }
    }
}
