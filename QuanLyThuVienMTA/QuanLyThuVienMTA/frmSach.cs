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
namespace QuanLyThuVienMTA
{
    public partial class frmSach : Form
    {
        Sach sach = new Sach();
        SachBUS sachbus = new SachBUS();
        private int fluu = 1;
        public frmSach()
        {
            InitializeComponent();
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            cmbMaViTri.DataSource = sachbus.GetData();
            cmbMaViTri.DisplayMember = "MaVT";
            HienThi();
            DisEnl(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác Nhận Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                HienThi();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                HienThi();
                DisEnl(false);
            }
            else
                return;
        }
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtMaSach.Enabled = e;
            txtTenSach.Enabled = e;
            txtTacGia.Enabled = e;
            txtTheLoai.Enabled = e;
            txtNXB.Enabled = e;
            txtNgonNgu.Enabled = e;
            txtLinhVuc.Enabled = e;
            txtNamXuatBan.Enabled = e;
            cmbMaViTri.Enabled = e;
            txtSoLuong.Enabled = e;
        }
        private void clearData()
        {
            txtMaSach.Text="";
            txtTenSach.Text = "";
            txtTacGia.Text = "";
            txtTheLoai.Text = "";
            txtNXB.Text = "";
            txtNgonNgu.Text = "";
            txtLinhVuc.Text = "";
            txtNamXuatBan.Text = "";
            cmbMaViTri.Text = "";
            txtSoLuong.Text = "";
        }
        private void HienThi()
        {
            dgvChiTietSach.DataSource = sachbus.GetData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            clearData();
            txtMaSach.Text = sachbus.TangMa();
            DisEnl(true);
            txtMaSach.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txtMaSach.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    sachbus.XoaSach(txtMaSach.Text);
                    MessageBox.Show("Xóa thành công!");
                    clearData();
                    DisEnl(false);
                    HienThi();
                }
                catch
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            sach.MaSach=txtMaSach.Text; 
            sach.TenSach=txtTenSach.Text ;
            sach.TacGia=txtTacGia.Text ;
            sach.TheLoai=txtTheLoai.Text;
            sach.NXB=txtNXB.Text ;
            sach.NgonNgu=txtNgonNgu.Text ;
            sach.LinhVuc=txtLinhVuc.Text;
            sach.NamXB = Convert.ToInt16(txtNamXuatBan.Text);
            sach.MaViTri=cmbMaViTri.Text ;
            sach.SoLuong= Convert.ToInt16(txtSoLuong.Text);
            if (fluu == 0)
            {
                sachbus.ThemSach(sach);
                MessageBox.Show("Thêm thành công!");
                HienThi();
                clearData();
                DisEnl(false);
            }
            else
            {
                sachbus.SuaSach(sach);
                MessageBox.Show("Sửa Thành Công ! ");
                HienThi();
                clearData();
                DisEnl(false);
            }
        }

        private void dgvChiTietSach_Click(object sender, EventArgs e)
        {
            if (fluu==0)
            {
                txtTenSach.Text = Convert.ToString(dgvChiTietSach.CurrentRow.Cells["TenSach"].Value);
                txtTacGia.Text = Convert.ToString(dgvChiTietSach.CurrentRow.Cells["TacGia"].Value);
                txtTheLoai.Text = Convert.ToString(dgvChiTietSach.CurrentRow.Cells["TheLoai"].Value);
                txtNXB.Text = Convert.ToString(dgvChiTietSach.CurrentRow.Cells["NXB"].Value);
                txtNgonNgu.Text = Convert.ToString(dgvChiTietSach.CurrentRow.Cells["NgonNgu"].Value);
                txtLinhVuc.Text = Convert.ToString(dgvChiTietSach.CurrentRow.Cells["LinhVuc"].Value);
                txtNamXuatBan.Text = Convert.ToString(dgvChiTietSach.CurrentRow.Cells["NamXB"].Value);
                cmbMaViTri.Text = Convert.ToString(dgvChiTietSach.CurrentRow.Cells["MaVT"].Value);
                txtSoLuong.Text = Convert.ToString(dgvChiTietSach.CurrentRow.Cells["SoLuong"].Value);
            }else
            {
                txtMaSach.Text = Convert.ToString(dgvChiTietSach.CurrentRow.Cells["MaSach"].Value);
                txtTenSach.Text = Convert.ToString(dgvChiTietSach.CurrentRow.Cells["TenSach"].Value);
                txtTacGia.Text = Convert.ToString(dgvChiTietSach.CurrentRow.Cells["TacGia"].Value);
                txtTheLoai.Text = Convert.ToString(dgvChiTietSach.CurrentRow.Cells["TheLoai"].Value);
                txtNXB.Text = Convert.ToString(dgvChiTietSach.CurrentRow.Cells["NXB"].Value);
                txtNgonNgu.Text = Convert.ToString(dgvChiTietSach.CurrentRow.Cells["NgonNgu"].Value);
                txtLinhVuc.Text = Convert.ToString(dgvChiTietSach.CurrentRow.Cells["LinhVuc"].Value);
                txtNamXuatBan.Text = Convert.ToString(dgvChiTietSach.CurrentRow.Cells["NamXB"].Value);
                cmbMaViTri.Text = Convert.ToString(dgvChiTietSach.CurrentRow.Cells["MaVT"].Value);
                txtSoLuong.Text = Convert.ToString(dgvChiTietSach.CurrentRow.Cells["SoLuong"].Value);
            }
            
        }

        private void dgvChiTietSach_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvChiTietSach.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cmbTimKiem.Text=="Theo Mã Sách")
            {
                dgvChiTietSach.DataSource = sachbus.TimKiemSach("select * from ChiTietSach where MaSach like '%"+txtTimKiem.Text+"%'");
            }
            if (cmbTimKiem.Text == "Theo Tên Sách")
            {
                dgvChiTietSach.DataSource = sachbus.TimKiemSach("select * from ChiTietSach where TenSach like '%" + txtTimKiem.Text + "%'");
            }
            if (cmbTimKiem.Text == "Theo Tác Giả")
            {
                dgvChiTietSach.DataSource = sachbus.TimKiemSach("select * from ChiTietSach where TacGia like '%" + txtTimKiem.Text + "%'");
            }
            if (cmbTimKiem.Text == "Theo Thể Loại")
            {
                dgvChiTietSach.DataSource = sachbus.TimKiemSach("select * from ChiTietSach where TheLoai like '%" + txtTimKiem.Text + "%'");
            }
            if (cmbTimKiem.Text == "Theo NXB")
            {
                dgvChiTietSach.DataSource = sachbus.TimKiemSach("select * from ChiTietSach where NXB like '%" + txtTimKiem.Text + "%'");
            }
            if (cmbTimKiem.Text == "Theo Ngôn Ngữ")
            {
                dgvChiTietSach.DataSource = sachbus.TimKiemSach("select * from ChiTietSach where NgonNgu like '%" + txtTimKiem.Text + "%'");
            }
            if (cmbTimKiem.Text == "Theo Lĩnh Vực")
            {
                dgvChiTietSach.DataSource = sachbus.TimKiemSach("select * from ChiTietSach where LinhVuc like '%" + txtTimKiem.Text + "%'");
            }
            if (cmbTimKiem.Text == "Theo Năm Xuât Bản")
            {
                dgvChiTietSach.DataSource = sachbus.TimKiemSach("select * from ChiTietSach where NamXB like '%" + Convert.ToInt16(txtTimKiem.Text)+ "%'");
            }
            if (cmbTimKiem.Text == "Theo Mã Vị Trí")
            {
                dgvChiTietSach.DataSource = sachbus.TimKiemSach("select * from ChiTietSach where MaVT like '%" + txtTimKiem.Text + "%'");
            }
        }
    }
}
