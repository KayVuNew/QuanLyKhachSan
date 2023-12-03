using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }
        Nhom3_Duan1_QuanLiKhachSanEntities QLKS = new Nhom3_Duan1_QuanLiKhachSanEntities();
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaiKhoan.Text) ||
                string.IsNullOrWhiteSpace(txtMatKhauCu.Text) ||
                string.IsNullOrWhiteSpace(txtMatKhauMoi2.Text) ||
                string.IsNullOrWhiteSpace(txtMatKhauMoi1.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var nhanVien = QLKS.NhanViens.FirstOrDefault(a => a.TenTK == txtTaiKhoan.Text && a.Matkhau == txtMatKhauCu.Text);
                if (nhanVien != null)
                {
                    if (txtMatKhauMoi1.Text != txtMatKhauMoi2.Text)
                    {
                        MessageBox.Show("Mật khẩu nhập lại không khớp!");
                    }
                    else
                    {
                        nhanVien.Matkhau = txtMatKhauMoi1.Text;
                        QLKS.SaveChanges(); // Lưu các thay đổi vào cơ sở dữ liệu
                        MessageBox.Show("Đổi mật khẩu thành công!");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu hoặc tài khoản không chính xác!");
                }
            }
        }
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            FrmTranglogin login = new FrmTranglogin();
            login.Show();
            this.Hide();
        }
    }
}
