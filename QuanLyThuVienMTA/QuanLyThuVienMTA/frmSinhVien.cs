using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using Entity;
using System;
namespace QuanLyThuVienMTA
{
    public partial class frmSinhVien : Form
    {
        SinhVienEntity sv = new SinhVienEntity();
        SinhVienBUS bus = new SinhVienBUS();
        private int fluu = 1;
        public frmSinhVien()
        {
            InitializeComponent();
        }
        public void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtMaSV.Enabled = e;
            txtTenSV.Enabled = e;
            txtSDT.Enabled = e;
            txtLop.Enabled = e;
            dtpNgaySinh.Enabled = e;
            rbNam.Enabled = e;
            rbNu.Enabled = e;
        }
        private void clearData()
        {
            txtMaSV.Text = "";
            txtTenSV.Text = "";
            rbNam.Checked = false;
            rbNu.Checked = false;
            txtSDT.Text = "";
            txtLop.Text = "";
            txtTimKiem.Text = "";
        }
        private void HienThi()
        {
            dgvSV.DataSource = bus.GetData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
           // txtMaSV.Text = bus.TangMa();
            DisEnl(true);
            txtMaSV.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txtMaSV.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bus.XoaSV(txtMaSV.Text);
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
            if (txtMaSV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtTenSV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên sinh viên! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập SĐT của sinh viên! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtLop.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Lớp của sinh viên! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (rbNam.Checked == false && rbNu.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sv.MaSV = txtMaSV.Text;
            sv.TenSV = txtTenSV.Text;
            sv.SoDT = txtSDT.Text;
            sv.NgaySinh = dtpNgaySinh.Value;
            sv.Lop = txtLop.Text;
            string gt;
            if (rbNam.Checked)
            {
                gt = "Nam";
            }
            else gt = "Nữ";

            sv.GioiTinh = gt;
            if (txtMaSV.Text != "" && txtTenSV.Text != "" && txtSDT.Text != "" && txtLop.Text!="" && fluu == 0)
            {
                try
                {
                    bus.ThemSV(sv);
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frmSinhVien_Load(sender, e);
                    clearData();
                    DisEnl(false);
                    fluu = 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);

                }
            }
            else if (txtMaSV.Text != "" && txtTenSV.Text != "" && txtSDT.Text != "" && txtLop.Text != "" && fluu != 0)
            {
                try
                {
                    bus.SuaSV(sv);
                    MessageBox.Show("Sửa Thành Công ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    frmSinhVien_Load(sender, e);
                    clearData();
                    DisEnl(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            if (cbTimKiem.Text == "Theo Mã")
            {
                dgvSV.DataSource = bus.TimKiemSV("select * from SinhVien where MaSV like '%" + txtTimKiem.Text + "%'");
            }
            if (cbTimKiem.Text == "Theo Tên")
            {
                dgvSV.DataSource = bus.TimKiemSV("select * from SinhVien where TenSV like '%" + txtTimKiem.Text + "%'");
            }
            if (cbTimKiem.Text == "Theo Ngày Sinh")
            {
                dgvSV.DataSource = bus.TimKiemSV("select * from SinhVien where NgaySinh like '%" + txtTimKiem.Text + "%'");
            }
            if (cbTimKiem.Text == "Theo SĐT")
            {
                dgvSV.DataSource = bus.TimKiemSV("select * from SinhVien where SoDT like '%" + txtTimKiem.Text + "%'");
            }
            if(cbTimKiem.Text=="Theo Lớp")
            {
                dgvSV.DataSource = bus.TimKiemSV("select * from SinhVien where Lop like '%" + txtTimKiem.Text + "%'");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void dgvSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fluu == 0)
            {
                txtTenSV.Text = Convert.ToString(dgvSV.CurrentRow.Cells["TenSV"].Value);
                txtSDT.Text = Convert.ToString(dgvSV.CurrentRow.Cells["SDT"].Value);
                dtpNgaySinh.Text = Convert.ToString(dgvSV.CurrentRow.Cells["NgaySinh"].Value);
                txtLop.Text = Convert.ToString(dgvSV.CurrentRow.Cells["Lop"].Value);
                if (dgvSV.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString() == "Nam") rbNam.Checked = true;
                else rbNu.Checked = true;
            }
            else
            {
                txtTenSV.Text = Convert.ToString(dgvSV.CurrentRow.Cells["TenSV"].Value);
                txtSDT.Text = Convert.ToString(dgvSV.CurrentRow.Cells["SDT"].Value);
                dtpNgaySinh.Text = Convert.ToString(dgvSV.CurrentRow.Cells["NgaySinh"].Value);
                txtLop.Text = Convert.ToString(dgvSV.CurrentRow.Cells["Lop"].Value);
                if (dgvSV.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString() == "Nam") rbNam.Checked = true;
                else rbNu.Checked = true;
            }
        }

        private void dgvSV_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvSV.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
    }
}
