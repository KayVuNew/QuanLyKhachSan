using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace QLKS
{
    public partial class QLNV : Form
    {
        public QLNV()
        {
            InitializeComponent();
        }
        Nhom3_Duan1_QuanLiKhachSanEntities QLKS = new Nhom3_Duan1_QuanLiKhachSanEntities();
        private int rowIndex;
        void LoadNV()
        {
            var query = from nv in QLKS.NhanViens
                        select new
                        {
                            MaNV = nv.MaNV,
                            Hoten = nv.HoTen,
                            TaiKhoan = nv.TenTK,
                            Quyen = nv.Quyen,
                            NgSinh = nv.Ngaysinh,
                            MatKhau = "*******",
                        };
            dvNhanVien.DataSource = query.ToList();
            dvNhanVien.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dvNhanVien.Columns["TaiKhoan"].HeaderText = "Tài khoản";
            dvNhanVien.Columns["Hoten"].HeaderText = "Họ tên";
            dvNhanVien.Columns["Quyen"].HeaderText = "Quyền";
            dvNhanVien.Columns["NgSinh"].HeaderText = "Ngày sinh";
            dvNhanVien.Columns["MatKhau"].HeaderText = "Mật khẩu";
        }
        private void btthem_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Random random = new Random();
                string MaNV = "NV" + random.Next(100, 999).ToString();

                // Check if the generated MaHD already exists
                while (QLKS.HoaDons.Any(hd => hd.MaHoaDon == MaNV))
                {
                    MaNV = "NV" + random.Next(100, 999).ToString();
                }
                NhanVien st = new NhanVien();
                st.MaNV = MaNV;
                st.TenTK = txtTaiKhoan.Text;
                st.Matkhau = encryption(txtMatKhau.Text);
                st.Quyen = cboQuyen.Text;
                st.Ngaysinh = DateTime.ParseExact(dtpNgSinh.Text, "dd/MM/yyyy", CultureInfo.CurrentCulture);
                st.HoTen = txtHoTen.Text;

                using (var context = new Nhom3_Duan1_QuanLiKhachSanEntities())
                {
                    context.NhanViens.Add(st);

                    // Validate the entity before saving
                    var validationResults = context.GetValidationErrors();
                    if (validationResults.Any())
                    {
                        // Handle validation errors, log them, or display error messages
                        foreach (var validationResult in validationResults)
                        {
                            foreach (var error in validationResult.ValidationErrors)
                            {
                                Console.WriteLine($"Validation Error: {error.ErrorMessage}, Property: {error.PropertyName}");
                                // Handle the error as per your application's requirements
                            }
                        }
                    }
                    else
                    {
                        context.SaveChanges();  // Save the changes to the database
                        LoadNV();
                        MessageBox.Show("Thêm thành công", "OK", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void QLNV_Load(object sender, EventArgs e)
        {
            LoadNV();
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
        private void btsua_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                string maNV = dvNhanVien.SelectedCells[0].OwningRow.Cells["MaNV"].Value.ToString();
                NhanVien st = QLKS.NhanViens.FirstOrDefault(nv => nv.MaNV == maNV);
                if (st != null)
                {
                    string tenTK = txtTaiKhoan.Text;
                    string quyen = cboQuyen.Text;
                    DateTime NgSinh = DateTime.ParseExact(dtpNgSinh.Text, "dd/MM/yyyy", CultureInfo.CurrentCulture);
                    string HoTen = txtHoTen.Text;
                    st.TenTK = tenTK;
                    string matKhau = encryption(txtMatKhau.Text);
                    if (matKhau != "*******")
                    {
                        st.Matkhau = matKhau;
                    }
                    st.Ngaysinh = NgSinh;
                    st.HoTen = HoTen;
                    st.Quyen = quyen;
                    QLKS.SaveChanges();
                    LoadNV();
                    MessageBox.Show("Cập nhật thành công", "OK", MessageBoxButtons.OK);
                }
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string maNV = dvNhanVien.SelectedCells[0].OwningRow.Cells["MaNV"].Value.ToString();

                NhanVien st = QLKS.NhanViens.FirstOrDefault(nv => nv.MaNV == maNV);

                if (st != null)
                {
                    QLKS.NhanViens.Remove(st);
                    int ketQua = QLKS.SaveChanges();

                    if (ketQua > 0)
                    {
                        MessageBox.Show("Xóa thành công", "OK", MessageBoxButtons.OK);
                        LoadNV();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại", "OK", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên để xóa", "OK", MessageBoxButtons.OK);
                }
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(txtTaiKhoan.Text) ||
                string.IsNullOrWhiteSpace(txtMatKhau.Text) ||
                string.IsNullOrWhiteSpace(cboQuyen.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //if (!Regex.IsMatch(txtMatKhau.Text, "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^a-zA-Z\\d\\s]).{8,}$"))
            //{
            //    MessageBox.Show("Mật khẩu phải chứa ít nhất một chữ in hoa, một chữ in thường, một ký tự đặc biệt và một số, và ít nhất 8 ký tự!");
            //    return false;
            //}
            DateTime ngaySinh = dtpNgSinh.Value;
            int tuoi = DateTime.Today.Year - ngaySinh.Year;
            if (ngaySinh > DateTime.Today.AddYears(-tuoi))
            {
                tuoi--;
            }

            if (tuoi < 18)
            {
                MessageBox.Show("Tuổi phải lớn hơn hoặc bằng 18!");
                return false;
            }

            return true;
        }

        private void dvNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien st = new NhanVien();
            int list = dvNhanVien.CurrentRow.Index;
            txtTaiKhoan.Text = dvNhanVien.Rows[list].Cells[2].Value.ToString();
            txtHoTen.Text = dvNhanVien.Rows[list].Cells[1].Value.ToString();
            dtpNgSinh.Text = dvNhanVien.Rows[list].Cells[4].Value.ToString();
            txtMatKhau.Text = dvNhanVien.Rows[list].Cells[5].Value.ToString();
            cboQuyen.Text = dvNhanVien.Rows[list].Cells[3].Value.ToString();
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            string searchText = txttim.Text;

            var query = from nv in QLKS.NhanViens
                        where nv.HoTen.Contains(searchText)
                        select new
                        {
                            MaNV = nv.MaNV,
                            Hoten = nv.HoTen,
                            TaiKhoan = nv.TenTK,
                            Quyen = nv.Quyen,
                            NgSinh = nv.Ngaysinh,
                            MatKhau = "*******",
                        };
            dvNhanVien.DataSource = query.ToList();
            dvNhanVien.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dvNhanVien.Columns["TaiKhoan"].HeaderText = "Tài khoản";
            dvNhanVien.Columns["Hoten"].HeaderText = "Họ tên";
            dvNhanVien.Columns["Quyen"].HeaderText = "Quyền";
            dvNhanVien.Columns["NgSinh"].HeaderText = "Ngày sinh";
            dvNhanVien.Columns["MatKhau"].HeaderText = "Mật khẩu";
        }
    }
}
