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
    public partial class FrmPhieuThuePhong : Form
    {
        public FrmPhieuThuePhong()
        {
            InitializeComponent();
        }
        Nhom3_Duan1_QuanLiKhachSanEntities QLKS = new Nhom3_Duan1_QuanLiKhachSanEntities();
        int RowIndex;
        void LoadData()
        {
            var result = from dp in QLKS.ChiTietPhieuThues
                         join p in QLKS.Phongs on dp.MaPhong equals p.MaPhong
                         join pt in QLKS.Phieuthuephongs on dp.Maphieuthuephong equals pt.MaPhieuThuePhong
                         select new
                         {
                             TenPhong = p.TenPhong,
                             NgayVao = dp.NgayVao,
                             NgayRa = dp.NgayRa,
                             tenKH = pt.KhachHang.TenKH,
                             tenNV = pt.NhanVien.HoTen,
                             HinhThuc = dp.HinhThucThue,
                             SoLuong = dp.SoLuongKhach
                         };
            dvNhanVien.DataSource = result.ToList();

            dvNhanVien.Columns["TenPhong"].HeaderText = "Tên phòng";
            dvNhanVien.Columns["NgayVao"].HeaderText = "Ngày vào";
            dvNhanVien.Columns["NgayRa"].HeaderText = "Ngày ra";
            dvNhanVien.Columns["tenNV"].HeaderText = "Tên nhân viên";
            dvNhanVien.Columns["tenKH"].HeaderText = "Tên khách hàng";
            dvNhanVien.Columns["HinhThuc"].HeaderText = "Hình thức";
            dvNhanVien.Columns["SoLuong"].HeaderText = "Số lượng";
        }
        private void FrmPhieuThuePhong_Load(object sender, EventArgs e)
        {
            LoadData();
            var tenKH = QLKS.KhachHangs.Select(nv => nv.TenKH).ToList();

            foreach (var Khachhang in tenKH)
            {
                cboKhachHang.Items.Add(Khachhang);
            }
            var tenNV = QLKS.NhanViens.Select(nv => nv.HoTen).ToList();

            foreach (var Nhanvien in tenNV)
            {
                cboNhanVien.Items.Add(Nhanvien);
            }
            var tenPG = QLKS.Phongs.Select(nv => nv.TenPhong).ToList();

            foreach (var tenPg in tenPG)
            {
                cboPhong.Items.Add(tenPg);
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        void ClearFields()
        {
            cboPhong.Text = "";
            cboKhachHang.Text = "";
            cboNhanVien.Text = "";
            txtSL.Text = "";
            dtpNgayRa.Text = "";
            dtpNgayVao.Text = "";
            rtbGhiChu.Text = "";
            cboPhong.Enabled = true;
            cboNhanVien.Enabled = true;
            txtSL.Enabled = true;
            radTrucTiep.Enabled = true;
            radDatTruoc.Enabled = true;
            dtpNgayVao.Enabled = true;
            btnDatPhong.Enabled = true;
            btnTraPhong.Enabled = true;
            rtbGhiChu.Enabled = true;
        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnGiaHan_Click_1(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                if (dvNhanVien.SelectedRows.Count > 0)
                {
                    int list = dvNhanVien.CurrentRow.Index;
                    string pg = dvNhanVien.Rows[list].Cells[0].Value.ToString();
                    var mapg = QLKS.Phongs.FirstOrDefault(p => p.TenPhong == pg);
                    var chiTietPhieuThue = QLKS.ChiTietPhieuThues.FirstOrDefault(p => p.MaPhong == mapg.MaPhong);
                    if (chiTietPhieuThue != null)
                    {
                        // Cập nhật ngày gia hạn
                        chiTietPhieuThue.NgayRa = dtpNgayRa.Value;

                        QLKS.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu

                        LoadData(); // Tải lại dữ liệu sau khi cập nhật
                        ClearFields(); // Xoá các trường nhập liệu sau khi cập nhật thành công

                        MessageBox.Show("Gia hạn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            
        }

        private void btnTraPhong_Click_1(object sender, EventArgs e)
        {
            if (dvNhanVien.SelectedRows.Count > 0)
            {
                int list = dvNhanVien.CurrentRow.Index;
                string pg = dvNhanVien.Rows[list].Cells[0].Value.ToString();
                var mapg = QLKS.Phongs.FirstOrDefault(p => p.TenPhong == pg);
                var chiTietPhieuThue = QLKS.ChiTietPhieuThues.FirstOrDefault(ctpt => ctpt.MaPhong == mapg.MaPhong);
                var ptp = QLKS.Phieuthuephongs.FirstOrDefault(pt => pt.MaPhieuThuePhong == chiTietPhieuThue.Maphieuthuephong);
                var sddv = QLKS.SuDungDichVus.FirstOrDefault(pt => pt.MaChiTietPhieuThue == chiTietPhieuThue.MaChiTietPhieuThue);
                string HP = "Còn phòng";
                int phieuthue = ptp.MaPhieuThuePhong;
                if (sddv != null)
                {
                    QLKS.SuDungDichVus.Remove(sddv);
                    QLKS.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                }
                if (mapg != null)
                {
                    mapg.TinhTrang = HP; // Cập nhật trạng thái của phòng
                    QLKS.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                }

                if (chiTietPhieuThue != null)
                {
                    QLKS.ChiTietPhieuThues.Remove(chiTietPhieuThue);
                    QLKS.SaveChanges();

                    LoadData();
                    ClearFields();

                    MessageBox.Show("Trả phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDatPhong_Click_1(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                var Manv = QLKS.NhanViens.FirstOrDefault(mpg => mpg.HoTen == cboNhanVien.Text);
                string MaNV = Manv.MaNV;
                var Makh = QLKS.KhachHangs.FirstOrDefault(mpk => mpk.TenKH == cboKhachHang.Text);
                string MaKH = Makh.MaKH;
                var MaPg = QLKS.Phongs.FirstOrDefault(mp => mp.TenPhong == cboPhong.Text);
                int MaPhong = MaPg.MaPhong;
                DateTime NgayVao = DateTime.Parse(dtpNgayVao.Text.Trim());
                DateTime NgayRa = DateTime.Parse(dtpNgayRa.Text.Trim());
                string HP = "Hết phòng";
                string HinhThuc = "";

                if (radDatTruoc.Checked)
                {
                    HinhThuc = "Đặt trước";
                }
                else if (radTrucTiep.Checked)
                {
                    HinhThuc = "Trực tiếp";
                }
                int SL = int.Parse(txtSL.Text.Trim());

                ChiTietPhieuThue newpt = new ChiTietPhieuThue();

                Phieuthuephong ptp = new Phieuthuephong();
                ptp.MaNV = MaNV;
                ptp.MaKH = MaKH;
                ptp.GhiChu = rtbGhiChu.Text;
                QLKS.Phieuthuephongs.Add(ptp);
                QLKS.SaveChanges();

                Phong phongNew = new Phong();
                newpt.MaPhong = MaPhong;
                newpt.NgayVao = NgayVao;
                newpt.NgayRa = NgayRa;
                newpt.Maphieuthuephong = ptp.MaPhieuThuePhong;
                newpt.HinhThucThue = HinhThuc;
                newpt.SoLuongKhach = SL;
                phongNew.TinhTrang = HP;
                Phong phongToUpdate = QLKS.Phongs.FirstOrDefault(p => p.MaPhong == MaPhong);
                if (phongToUpdate != null)
                {
                    phongToUpdate.TinhTrang = HP; // Cập nhật trạng thái của phòng
                    QLKS.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                }

                QLKS.ChiTietPhieuThues.Add(newpt);
                QLKS.SaveChanges();

                LoadData();
                ClearFields();

                MessageBox.Show("Đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(cboKhachHang.Text) ||
                string.IsNullOrWhiteSpace(cboNhanVien.Text) ||
                string.IsNullOrWhiteSpace(cboPhong.Text) ||
                string.IsNullOrWhiteSpace(rtbGhiChu.Text) ||
                string.IsNullOrWhiteSpace(txtSL.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!radDatTruoc.Checked && !radTrucTiep.Checked)
            {
                MessageBox.Show("Vui lòng chọn loại hình thanh toán", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (dtpNgayRa.Value.Date <= dtpNgayVao.Value.Date)
            {
                MessageBox.Show("Ngày ra phòng phải sau ngày vào phòng", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void dvNhanVien_Click(object sender, EventArgs e)
        {
            int list = dvNhanVien.CurrentRow.Index;
            cboPhong.Text = dvNhanVien.Rows[list].Cells[0].Value.ToString();
            dtpNgayVao.Text = dvNhanVien.Rows[list].Cells[1].Value.ToString();
            dtpNgayVao.Text = dvNhanVien.Rows[list].Cells[2].Value.ToString();
            cboKhachHang.Text = dvNhanVien.Rows[list].Cells[3].Value.ToString();
            cboNhanVien.Text = dvNhanVien.Rows[list].Cells[4].Value.ToString();
            string HinhThuc = dvNhanVien.Rows[list].Cells[5].Value.ToString();
            if (HinhThuc == "Đặt trước")
            {
                radDatTruoc.Checked = true;
            }
            else if (HinhThuc == "Trực tiếp")
            {
                radTrucTiep.Checked = true;
            }
            cboPhong.Enabled = false;
            cboKhachHang.Enabled = false;
            cboNhanVien.Enabled = false;
            txtSL.Enabled = false;
            radTrucTiep.Enabled = false;
            radDatTruoc.Enabled = false;
            dtpNgayVao.Enabled = false;
            btnDatPhong.Enabled = false;
        }

        private void dtpNgayVao_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboPhong_TextChanged(object sender, EventArgs e)
        {
            var tenPG = QLKS.Phongs.FirstOrDefault(nv => nv.TenPhong == cboPhong.Text);
            var LoaiPg = QLKS.LoaiPhongs.FirstOrDefault(nv => nv.MaLoai == tenPG.MaLoai);
            txtSL.Text = LoaiPg.SoNguoi.ToString();
        }
    }
}
