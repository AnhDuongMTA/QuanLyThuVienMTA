using BUS;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVienMTA
{
    public partial class frmNhanVien : Form
    {
        NhanVienEntity obj = new NhanVienEntity();
        NhanVienBUS Bus = new NhanVienBUS();
        private int fluu = 1;
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            dtNgaySinh.Enabled = e;
            txtDienThoai.Enabled = e;
            txtMaNV.Enabled = e;
            txtTenNV.Enabled = e;
            radNam.Enabled = e;
            radNu.Enabled = e;
        }
        private void clearData()
        {
            txtMaNV.Text = "";
            radNam.Checked = false;
            radNu.Checked = false;
            txtDienThoai.Text = "";
            txtTenNV.Text = "";
            txtTimKiem.Text = "";
        }
        private void HienThi()
        {
            dgvNhanVien.DataSource = Bus.GetData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Xác nhận ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmMain main = new frmMain();
                main.Show();
                this.Close();
            }
            else
                HienThi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            txtMaNV.Text = Bus.TangMa();
            DisEnl(true);
            txtMaNV.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txtMaNV.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Bus.DeleteData(txtMaNV.Text);
                    MessageBox.Show("Xóa thành công!");
                    clearData();
                    DisEnl(false);
                    HienThi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtTenNV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtDienThoai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập SĐT nhân viên! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (radNam.Checked==false && radNu.Checked==false)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            obj.MaNV = txtMaNV.Text;
            obj.TenNV = txtTenNV.Text;
            obj.DienThoai = txtDienThoai.Text;    
            obj.NgaySinh = dtNgaySinh.Value;
            string gt;
            if (radNam.Checked)
            {
                gt = "Nam";
            }
            else gt = "Nữ";

            obj.GioiTinh = gt;
            if (txtMaNV.Text != "" && txtTenNV.Text != "" && txtDienThoai.Text != "" && fluu == 0)
            {
                try
                {
                    Bus.InsertData(obj);
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frmNhanVien_Load(sender, e);
                    clearData();
                    DisEnl(false);
                    fluu = 1;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);

                }
            }
            else if (txtMaNV.Text != "" && txtTenNV.Text != "" && txtDienThoai.Text != "" && fluu != 0)
            {
                try
                {
                    Bus.UpdateData(obj);
                    MessageBox.Show("Sửa Thành Công ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frmNhanVien_Load(sender, e);
                    clearData();
                    DisEnl(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                HienThi();
                DisEnl(false);
                fluu = 1;

            }
            else
                return;
        }

        private void btnLamTrong_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {          
            HienThi();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbTimKiem.Text == "Theo Mã")
            {
                dgvNhanVien.DataSource = Bus.TimKiemNV("select * from NhanVien where MaNV like '%" + txtTimKiem.Text + "%'");
            }
            if (cbTimKiem.Text == "Theo Tên")
            {
                dgvNhanVien.DataSource = Bus.TimKiemNV("select * from NhanVien where TenNV like '%" + txtTimKiem.Text + "%'");
            }
            if (cbTimKiem.Text == "Theo Giới Tính")
            {
                dgvNhanVien.DataSource = Bus.TimKiemNV("select * from NhanVien where GioiTinh like '%" + txtTimKiem.Text + "%'");
            }
            if (cbTimKiem.Text == "Theo Ngày Sinh")
            {
                dgvNhanVien.DataSource = Bus.TimKiemNV("select * from NhanVien where NgaySinh like '%" + txtTimKiem.Text + "%'");
            }
            if (cbTimKiem.Text == "Theo SĐT")
            {
                dgvNhanVien.DataSource = Bus.TimKiemNV("select * from NhanVien where DienThoai like '%" + txtTimKiem.Text + "%'");
            }
            
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fluu == 0)
            {
                txtTenNV.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["TenNV"].Value);
                txtDienThoai.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["DienThoai"].Value);                
                dtNgaySinh.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["NgaySinh"].Value);              
                if (dgvNhanVien.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString() == "Nam") radNam.Checked = true;
                else radNu.Checked = true;
            }
            else
            {
                txtMaNV.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["MaNV"].Value);
                txtTenNV.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["TenNV"].Value);
                txtDienThoai.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["DienThoai"].Value);
                dtNgaySinh.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["NgaySinh"].Value);
                if (dgvNhanVien.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString() == "Nam") radNam.Checked = true;
                else radNu.Checked = true;
            }
        }

        private void dgvNhanVien_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvNhanVien.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

    }
}
