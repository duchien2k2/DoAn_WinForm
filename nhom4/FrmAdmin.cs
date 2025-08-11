using nhom4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nhom4
{
    public partial class FrmAdmin : Form
    {
        private int selectedUserId;

        public FrmAdmin()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_Admin_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false; // << BẮT BUỘC PHẢI CÓ
            btn_Delete.Enabled = false;
            btn_Update.Enabled = false;
            comboBox_TrangThai.Items.Clear();
            comboBox_TrangThai.Items.Add("Mở");   // Tương đương true
            comboBox_TrangThai.Items.Add("Đóng"); // Tương đương false


            btn_Add.Enabled = true;
            btn_LockUser.Enabled = true;
            using (var context = new PetShopContextDB())
            {
                var nhanViens = context.Users.Select(u => new
                {
                    MaNV = u.ID_User,
                    HoTen = u.HoVaTen,
                    SDT = u.SoDienThoai,
                    VaiTro = u.VaiTro,
                    TenDangNhap = u.TenDangNhap,
                    TrangThai = u.TrangThai == true ? "Mở" : "Đóng",
                    
                }).ToList();


                dataGridView1.Rows.Clear(); // dgvNhanVien là tên DataGridView
                foreach (var nv in nhanViens)
                {
                    dataGridView1.Rows.Add(nv.MaNV, nv.HoTen, nv.SDT, nv.VaiTro, nv.TrangThai, nv.TenDangNhap);
                }
            }

        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Đảm bảo không click vào header hoặc hàng trống
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txt_HoVaTen.Text = row.Cells["colHoTen"].Value?.ToString();
                txt_SDT.Text = row.Cells["colSDT"].Value?.ToString();
                comboBox_VaiTro.SelectedItem = row.Cells["colVaiTro"].Value?.ToString();
                txt_TenDangNhap.Text = row.Cells["colTenDangNhap"].Value?.ToString();
                comboBox_TrangThai.SelectedItem = row.Cells["colTrangThai"].Value?.ToString();
                

                // Nếu bạn cần Mã NV để xử lý thì có thể lưu vào biến riêng:
                selectedUserId = Convert.ToInt32(row.Cells["colMaNV"].Value);
                btn_Delete.Enabled = true;
                btn_Update.Enabled = true;
                
            }
        }


        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (selectedUserId <= 0)
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hoVaTen = txt_HoVaTen.Text.Trim();
            string soDienThoai = txt_SDT.Text.Trim();
            string vaiTro = comboBox_VaiTro.SelectedItem?.ToString();
            string tenDangNhap = txt_TenDangNhap.Text.Trim();
            string trangThaiText = comboBox_TrangThai.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(hoVaTen) || string.IsNullOrWhiteSpace(soDienThoai) ||
                string.IsNullOrWhiteSpace(vaiTro) || string.IsNullOrWhiteSpace(trangThaiText))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var context = new PetShopContextDB())
                {
                    var user = context.Users.FirstOrDefault(u => u.ID_User == selectedUserId);
                    if (user == null)
                    {
                        MessageBox.Show("Không tìm thấy nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Kiểm tra trùng tên đăng nhập (nếu sửa đổi)
                    var trungTenDangNhap = context.Users
                        .FirstOrDefault(u => u.TenDangNhap == tenDangNhap && u.ID_User != selectedUserId);
                    if (trungTenDangNhap != null)
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Cập nhật thông tin
                    user.HoVaTen = hoVaTen;
                    user.SoDienThoai = soDienThoai;
                    user.VaiTro = vaiTro;
                    user.TenDangNhap = tenDangNhap;
                    user.TrangThai = trangThaiText == "Mở";

                    context.SaveChanges();

                    MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form_Admin_Load(null, null); // Refresh lại danh sách

                    // Reset form
                    txt_HoVaTen.Text = "";
                    txt_SDT.Text = "";
                    comboBox_VaiTro.SelectedIndex = -1;
                    txt_TenDangNhap.Text = "";
                    comboBox_TrangThai.SelectedIndex = -1;
                    selectedUserId = -1;
                    ResetButtons();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txt_HoVaTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_SDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_VaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_TrangThai_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form Admin
        }


        private void btn_Add_Click(object sender, EventArgs e)
        {
            string hoVaTen = txt_HoVaTen.Text.Trim();
            string soDienThoai = txt_SDT.Text.Trim();
            string vaiTro = comboBox_VaiTro.SelectedItem?.ToString();
            string tenDangNhap = txt_TenDangNhap.Text.Trim();
            string trangThaiText = comboBox_TrangThai.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(hoVaTen) || string.IsNullOrWhiteSpace(soDienThoai) ||
                string.IsNullOrWhiteSpace(vaiTro) || string.IsNullOrWhiteSpace(trangThaiText))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new PetShopContextDB())
            {
                // Kiểm tra trùng: họ tên + số điện thoại
                var existingUser = context.Users.FirstOrDefault(u =>
    u.HoVaTen == hoVaTen || u.SoDienThoai == soDienThoai);

                if (existingUser != null)
                {
                    if (existingUser.HoVaTen == hoVaTen && existingUser.SoDienThoai == soDienThoai)
                    {
                        MessageBox.Show("Nhân viên này đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (existingUser.SoDienThoai == soDienThoai)
                    {
                        MessageBox.Show("Số điện thoại đã được sử dụng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return;
                }



                try
                {
                    User newUser = new User
                    {
                        HoVaTen = hoVaTen,
                        SoDienThoai = soDienThoai,
                        VaiTro = vaiTro,
                        TenDangNhap = tenDangNhap,
                        TrangThai = trangThaiText == "Mở", // "Mở" = true, "Đóng" = false
                        MatKhau = "123456"
                    };
                    var duplicateLogin = context.Users.FirstOrDefault(u => u.TenDangNhap == tenDangNhap);
                    if (duplicateLogin != null)
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    context.Users.Add(newUser);
                    context.SaveChanges();

                    MessageBox.Show("Thêm nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh lại
                    Form_Admin_Load(null, null);

                    // Reset form
                    txt_HoVaTen.Text = "";
                    txt_SDT.Text = "";
                    comboBox_VaiTro.SelectedIndex = -1;
                    txt_TenDangNhap.Text = "";

                    comboBox_TrangThai.SelectedIndex = -1;

                    ResetButtons();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (selectedUserId <= 0)
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            try
            {
                using (var context = new PetShopContextDB())
                {
                    var userToDelete = context.Users.FirstOrDefault(u => u.ID_User == selectedUserId);
                    if (userToDelete == null)
                    {
                        MessageBox.Show("Không tìm thấy nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    context.Users.Remove(userToDelete);
                    context.SaveChanges();

                    MessageBox.Show("Xóa nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh lại danh sách
                    Form_Admin_Load(null, null);

                    // Reset form và nút
                    txt_HoVaTen.Text = "";
                    txt_SDT.Text = "";
                    comboBox_VaiTro.SelectedIndex = -1;
                    txt_TenDangNhap.Text = "";
                    comboBox_TrangThai.SelectedIndex = -1;
                    selectedUserId = -1;
                    ResetButtons();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_LockUser_Click(object sender, EventArgs e)
{
    if (selectedUserId <= 0)
    {
        MessageBox.Show("Vui lòng chọn một nhân viên để khóa/mở!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }

    try
    {
        using (var context = new PetShopContextDB())
        {
            var user = context.Users.FirstOrDefault(u => u.ID_User == selectedUserId);
            if (user == null)
            {
                MessageBox.Show("Không tìm thấy nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

                    // Đảo trạng thái
                    user.TrangThai = !(user.TrangThai ?? false);

                    context.SaveChanges();

                    string trangThaiMoi = (user.TrangThai ?? false) ? "Mở" : "Đóng";
                    MessageBox.Show($"Đã cập nhật trạng thái nhân viên thành: {trangThaiMoi}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Làm mới lại danh sách
            Form_Admin_Load(null, null);

            // Reset form
            txt_HoVaTen.Text = "";
            txt_SDT.Text = "";
            comboBox_VaiTro.SelectedIndex = -1;
            txt_TenDangNhap.Text = "";
            comboBox_TrangThai.SelectedIndex = -1;
            selectedUserId = -1;
            ResetButtons();
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Lỗi khi cập nhật trạng thái: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}

        private void ResetButtons()
        {
            btn_Add.Enabled = true;
            btn_LockUser.Enabled = true;

            btn_Delete.Enabled = false;
            btn_Update.Enabled = false;
        }

        private void comboBox_TrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_TenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
