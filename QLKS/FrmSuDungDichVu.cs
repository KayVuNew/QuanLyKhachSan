using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QLKS
{
    public partial class FrmSuDungDichVu : Form
    {
        QLKSEntities QLKS = new QLKSEntities();
        public FrmSuDungDichVu()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            var result = from dv in QLKS.SuDungDichVu
                         join d in QLKS.DichVu on dv.MaDV equals d.MaDV
                         select new
                         {
                             MaSD = dv.MaSuDung,
                             MaDV = dv.MaDV,
                             NgaySD = dv.NgaySuDung,
                             TenDV = d.TenDV,
                             GiaTien = d.DonGia,
                             SL = dv.SoLuong,
                             ThanhTien = dv.GiaTien,
                             MaCTPT = dv.MaChiTietPhieuThue
                         };
            dataGridView1.DataSource = result.ToList();

            dataGridView1.Columns["MaSD"].HeaderText = "Mã sử dụng";
            dataGridView1.Columns["MaDV"].HeaderText = "Mã dịch vụ";
            dataGridView1.Columns["NgaySD"].HeaderText = "Ngày sử dụng";         
            dataGridView1.Columns["TenDV"].HeaderText = "Tên dịch vụ";
            dataGridView1.Columns["GiaTien"].HeaderText = "Đơn giá";
            dataGridView1.Columns["SL"].HeaderText = "Số lượng";
            dataGridView1.Columns["ThanhTien"].HeaderText = "Thành tiền";
            dataGridView1.Columns["MaCTPT"].HeaderText = "Mã chi tiết phiếu thuê";
        }
        void ClearFields()
        {
            txtMaDV.Text = "";
            txtMaSD.Text = "";
            dtpNgaySD.Text = "";
            //cboTenDV.Text = "";
            txtSL.Text = "";
            txtGiaTien.Text = "";
            txtMaCTPT.Text = "";
            //cboTenDV.SelectedItem = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            string MaSD = txtMaSD.Text.Trim();
            if (!KiemTraMaSD(MaSD))
            {
                MessageBox.Show("Mã sử dụng không đúng định dạng! Vui lòng nhập lại theo định dạng SD + 3 số nguyên bất kì.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime NgaySD = DateTime.Parse(dtpNgaySD.Text.Trim());
            int SL = int.Parse(txtSL.Text.Trim());
            int MaDV = int.Parse(txtMaDV.Text.Trim());
            int ThanhTien = int.Parse(txtThanhTien.Text.Trim());
            int MaCTPT = int.Parse(txtMaCTPT.Text.Trim());

            SuDungDichVu sddv = new SuDungDichVu();
            DichVu dv = new DichVu();

            sddv.MaDV = MaDV;
            sddv.GiaTien = ThanhTien;
            sddv.MaSuDung = MaSD;
            sddv.NgaySuDung = NgaySD;
            sddv.SoLuong = SL;
            //dv.TenDV = TenDV;
            sddv.MaChiTietPhieuThue = MaCTPT;

            QLKS.SuDungDichVu.Add(sddv);
            QLKS.SaveChanges();

            LoadData();
            ClearFields();

            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                    int rowIndex = dataGridView1.SelectedRows[0].Index;
                    string MaSD = dataGridView1.Rows[rowIndex].Cells["MaSD"].Value.ToString();

                    var delete = QLKS.SuDungDichVu.FirstOrDefault(p => p.MaSuDung == MaSD);
                    if (delete != null)
                    {
                        QLKS.SuDungDichVu.Remove(delete);
                        QLKS.SaveChanges();

                        LoadData();
                        ClearFields();

                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
             }
        }
        private void txtMaDV_TextChanged(object sender, EventArgs e)
        {
            if (txtMaDV.Text == "1")
            {
                txtGiaTien.Text = 50000.ToString();
                txtTenDV.Text = "Bữa sáng";
            }
            else if (txtMaDV.Text == "2")
            {
                txtGiaTien.Text = 200000.ToString();
                txtTenDV.Text = "Thẻ tập gym";
            }
            else if (txtMaDV.Text == "3")
            {
                txtGiaTien.Text = 300000.ToString();
                txtTenDV.Text = "Dịch vụ khác";
            }
            else
            {
                txtGiaTien.Text = "0";
                txtTenDV.Text = "Không có dịch vụ";
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
            } else 
            {
                txtThanhTien.Text = "0"; 
            }
        }
        private bool KiemTraMaSD(string maSD)
        {
            string pattern = @"^SD\d{3}$"; // Định dạng "DV" + 3 số nguyên
            Regex regex = new Regex(pattern);

            return regex.IsMatch(maSD);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            string MaSD = row.Cells["MaSD"].Value.ToString();
            int MaDV = int.Parse(row.Cells["MaDV"].Value.ToString());
            DateTime NgaySD = DateTime.Parse(row.Cells["NgaySD"].Value.ToString());
            string TenDV = row.Cells["TenDV"].Value.ToString();
            int GiaTien = int.Parse(row.Cells["GiaTien"].Value.ToString());
            int SL = int.Parse(row.Cells["SL"].Value.ToString());
            int ThanhTien = int.Parse(row.Cells["ThanhTien"].Value.ToString());
            int MaCTPT = int.Parse(row.Cells["MaCTPT"].Value.ToString());
            // Hiển thị dữ liệu lên các control tương ứng
            txtMaSD.Text = MaSD.ToString();
            txtMaDV.Text = MaDV.ToString();
            dtpNgaySD.Text = NgaySD.ToString();
            txtTenDV.Text = TenDV.ToString();
            txtGiaTien.Text = GiaTien.ToString();
            txtSL.Text = SL.ToString();
            txtThanhTien.Text = ThanhTien.ToString();
            txtMaCTPT.Text = MaCTPT.ToString();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string MaSD = txtMaSD.Text.Trim();
            DateTime NgaySD = DateTime.Parse(dtpNgaySD.Text.Trim());
            int SL = int.Parse(txtSL.Text.Trim());
            int MaDV = int.Parse(txtMaDV.Text.Trim());
            int ThanhTien = int.Parse(txtThanhTien.Text.Trim());
            int MaCTPT = int.Parse(txtMaCTPT.Text.Trim());

            int rowIndex = dataGridView1.SelectedRows[0].Index;
            string masd = dataGridView1.Rows[rowIndex].Cells["MaSD"].Value.ToString();

            var update = QLKS.SuDungDichVu.FirstOrDefault(p => p.MaSuDung == masd);
            if (update != null)
            {
                update.MaSuDung = MaSD;
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
    }
}
