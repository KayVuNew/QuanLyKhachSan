using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var nhanVien = QLKS.NhanViens.FirstOrDefault(a => a.TenTK == txtTaiKhoan.Text);
                if (nhanVien != null && nhanVien.Matkhau == encryption(txtMatKhauCu.Text))
                {
                    if (txtMatKhauMoi1.Text != txtMatKhauMoi2.Text)
                    {
                        MessageBox.Show("Mật khẩu nhập lại không khớp!");
                    }
                    else
                    {
                        nhanVien.Matkhau = encryption(txtMatKhauMoi1.Text);
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
        public string encryption(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder encryptdata = new StringBuilder();
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();
        }
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            FrmTranglogin login = new FrmTranglogin();
            login.Show();
            this.Hide();
        }
    }
}
