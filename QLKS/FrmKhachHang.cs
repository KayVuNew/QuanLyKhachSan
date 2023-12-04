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
    public partial class FrmKhachHang : Form
    {
        public FrmKhachHang()
        {
            InitializeComponent();
        }
        Nhom3_Duan1_QuanLiKhachSanEntities QLKS = new Nhom3_Duan1_QuanLiKhachSanEntities();
        private int rowIndex;
        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            var result = from kh in QLKS.KhachHangs
                         select new
                         {
                             MaKH = kh.MaKH,
                             TenKH = kh.TenKH,
                             SDT = kh.SDT,
                             DiaChi = kh.DiaChi,
                             CCCD = kh.SoCCCD
                         };
            dvKhachHang.DataSource = result.ToList();

            dvKhachHang.Columns["MaKH"].HeaderText = "Mã khách hàng";
            dvKhachHang.Columns["TenKH"].HeaderText = "Tên khách hàng";
            dvKhachHang.Columns["SDT"].HeaderText = "SĐT";
            dvKhachHang.Columns["DiaChi"].HeaderText = "Địa chỉ";
        }
        void ClearFields()
        {
            txtCMND.Text = "";
            txtSDT.Text = "";
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txttim.Text = "";
        }
        private void btthem_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                try
                {
                    Random random = new Random();
                    string Makh = "KH" + random.Next(100, 999).ToString();

                    // Check if the generated MaHD already exists
                    while (QLKS.KhachHangs.Any(hd => hd.MaKH == Makh))
                    {
                        Makh = "KH" + random.Next(100, 999).ToString();
                    }

                    string Ten = txtTen.Text.Trim();
                    string SDT = txtSDT.Text.Trim();
                    int CMND = int.Parse(txtCMND.Text.Trim());
                    string DiaChi = txtDiaChi.Text.Trim();

                    KhachHang newkh = new KhachHang();
                    newkh.MaKH = Makh;
                    newkh.TenKH = Ten;
                    newkh.SDT = SDT;
                    newkh.SoCCCD = CMND;
                    newkh.DiaChi = DiaChi;

                    QLKS.KhachHangs.Add(newkh);
                    QLKS.SaveChanges();

                    LoadData();
                    ClearFields();

                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể thêm sản phẩm. Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btsua_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                if (dvKhachHang.SelectedRows.Count > 0)
                {
                    try
                    {
                        string Ten = txtTen.Text.Trim();
                        string SDT = txtSDT.Text.Trim();
                        int CMND = int.Parse(txtCMND.Text.Trim());
                        string DiaChi = txtDiaChi.Text.Trim();

                        int rowIndex = dvKhachHang.SelectedRows[0].Index;
                        string oldSDT = dvKhachHang.Rows[rowIndex].Cells["SDT"].Value.ToString();

                        var KHupdate = QLKS.KhachHangs.FirstOrDefault(p => p.SDT == oldSDT);
                        if (KHupdate != null)
                        {
                            KHupdate.TenKH = Ten;
                            KHupdate.SDT = SDT;
                            KHupdate.SoCCCD = CMND;
                            KHupdate.DiaChi = DiaChi;
                            QLKS.SaveChanges();

                            LoadData();
                            ClearFields();

                            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể cập nhật thông tin. Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text) ||
                string.IsNullOrWhiteSpace(txtCMND.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Regex.IsMatch(txtSDT.Text, @"^0[0-9]{9}$"))
            {
                MessageBox.Show("Số điện thoại chỉ nhập 10 số!");
                return false;
            }
            if (!Regex.IsMatch(txtCMND.Text, @"[0-9]{9}$"))
            {
                MessageBox.Show("Căn cước công dân chỉ nhập 9 số!");
                return false;
            }
            return true;
        }

        private void dvKhachHang_Click(object sender, EventArgs e)
        {
            int list = dvKhachHang.CurrentRow.Index;
            txtTen.Text = dvKhachHang.Rows[list].Cells[1].Value.ToString();
            txtSDT.Text = dvKhachHang.Rows[list].Cells[2].Value.ToString();
            txtCMND.Text = dvKhachHang.Rows[list].Cells[4].Value.ToString();
            txtDiaChi.Text = dvKhachHang.Rows[list].Cells[3].Value.ToString();
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            string sdtCanTim = txttim.Text;

            var result = from kh in QLKS.KhachHangs
                         where kh.TenKH == txttim.Text
                         select new
                         {
                             MaKH = kh.MaKH,
                             TenKH = kh.TenKH,
                             SDT = kh.SDT,
                             DiaChi = kh.DiaChi,
                             CCCD = kh.SoCCCD
                         };

            dvKhachHang.DataSource = result.ToList();

            dvKhachHang.Columns["MaKH"].HeaderText = "Mã khách hàng";
            dvKhachHang.Columns["TenKH"].HeaderText = "Tên khách hàng";
            dvKhachHang.Columns["SDT"].HeaderText = "SĐT";
            dvKhachHang.Columns["DiaChi"].HeaderText = "Địa chỉ";
        }
    }
}
