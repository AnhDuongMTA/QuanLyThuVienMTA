using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BUS;

namespace QuanLyThuVienMTA
{
    public partial class frmViTri : Form
    {
        ViTriSachBus Bus = new ViTriSachBus();
        ViTriSachEntity VT = new ViTriSachEntity();
        private int fluu = 1;
        public static string Ma;
        public frmViTri()
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
            txtMa.Enabled = e;
            txtTen.Enabled = e;
            txtViTri.Enabled = e;
        }
        private void clearData()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtViTri.Text = "";
        }
        private void HienThi()
        {
            dgvViTri.DataSource = Bus.GetData();
        }
        private void frmViTri_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
        }

        private void dgvViTri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fluu == 0)
            {
                txtTen.Text = Convert.ToString(dgvViTri.CurrentRow.Cells["TenKe"].Value);
                txtViTri.Text = Convert.ToString(dgvViTri.CurrentRow.Cells["ViTri"].Value);
            }
            else
            {
                txtMa.Text = Convert.ToString(dgvViTri.CurrentRow.Cells["MaVT"].Value);
                txtTen.Text = Convert.ToString(dgvViTri.CurrentRow.Cells["TenKe"].Value);
                txtViTri.Text = Convert.ToString(dgvViTri.CurrentRow.Cells["ViTri"].Value);
            }

        }

        private void dgvViTri_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvViTri.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
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
                fluu = 1;
            }
            else
                return;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            VT.MaVT = txtMa.Text;
            VT.TenKe = txtTen.Text;
            VT.ViTri = txtViTri.Text;
            if (fluu == 0)
            {
                Bus.ThemViTri(VT);
                MessageBox.Show("Thêm thành công!");
                HienThi();
                clearData();
                DisEnl(false);
            }
            else
            {
                Bus.SuaViTri(VT);
                MessageBox.Show("Sửa Thành Công ! ");
                HienThi();
                clearData();
                DisEnl(false);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Bus.XoaViTri(txtMa.Text);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txtMa.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            txtMa.Text = Bus.TangMa();
            DisEnl(true);
            txtMa.Enabled = false;
        }

        private void btnTTViTri_Click(object sender, EventArgs e)
        {
            if (txtMa.Text != null)
            { Ma = txtMa.Text;
                frmTTViTri frmVt = new frmTTViTri();
                frmVt.Show();
            }
        }

        private void btnTTSach_Click(object sender, EventArgs e)
        {
            if (txtMa.Text != null)
            {
                Ma = txtMa.Text;
                frmDSSach frmDS = new frmDSSach();
                frmDS.Show();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            cmbTimKiem.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cmbTimKiem.Text == "Theo Mã Vị Trí")
            {
                dgvViTri.DataSource = Bus.TimKiemViTri("select * from ViTriSach where MaVT like '%" + txtTimKiem.Text + "%'");
            }
            if (cmbTimKiem.Text == "Theo Tên Kệ")
            {
                dgvViTri.DataSource = Bus.TimKiemViTri("select * from ViTriSach where TenKe like '%" + txtTimKiem.Text + "%'");
            }
            if (cmbTimKiem.Text == "Theo Tác Giả")
            {
                dgvViTri.DataSource = Bus.TimKiemViTri("select * from ViTriSach where ViTri like '%" + txtTimKiem.Text + "%'");
            }
        }
    }
}
