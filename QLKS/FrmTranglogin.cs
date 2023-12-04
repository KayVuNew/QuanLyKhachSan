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
    public partial class FrmTranglogin : Form
    {
        public FrmTranglogin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        Nhom3_Duan1_QuanLiKhachSanEntities QLKS = new Nhom3_Duan1_QuanLiKhachSanEntities();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtTaiKhoan.Text;
                string password = encryption(txtMatKhau.Text);

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Username và Password không được để trống", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var employee = QLKS.NhanViens.FirstOrDefault(nv => nv.TenTK == username && nv.Matkhau == password);

                if (employee != null)
                {
                    // Redirect to different menus based on employee role
                    if (employee.Quyen == "Lễ Tân")
                    {
                        MenuLeTan menult = new MenuLeTan();
                        menult.Show();
                        
                    }
                    else if (employee.Quyen == "Kế Toán")
                    {
                        MenuKeToan menukt = new MenuKeToan();
                        menukt.Show();
                    }
                    else if (employee.Quyen == "admin")
                    {
                        Menuadmin menuad = new Menuadmin();
                        menuad.Show();
                    }
                    this.Hide(); // Hide the login form after successful login
                    MessageBox.Show("Đăng nhập thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Log the exception for debugging purposes

                MessageBox.Show("Đã xảy ra lỗi trong quá trình đăng nhập. Vui lòng thử lại sau.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void lklDoiMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DoiMatKhau dmk = new DoiMatKhau();
            dmk.Show();
            this.Hide();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
