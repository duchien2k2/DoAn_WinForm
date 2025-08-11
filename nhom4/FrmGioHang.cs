using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using nhom4.Models;
using nhom4.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace nhom4
{
    public partial class FrmGioHang : Form
    {
        private GioHangItem _itemDangChon;

        public FrmGioHang()
        {
            InitializeComponent();
            Load += frmGioHang_Load;

            // Grid events
            gridViewGioHang.RowCellClick += gridViewGioHang_RowCellClick;           // bấm nút Xóa trong lưới
            gridViewGioHang.FocusedRowChanged += gridViewGioHang_FocusedRowChanged; // chọn dòng -> fill panel

            // Repo button (đề phòng trường hợp click từ editor)
            repositoryItemButtonEdit1.ButtonClick += RepositoryItemButtonEdit1_ButtonClick;

            // Panel phải
            if (btnCapNhatSoLuong != null) btnCapNhatSoLuong.Click += btnCapNhatSoLuong_Click;
            if (btnXoaItem != null) btnXoaItem.Click += btnXoaItem_Click;
        }

        private void frmGioHang_Load(object sender, EventArgs e)
        {
            // Demo nếu chưa có dữ liệu ở nơi khác
            if (!GioHangService.DanhSachGioHang.Any())
            {
                GioHangService.ThemVaoGio(new GioHangItem { ID = 1, Ten = "Thức ăn cho chó", Loai = "Sản phẩm", SoLuong = 2, DonGia = 120000 });
                GioHangService.ThemVaoGio(new GioHangItem { ID = 2, Ten = "Tắm gội spa", Loai = "Spa", SoLuong = 1, DonGia = 150000 });
            }

            // Bind
            gridControlGioHang.DataSource = GioHangService.DanhSachGioHang;
            gridControlGioHang.MainView = gridViewGioHang;

            // Lưới: không cho sửa (trừ cột Xóa)
            gridViewGioHang.OptionsBehavior.Editable = false;
            gridViewGioHang.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridViewGioHang.OptionsView.ShowGroupPanel = false;
            gridViewGioHang.OptionsView.ColumnAutoWidth = false;
            gridViewGioHang.OptionsView.ShowFooter = true;

            DinhDangCot();

            // Cột Xóa có nút
            var colXoa = gridViewGioHang.Columns.ColumnByFieldName("Xoa");
            if (colXoa == null)
            {
                colXoa = gridViewGioHang.Columns.AddVisible("Xoa", "Xóa");
                colXoa.UnboundType = DevExpress.Data.UnboundColumnType.Object;
                colXoa.OptionsColumn.FixedWidth = true;
                colXoa.Width = 60;
            }
            repositoryItemButtonEdit1.TextEditStyle = TextEditStyles.HideTextEditor;
            colXoa.ColumnEdit = repositoryItemButtonEdit1;
            colXoa.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            colXoa.OptionsColumn.AllowEdit = true;
            colXoa.OptionsColumn.AllowFocus = false;

            gridViewGioHang.BestFitColumns();

            // Hình thức thanh toán – cho phép chọn
            cbbHinhThucThanhToan.Properties.Items.Clear();
            cbbHinhThucThanhToan.Properties.Items.AddRange(new[] { "Tiền mặt", "Chuyển khoản" });
            if (cbbHinhThucThanhToan.Properties.Items.Count > 0) cbbHinhThucThanhToan.SelectedIndex = 0;

            // Khóa các ô không cho sửa ở panel phải
            KhoaThongTinPanelPhai();

            // Chọn dòng đầu tiên nếu có
            if (gridViewGioHang.DataRowCount > 0)
                gridViewGioHang.FocusedRowHandle = 0;

            CapNhatThongTinTong();
            HienThiChiTiet(gridViewGioHang.GetFocusedRow() as GioHangItem);
        }

        private void DinhDangCot()
        {
            GridColumn colId = gridViewGioHang.Columns.ColumnByFieldName(nameof(GioHangItem.ID)) ?? gridViewGioHang.Columns.AddVisible(nameof(GioHangItem.ID), "Mã");
            colId.Visible = false;

            GridColumn colTen = gridViewGioHang.Columns.ColumnByFieldName(nameof(GioHangItem.Ten)) ?? gridViewGioHang.Columns.AddVisible(nameof(GioHangItem.Ten), "Tên");
            GridColumn colLoai = gridViewGioHang.Columns.ColumnByFieldName(nameof(GioHangItem.Loai)) ?? gridViewGioHang.Columns.AddVisible(nameof(GioHangItem.Loai), "Loại");
            GridColumn colSoLuong = gridViewGioHang.Columns.ColumnByFieldName(nameof(GioHangItem.SoLuong)) ?? gridViewGioHang.Columns.AddVisible(nameof(GioHangItem.SoLuong), "Số lượng");
            GridColumn colDonGia = gridViewGioHang.Columns.ColumnByFieldName(nameof(GioHangItem.DonGia)) ?? gridViewGioHang.Columns.AddVisible(nameof(GioHangItem.DonGia), "Đơn giá");
            GridColumn colThanhTien = gridViewGioHang.Columns.ColumnByFieldName(nameof(GioHangItem.ThanhTien)) ?? gridViewGioHang.Columns.AddVisible(nameof(GioHangItem.ThanhTien), "Thành tiền");

            foreach (var c in new[] { colTen, colLoai, colSoLuong, colDonGia, colThanhTien })
            {
                c.OptionsColumn.AllowEdit = false;
                c.OptionsColumn.ReadOnly = true;
            }

            colDonGia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colDonGia.DisplayFormat.FormatString = "n0";
            colThanhTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colThanhTien.DisplayFormat.FormatString = "n0";
            colThanhTien.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            colThanhTien.SummaryItem.DisplayFormat = "Tổng: {0:n0}";
        }

        private void gridViewGioHang_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column.FieldName != "Xoa") return;
            XoaDongTaiRowHandle(e.RowHandle);
        }

        private void RepositoryItemButtonEdit1_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            var rowHandle = gridViewGioHang.FocusedRowHandle;
            if (rowHandle >= 0) XoaDongTaiRowHandle(rowHandle);
        }

        private void XoaDongTaiRowHandle(int oldHandle)
        {
            var item = gridViewGioHang.GetRow(oldHandle) as GioHangItem;
            if (item == null) return;

            if (!XacNhan($"Xóa \"{item.Ten}\" khỏi giỏ hàng?")) return;

            GioHangService.DanhSachGioHang.Remove(item);
            _itemDangChon = null;

            gridViewGioHang.RefreshData();

            // Chọn dòng kế tiếp hợp lệ
            int newHandle = Math.Min(oldHandle, gridViewGioHang.DataRowCount - 1);
            if (newHandle >= 0)
            {
                gridViewGioHang.FocusedRowHandle = newHandle; // sẽ kích hoạt FocusedRowChanged -> cập nhật panel
            }
            else
            {
                HienThiChiTiet(null); // hết dữ liệu
            }

            CapNhatThongTinTong();
        }

        // Khi đổi dòng chọn trong lưới → cập nhật Panel phải
        private void gridViewGioHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var item = gridViewGioHang.GetRow(e.FocusedRowHandle) as GioHangItem;
            HienThiChiTiet(item);
        }

        private void KhoaThongTinPanelPhai()
        {
            // Các ô chỉ hiển thị
            if (txtTenMatHang != null) { txtTenMatHang.Properties.ReadOnly = true; }
            if (txtLoaiMatHang != null) { txtLoaiMatHang.Properties.ReadOnly = true; }
            if (txtDonGia != null) { txtDonGia.Properties.ReadOnly = true; }
            if (txtThanhTien != null) { txtThanhTien.Properties.ReadOnly = true; }

            // Hình thức thanh toán: cho phép chọn
            if (cbbHinhThucThanhToan != null)
            {
                cbbHinhThucThanhToan.Properties.ReadOnly = false;
                cbbHinhThucThanhToan.Enabled = true;
            }

            // SpinEdit số lượng: cho phép tăng/giảm, đặt Min/Max/Step
            if (spnSoLuong != null)
            {
                spnSoLuong.Properties.IsFloatValue = false;
                spnSoLuong.Properties.MinValue = 1;
                spnSoLuong.Properties.MaxValue = 1_000_000; // đủ lớn để tăng
                spnSoLuong.Properties.Increment = 1;
                spnSoLuong.ReadOnly = false;
                spnSoLuong.Enabled = true;
            }
        }

        private void HienThiChiTiet(GioHangItem item)
        {
            _itemDangChon = item;

            bool isHotel = item != null && string.Equals(item.Loai, "Hotel", StringComparison.OrdinalIgnoreCase);

            if (item == null)
            {
                if (txtTenMatHang != null) txtTenMatHang.Text = string.Empty;
                if (txtLoaiMatHang != null) txtLoaiMatHang.Text = string.Empty;
                if (spnSoLuong != null) spnSoLuong.Value = 0;
                if (txtDonGia != null) txtDonGia.Text = string.Empty;
                if (txtThanhTien != null) txtThanhTien.Text = string.Empty;

                if (btnCapNhatSoLuong != null) btnCapNhatSoLuong.Enabled = false;
                if (btnXoaItem != null) btnXoaItem.Enabled = false;
                return;
            }

            if (txtTenMatHang != null) txtTenMatHang.Text = item.Ten;
            if (txtLoaiMatHang != null) txtLoaiMatHang.Text = item.Loai;
            if (spnSoLuong != null)
            {
                spnSoLuong.Properties.MinValue = 1;
                spnSoLuong.Properties.MaxValue = 1_000_000;
                spnSoLuong.Properties.Increment = 1;
                spnSoLuong.Value = item.SoLuong;
            }
            // SpinEdit số lượng
            if (spnSoLuong != null)
            {
                if (item != null)
                {
                    spnSoLuong.Properties.MinValue = 1;
                    spnSoLuong.Properties.MaxValue = 1_000_000;
                    spnSoLuong.Properties.Increment = 1;
                    spnSoLuong.Value = item.SoLuong;
                }

                // KHÓA nếu là Hotel
                spnSoLuong.Enabled = !isHotel;
                spnSoLuong.ReadOnly = isHotel;
                spnSoLuong.ToolTip = isHotel ? "Dịch vụ giữ thú không cho thay đổi số lượng." : string.Empty;
            }
            if (txtDonGia != null) txtDonGia.Text = item.DonGia.ToString("n0");
            if (txtThanhTien != null) txtThanhTien.Text = item.ThanhTien.ToString("n0");

            if (btnCapNhatSoLuong != null) btnCapNhatSoLuong.Enabled = true;
            if (btnXoaItem != null) btnXoaItem.Enabled = true;
        }

        private void btnXoaItem_Click(object sender, EventArgs e)
        {
            if (_itemDangChon == null) { ThongBao("Vui lòng chọn 1 dòng trong giỏ hàng."); return; }
            int oldHandle = gridViewGioHang.FocusedRowHandle;
            XoaDongTaiRowHandle(oldHandle);
        }

        private void btnCapNhatSoLuong_Click(object sender, EventArgs e)
        {
            if (_itemDangChon == null) { ThongBao("Vui lòng chọn 1 dòng trong giỏ hàng."); return; }
            if (spnSoLuong == null) { ThongBao("Thiếu control spnSoLuong."); return; }

            int slMoi = (int)spnSoLuong.Value;
            if (slMoi < 1) { ThongBao("Số lượng phải ≥ 1."); return; }

            // Cập nhật số lượng
            bool ok = GioHangService.CapNhatSoLuong(_itemDangChon.ID, _itemDangChon.Loai, slMoi);
            if (!ok) { ThongBao("Cập nhật số lượng thất bại."); return; }

            // Làm tươi hiển thị
            gridViewGioHang.RefreshData();

            // Lấy lại item theo ID/Loại để hiển thị đúng thành tiền
            var item = GioHangService.LayItem(_itemDangChon.ID, _itemDangChon.Loai);
            HienThiChiTiet(item);

            CapNhatThongTinTong();
        }

        private void btnXoaGioHang_Click(object sender, EventArgs e)
        {
            if (!GioHangService.DanhSachGioHang.Any()) { ThongBao("Giỏ hàng đang trống."); return; }
            if (!XacNhan("Bạn có chắc muốn xóa toàn bộ giỏ hàng không?")) return;

            GioHangService.XoaGioHang();
            _itemDangChon = null;

            gridViewGioHang.RefreshData();
            HienThiChiTiet(null);
            CapNhatThongTinTong();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                // 1) Kiểm tra giỏ hàng
                if (nhom4.Services.GioHangService.DanhSachGioHang.Count == 0)
                {
                    MessageBox.Show("Giỏ hàng đang trống.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 2) Lập hóa đơn
                var svc = new nhom4.Services.HoaDonService();
                int userId = AppSession.CurrentUser.ID_User;
                string hinhThuc = cbbHinhThucThanhToan.Text?.Trim();

                int hoaDonId = svc.LapHoaDonFromGioHang(userId, hinhThuc);

                // 3) Build dữ liệu RDLC và mở form in
                var vm = svc.BuildReportData(hoaDonId);
                using (var f = new FrmInHoaDon(vm))
                    f.ShowDialog();

                // 4) Dọn UI giỏ hàng
                gridControlGioHang.RefreshDataSource();
                gridViewGioHang.RefreshData();
                HienThiChiTiet(null);
                CapNhatThongTinTong();

                MessageBox.Show(this, "Thanh toán thành công. Giỏ hàng đã được xóa.",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Thanh toán thất bại: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CapNhatThongTinTong()
        {
            lblSoLuongMatHang.Text = $"Tổng mục hàng: {GioHangService.DanhSachGioHang.Count}";
        }

        private void ThongBao(string msg) => XtraMessageBox.Show(this, msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        private bool XacNhan(string msg) => XtraMessageBox.Show(this, msg, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
    }
}
