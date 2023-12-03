using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class DangKyDichVu : Form
    {
        public DangKyDichVu()
        {
            InitializeComponent();
        }
        Nhom3_Duan1_QuanLiKhachSanEntities QLKS = new Nhom3_Duan1_QuanLiKhachSanEntities();
        private void DangKyDichVu_Load(object sender, EventArgs e)
        {
            LoadData();
            var phongAndChiTietThue = (from c in QLKS.ChiTietPhieuThues
                                       join p in QLKS.Phongs on c.MaPhong equals p.MaPhong
                                       select new
                                       {
                                           TenPhong = p.TenPhong
                                       }).Distinct();

            foreach (var item in phongAndChiTietThue)
            {
                cboPhong.Items.Add(item.TenPhong);
            }
            var DichVu = QLKS.DichVus.Select(nv => nv.TenDV).ToList();

            foreach (var dichVu in DichVu)
            {
                cboTenDV.Items.Add(dichVu);
            }
        }
        private bool KiemTraMaSD(string maSD)
        {
            string pattern = @"^SD\d{3}$"; // Định dạng "DV" + 3 số nguyên
            Regex regex = new Regex(pattern);

            return regex.IsMatch(maSD);
        }
        void LoadData()
        {
            var result = from dv in QLKS.SuDungDichVus
                         join d in QLKS.DichVus on dv.MaDV equals d.MaDV
                         select new
                         {
                             MaSD = dv.MaSuDung,
                             NgaySD = dv.NgaySuDung,
                             TenDV = d.TenDV,
                             GiaTien = d.DonGia,
                             SL = dv.SoLuong,
                             ThanhTien = dv.GiaTien,
                             MaCTPT = dv.ChiTietPhieuThue.Phong.TenPhong
                         };
            dvDKDV.DataSource = result.ToList();

            dvDKDV.Columns["MaSD"].HeaderText = "Mã sử dụng";
            dvDKDV.Columns["NgaySD"].HeaderText = "Ngày sử dụng";
            dvDKDV.Columns["TenDV"].HeaderText = "Tên dịch vụ";
            dvDKDV.Columns["GiaTien"].HeaderText = "Đơn giá";
            dvDKDV.Columns["SL"].HeaderText = "Số lượng";
            dvDKDV.Columns["ThanhTien"].HeaderText = "Thành tiền";
            dvDKDV.Columns["MaCTPT"].HeaderText = "Tên phòng";
        }
        void ClearFields()
        {
            dtpNgaySD.Text = "";
            cboTenDV.Text = "";
            txtSL.Text = "";
            //txtGiaTien.Text = "";
            cboPhong.Text = "";
            cboTenDV.Text = "";
        }

        private void cboTenDV_TextChanged(object sender, EventArgs e)
        {

            var loaiDV = QLKS.DichVus.FirstOrDefault(d => d.TenDV == cboTenDV.Text);
            if (loaiDV != null)
            {
                txtGiaTien.Text = loaiDV.DonGia.ToString();
            }
            else
            {
                txtGiaTien.Text = "";
            }
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            int giaTien;
            int soLuong;
            if (int.TryParse(txtGiaTien.Text, out giaTien) && int.TryParse(txtSL.Text, out soLuong))
            {
                int thanhTien = giaTien * soLuong;
                txtThanhTien.Text = thanhTien.ToString();
            }
            else
            {
                txtThanhTien.Text = "";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Random random = new Random();
                string MaSD = "SD" + random.Next(100, 999).ToString();

                // Check if the generated MaHD already exists
                while (QLKS.SuDungDichVus.Any(hd => hd.MaSuDung == MaSD))
                {
                    MaSD = "SD" + random.Next(100, 999).ToString();
                }
                if (!KiemTraMaSD(MaSD))
                {
                    MessageBox.Show("Mã sử dụng không đúng định dạng! Vui lòng nhập lại theo định dạng SD + 3 số nguyên bất kì.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DateTime NgaySD = DateTime.Parse(dtpNgaySD.Text.Trim());
                int SL = int.Parse(txtSL.Text.Trim());
                var loaiDV = QLKS.DichVus.FirstOrDefault(dvv => dvv.TenDV == cboTenDV.Text);
                int MaDV = loaiDV.MaDV;
                int ThanhTien = int.Parse(txtThanhTien.Text.Trim());
                var tenPhong = QLKS.Phongs.FirstOrDefault(pg => pg.TenPhong == cboPhong.Text);
                var MaPG = QLKS.ChiTietPhieuThues.FirstOrDefault(mpg => mpg.MaPhong == tenPhong.MaPhong);
                int MaCTPT = MaPG.MaChiTietPhieuThue;
                SuDungDichVu sddv = new SuDungDichVu();
                DichVu dv = new DichVu();

                sddv.MaDV = MaDV;
                sddv.GiaTien = ThanhTien;
                sddv.MaSuDung = MaSD;
                sddv.NgaySuDung = NgaySD;
                sddv.SoLuong = SL;
                //dv.TenDV = TenDV;
                sddv.MaChiTietPhieuThue = MaCTPT;

                QLKS.SuDungDichVus.Add(sddv);
                QLKS.SaveChanges();

                LoadData();
                ClearFields();

                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DateTime NgaySD = DateTime.Parse(dtpNgaySD.Text.Trim());
            int SL = int.Parse(txtSL.Text.Trim());
            var loaiDV = QLKS.DichVus.FirstOrDefault(dv => dv.TenDV == cboTenDV.Text);
            int MaDV = loaiDV.MaDV;
            int ThanhTien = int.Parse(txtThanhTien.Text.Trim());
            var tenPhong = QLKS.Phongs.FirstOrDefault(pg => pg.TenPhong == cboPhong.Text);
            var MaPG = QLKS.ChiTietPhieuThues.FirstOrDefault(mpg => mpg.MaPhong == tenPhong.MaPhong);
            int MaCTPT = MaPG.MaChiTietPhieuThue;

            int rowIndex = dvDKDV.SelectedRows[0].Index;
            string masd = dvDKDV.Rows[rowIndex].Cells["MaSD"].Value.ToString();

            var update = QLKS.SuDungDichVus.FirstOrDefault(p => p.MaSuDung == masd);
            if (update != null)
            {
                update.NgaySuDung = NgaySD;
                update.SoLuong = SL;
                update.MaDV = MaDV;
                update.GiaTien = ThanhTien;
                update.MaChiTietPhieuThue = MaCTPT;

                QLKS.SaveChanges();

                LoadData();
                ClearFields();

                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dvDKDV_Click(object sender, EventArgs e)
        {
            int list = dvDKDV.CurrentRow.Index;
            dtpNgaySD.Text = dvDKDV.Rows[list].Cells[1].Value.ToString();
            cboTenDV.Text = dvDKDV.Rows[list].Cells[2].Value.ToString();
            txtGiaTien.Text = dvDKDV.Rows[list].Cells[3].Value.ToString();
            txtSL.Text = dvDKDV.Rows[list].Cells[4].Value.ToString();
            txtThanhTien.Text = dvDKDV.Rows[list].Cells[5].Value.ToString();
            cboPhong.Text = dvDKDV.Rows[list].Cells[6].Value.ToString();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(cboTenDV.Text) ||
                string.IsNullOrWhiteSpace(cboPhong.Text) ||
                string.IsNullOrWhiteSpace(dtpNgaySD.Text) ||
                string.IsNullOrWhiteSpace(txtGiaTien.Text) ||
                string.IsNullOrWhiteSpace(txtSL.Text) )
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }

}
