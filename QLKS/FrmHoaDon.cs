using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class FrmHoaDon : Form
    {
        public FrmHoaDon()
        {
            InitializeComponent();
        }
        Nhom3_Duan1_QuanLiKhachSanEntities QLKS = new Nhom3_Duan1_QuanLiKhachSanEntities();
        private void dvThongTin_Click(object sender, EventArgs e)
        {
            
        }

        void LoadData()
        {
            var result = from HD in QLKS.HoaDons
                         join ptp in QLKS.Phieuthuephongs on HD.MaPhieuThuePhong equals ptp.MaPhieuThuePhong
                         join ctp in QLKS.ChiTietPhieuThues on ptp.MaPhieuThuePhong equals ctp.Maphieuthuephong
                         select new
                         {
                             MaHoaDon = HD.MaHoaDon,
                             TienPhong = HD.TienPhong,
                             TienDV = HD.TienDV,
                             TongTien = HD.TongTien,
                             HinhThucThanhToan = HD.HinhThucThanhToan,
                             NgayThanhToan = HD.NgayThanhToan,
                             GhiChu = HD.GhiChu,
                             KhachHang = ptp.KhachHang.TenKH,
                             NhanVien = ptp.NhanVien.HoTen,
                             Phong = ctp.Phong.TenPhong  // Room name from ChiTietPhieuThue
                         };
            dvThongTin.DataSource = result.ToList();
            // Set the column headers as needed
        }
            private void btnThem_Click(object sender, EventArgs e)
            {
                HoaDon HD = new HoaDon();
                var tenPhong = QLKS.Phongs.FirstOrDefault(pgs => pgs.TenPhong == cboPhong.Text);
                var MaPG = QLKS.ChiTietPhieuThues.FirstOrDefault(mpg => mpg.MaPhong == tenPhong.MaPhong);
                var MaSD = QLKS.SuDungDichVus.FirstOrDefault(sddv => sddv.MaChiTietPhieuThue == MaPG.MaChiTietPhieuThue);
                var MaPTP = QLKS.Phieuthuephongs.FirstOrDefault(mptp => mptp.MaPhieuThuePhong == MaPG.Maphieuthuephong);
                int MaPhieuThuePhong = MaPTP.MaPhieuThuePhong;
                string Phong = cboPhong.Text.Trim();
                float tienPhong = (float)tenPhong.GiaThue;
                float tienDV = QLKS.SuDungDichVus
                .Where(sddv => sddv.MaChiTietPhieuThue == MaPG.MaChiTietPhieuThue)
                .Sum(sddv => (float)sddv.GiaTien);
            DateTime NgayThanhToan = DateTime.ParseExact(dtpThanhToan.Text, "dd/MM/yyyy", CultureInfo.CurrentCulture); ; // Sử dụng thuộc tính Value của DateTimePicker để lấy ngày giờ đã chọn
                string HinhThucThanhToan = cboHinhThuc.Text; // Sử dụng điều kiện ba ngôi để tối ưu mã lệnh
                string GhiChu = txtGhichu.Text.Trim();

                float TongTien = (int)(tienDV + tienPhong);
                Random random = new Random();
                string MaHD = "HD" + random.Next(10000000, 99999999).ToString();

                // Check if the generated MaHD already exists
                while (QLKS.HoaDons.Any(hd => hd.MaHoaDon == MaHD))
                {
                    MaHD = "HD" + random.Next(10000000, 99999999).ToString();
                }

                // Assign the generated MaHD to the HoaDon object
                HD.MaHoaDon = MaHD;

                // Gán giá trị cho đối tượng HD
                HD.MaHoaDon = MaHD;
                    HD.MaPhieuThuePhong = MaPhieuThuePhong;
                    HD.TienPhong = tienPhong;
                    HD.TienDV = (double)tienDV;
                    HD.NgayThanhToan = NgayThanhToan;
                    HD.TongTien = TongTien;
                    HD.HinhThucThanhToan = HinhThucThanhToan;
                    HD.GhiChu = GhiChu;

                    // Thêm đối tượng vào DbContext của QLKS
                    QLKS.HoaDons.Add(HD);

                    // Lưu thay đổi vào cơ sở dữ liệu
                    QLKS.SaveChanges();

                    // Tải lại dữ liệu
                    LoadData();
                    //ClearFields();
                    MessageBox.Show("Thêm Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                    //catch (Exception ex)
                    //{
                    //    MessageBox.Show("Không thể thêm hóa đơn. Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
            }

        private void FrmHoaDon_Load(object sender, EventArgs e)
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
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            int list = dvThongTin.CurrentRow.Index;
            string MaHD = dvThongTin.Rows[list].Cells[0].Value.ToString();
            string KH = dvThongTin.Rows[list].Cells[7].Value.ToString();
            string hinhthucthanhtoan = dvThongTin.Rows[list].Cells[4].Value.ToString();
            string phong = dvThongTin.Rows[list].Cells[9].Value.ToString();
            string ghichu = dvThongTin.Rows[list].Cells[6].Value.ToString();
            string nhanvien = dvThongTin.Rows[list].Cells[8].Value.ToString();
            DateTime ngthanhtoan = DateTime.Parse(dvThongTin.Rows[list].Cells[5].Value.ToString());
            int tongtien = int.Parse(dvThongTin.Rows[list].Cells[3].Value.ToString());
            int tienDV = int.Parse(dvThongTin.Rows[list].Cells[2].Value.ToString());
            int tienPG = int.Parse(dvThongTin.Rows[list].Cells[1].Value.ToString());
            HoaDonConn hdc = new HoaDonConn(MaHD, KH, hinhthucthanhtoan, phong, ghichu, nhanvien, tongtien,tienDV,tienPG,ngthanhtoan);
            hdc.ShowDialog();
        }
    }
}
