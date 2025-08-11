using DevExpress.XtraBars;
using nhom4.Models;
using nhom4.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace nhom4
{
    public partial class FrmSpa : Form
    {
        private readonly DichVuSpaService spaService = new DichVuSpaService();
        private List<DichVuSpa> danhSachDichVu = new List<DichVuSpa>();

        private enum FormMode { None, Add, Edit, Delete }
        private FormMode currentMode = FormMode.None;

        public FrmSpa()
        {
            InitializeComponent();
        }

        private void FrmSpa_Load(object sender, EventArgs e)
        {
            LoadDanhMuc();
            LoadTatCaDichVu();
            CbbDanhmuc.SelectedIndexChanged += CbbDanhmuc_SelectedIndexChanged;

            Dgvsanpham.CellClick += Dgvsanpham_CellClick;

            SetControlState();
        }

        private void LoadDanhMuc()
        {
            using (var db = new PetShopContextDB())
            {
                var list = db.DanhMucDichVus.ToList();
                list.Insert(0, new DanhMucDichVu { ID_LoaiDV = -1, TenLoai = "-- Chọn loại dịch vụ --" });
                CbbDanhmuc.DataSource = list;
                CbbDanhmuc.DisplayMember = "TenLoai";
                CbbDanhmuc.ValueMember = "ID_LoaiDV";
            }
        }

        private void LoadTatCaDichVu()
        {
            danhSachDichVu = spaService.LayTatCa();
            Dgvsanpham.DataSource = danhSachDichVu.Select(dv => new
            {
                dv.ID_DichVu,
                dv.TenDichVu,
                dv.Gia,
                dv.MoTa,
                TenLoai = dv.DanhMucDichVu?.TenLoai
            }).ToList();
            SetDataGridHeaders();
        }

        private void SetDataGridHeaders()
        {
            Dgvsanpham.Columns["ID_DichVu"].HeaderText = "Mã DV";
            Dgvsanpham.Columns["TenDichVu"].HeaderText = "Tên dịch vụ";
            Dgvsanpham.Columns["Gia"].HeaderText = "Giá";
            Dgvsanpham.Columns["MoTa"].HeaderText = "Mô tả";
            Dgvsanpham.Columns["TenLoai"].HeaderText = "Loại dịch vụ";
        }

        private void CbbDanhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbbDanhmuc.SelectedValue is int id && id != -1)
            {
                var dsLoc = danhSachDichVu.Where(x => x.IDLoaiDV == id).ToList();
                Dgvsanpham.DataSource = dsLoc.Select(dv => new
                {
                    dv.ID_DichVu,
                    dv.TenDichVu,
                    dv.Gia,
                    dv.MoTa,
                    TenLoai = dv.DanhMucDichVu?.TenLoai
                }).ToList();
                SetDataGridHeaders();
            }
        }

        private void Dgvsanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(Dgvsanpham.Rows[e.RowIndex].Cells["ID_DichVu"].Value);
                var dv = spaService.LayTheoId(id);
                if (dv != null)
                {
                    TxtTenSanPham.Text = dv.TenDichVu;
                    TxtGia.Text = dv.Gia.ToString("0");
                    TxtMoTa.Text = dv.MoTa;
                    CbbDanhmuc.SelectedValue = dv.IDLoaiDV;
                }
            }
        }

        private void BtnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            currentMode = FormMode.Add;
            ClearInputs();
            SetControlState();
        }

        private void BtnUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Dgvsanpham.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ để sửa.");
                return;
            }

            currentMode = FormMode.Edit;
            SetControlState();
        }

        private void BtnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Dgvsanpham.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ để xóa.");
                return;
            }

            currentMode = FormMode.Delete;
            SetControlState();
        }

        private void BtnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtTenSanPham.Text) ||
                    string.IsNullOrWhiteSpace(TxtGia.Text) ||
                    CbbDanhmuc.SelectedIndex <= 0)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                    return;
                }

                if (!decimal.TryParse(TxtGia.Text, out decimal gia))
                {
                    MessageBox.Show("Giá không hợp lệ.");
                    return;
                }

                if (currentMode == FormMode.Add)
                {
                    var newDV = new DichVuSpa
                    {
                        TenDichVu = TxtTenSanPham.Text,
                        Gia = gia,
                        MoTa = TxtMoTa.Text,
                        IDLoaiDV = (int)CbbDanhmuc.SelectedValue
                    };
                    spaService.Them(newDV);
                    MessageBox.Show("Đã thêm dịch vụ.");
                }
                else if (currentMode == FormMode.Edit)
                {
                    int id = Convert.ToInt32(Dgvsanpham.CurrentRow.Cells["ID_DichVu"].Value);
                    var dv = spaService.LayTheoId(id);
                    if (dv != null)
                    {
                        dv.TenDichVu = TxtTenSanPham.Text;
                        dv.Gia = gia;
                        dv.MoTa = TxtMoTa.Text;
                        dv.IDLoaiDV = (int)CbbDanhmuc.SelectedValue;
                        spaService.CapNhat(dv);
                        MessageBox.Show("Đã cập nhật.");
                    }
                }
                else if (currentMode == FormMode.Delete)
                {
                    int id = Convert.ToInt32(Dgvsanpham.CurrentRow.Cells["ID_DichVu"].Value);
                    var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa dịch vụ này?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        spaService.Xoa(id);
                        MessageBox.Show("Đã xóa dịch vụ.");
                    }
                }

                LoadTatCaDichVu();
                ClearInputs();
                currentMode = FormMode.None;
                SetControlState();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + (ex.InnerException?.Message ?? ex.Message));
            }
        }

        private void BtnCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClearInputs();
            currentMode = FormMode.None;
            SetControlState();
        }

        private void BtnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void SetControlState()
        {
            bool isEditing = currentMode == FormMode.Add || currentMode == FormMode.Edit;
            bool isDeleting = currentMode == FormMode.Delete;
            bool isBusy = isEditing || isDeleting;

            TxtTenSanPham.Enabled = isEditing;
            TxtGia.Enabled = isEditing;
            TxtMoTa.Enabled = isEditing;
            CbbDanhmuc.Enabled = isEditing;

            BtnSave.Enabled = isBusy;
            BtnCancel.Enabled = isBusy;

            BtnAdd.Enabled = !isBusy;
            BtnUpdate.Enabled = !isBusy;
            BtnDelete.Enabled = !isBusy;
        }

        private void ClearInputs()
        {
            TxtTenSanPham.Clear();
            TxtGia.Clear();
            TxtMoTa.Clear();
            CbbDanhmuc.SelectedIndex = 0;
        }

        private void btnThemGioHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Dgvsanpham.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ spa.");
                return;
            }

            int id = Convert.ToInt32(Dgvsanpham.CurrentRow.Cells["ID_DichVu"].Value);
            var dv = danhSachDichVu.FirstOrDefault(x => x.ID_DichVu == id);
            if (dv == null)
            {
                MessageBox.Show("Không tìm thấy dịch vụ.");
                return;
            }

            GioHangService.ThemVaoGio(new GioHangItem
            {
                ID = dv.ID_DichVu,
                Ten = dv.TenDichVu,
                Loai = "Spa",
                SoLuong = 1,           // thường = 1
                DonGia = dv.Gia
            });

            MessageBox.Show("Đã thêm dịch vụ vào giỏ.");
        }
    }
}
