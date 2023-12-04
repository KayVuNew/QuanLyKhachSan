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
    public partial class PhieuthuePhong : Form
    {
        QLKSEntities QLKS = new QLKSEntities();
        public PhieuthuePhong()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            var result = from PTP in QLKS.Phieuthuephong
                         select new
                         {
                             MaPhieuThuePhong = PTP.MaPhieuThuePhong,
                             MaKH = PTP.KhachHang.MaKH,
                             MaNV = PTP.NhanVien.MaNV,
                             GhiChu = PTP.GhiChu,
                         };
            dvThongTin.DataSource = result.ToList();
            dvThongTin.Columns["MaPhieuThuePhong"].HeaderText = "Mã phiếu thuê phòng";
            dvThongTin.Columns["MaKH"].HeaderText = "Mã khách hàng";
            dvThongTin.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dvThongTin.Columns["GhiChu"].HeaderText = "Ghi chú";
        }
        void ClearFields()
        {
            txtMaKH.Text = "";
            txtMaNV.Text = "";
            txtGhiChu.Text = "";
        }
        private void PhieuthuePhong_Load(object sender, EventArgs e)
        {

        }

        private void dvThongTin_DoubleClick(object sender, EventArgs e)
        {
            if (dvThongTin.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dvThongTin.SelectedRows[0];
                txtGhiChu.Text = row.Cells["GhiChu"].Value.ToString();
                txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
                txtMaKH.Text = row.Cells["MaKH"].Value.ToString();

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            PhieuthuePhong PTP = new PhieuthuePhong();
            try
            {
                int MaKH = Convert.ToInt32(txtMaKH.Text.Trim());
                int MaNV = Convert.ToInt32(txtMaNV.Text.Trim());
                string GhiChu = txtGhiChu.Text.Trim();

                // Gán giá trị cho đối tượng mới
                PTP.MaKH = MaKH;
                PTP.MaNV = MaNV;
                PTP.GhiChu = GhiChu;
                //Thêm đối tượng vào DbContext của QLKS
                QLKS.Phieuthuephong.Add(PTP);

                // Lưu thay đổi vào cơ sở dữ liệu
                QLKS.SaveChanges();

                // Tải lại dữ liệu
                LoadData();
                ClearFields();
                MessageBox.Show("Thêm Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể thêm phiếu thuê. Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dvThongTin.SelectedRows.Count > 0)
            {
                try
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in dvThongTin.SelectedRows)
                        {
                            if (!row.IsNewRow)  // Check if the selected row is not a new row
                            {
                                string GhiChu = row.Cells["GhiChu"].Value.ToString();

                                var KHDL = QLKS.Phieuthuephong.FirstOrDefault(p => p.GhiChu == GhiChu);
                                if (KHDL != null)
                                {
                                    QLKS.Phieuthuephong.Remove(KHDL);
                                }
                            }
                        }
                        QLKS.SaveChanges();

                        LoadData();
                        ClearFields();

                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa thông tin. Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Log the exception for further analysis
                    Console.WriteLine(ex.StackTrace);
                }

            }
        }
    }
}
