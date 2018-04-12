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
    public partial class frmChiTietPhieuMuon : Form
    {
        ChiTietPhieuMuon ctpm = new ChiTietPhieuMuon();
        ChiTietPhieuMuonBUS ctpmBUS = new ChiTietPhieuMuonBUS();
        SachBUS SachBUS = new SachBUS();

        public frmChiTietPhieuMuon()
        {
            InitializeComponent();
        }

        public void HienThiDSPM()
        {
            dgvMuon.DataSource =  ctpmBUS.GetData();
            dgvDSMuonT.DataSource = ctpmBUS.GetData();
            ShowTenSach();
        }

        public void Clear()
        {
            txtMaSachT.Text = "";
            txtMaPMT.Text = "";
            txtMaSVT.Text = "";
            dtpNgayHenTraT.Text = "";
            dtpNgayMuonT.Text = "";
            //txtSoLuongTra.Text = "";

        }

        public void ShowTenSach()
        {
            DataTable dt = new DataTable();
            dt = SachBUS.GetData();
            cbTenSach .DataSource = dt.Copy();
            cbTenSach.DisplayMember = "TenSach";
            cbTenSach.ValueMember = "TenSach";

        }
        private void frmChiTietPhieuMua_Load(object sender, EventArgs e)
        {
            HienThiDSPM();
            //txtMaPMM.Text = ctpmBUS.TangMa();
            
        }



        private void btnThoatMuon_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác Nhận Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                HienThiDSPM();
            }
        }

        private void cbTenSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView d = (DataRowView)cbTenSach.SelectedItem;

            lbMaSach.Text = d.Row["MaSach"].ToString();
            lbNgonNgu.Text = d.Row["NgonNgu"].ToString();
            lbTheLoai.Text = d.Row["TheLoai"].ToString();
            lbTacGia.Text = d.Row["TacGia"].ToString();
            lbNXB.Text = d.Row["NXB"].ToString();
            lbSoLuong.Text = d.Row["SoLuong"].ToString();
        }

        private void cbTenSach_TextChanged(object sender, EventArgs e)
        {
            //cbTenSach.DataSource = SachBUS.TimKiem("select * from ChiTietSach where TenSach like '%"+cbTenSach.Text+"%'");
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            ctpm.MaNV = cbMaNV.Text;
            ctpm.MaPM = txtMaPMM.Text;
            ctpm.MaSach = lbMaSach.Text;
            ctpm.MaSV = txtMaSVM.Text;
            ctpm.NgayMuon = dtpNgayMuonM.Text;
            ctpm.NgayTra = dtpNgayTraM.Text;
            ctpm.TienPhat = 0;
            // ctpm.SoLuong = Convert.ToInt32(txtSoLuong.Text);

            ctpmBUS.ThemPhieuMuon(ctpm);
            ctpmBUS.ThemCTPM(ctpm);
            MessageBox.Show("Thêm thành công!");
            HienThiDSPM();
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            ctpmBUS.XoaCTPM(txtMaPMT.Text, txtMaSachT.Text);
            MessageBox.Show("Trả thành công!");
            Clear();
            HienThiDSPM();
        }

        private void dgvDSMuonT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPMT.Text = Convert.ToString(dgvDSMuonT.CurrentRow.Cells["MaPMT"].Value);
            txtMaSachT.Text = Convert.ToString(dgvDSMuonT.CurrentRow.Cells["MaSachT"].Value);
            txtMaSVT.Text = Convert.ToString(dgvDSMuonT.CurrentRow.Cells["MaSVT"].Value);
            dtpNgayMuonT.Text = Convert.ToString(dgvDSMuonT.CurrentRow.Cells["NgayMuonT"].Value);
            dtpNgayHenTraT.Text = Convert.ToString(dgvDSMuonT.CurrentRow.Cells["NgayTraT"].Value);
        }

        private void btnTimKiemTra_Click(object sender, EventArgs e)
        {
            dgvDSMuonT.DataSource = ctpmBUS.TimKiemPhieuMuon(txtMaSVTK.Text);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvDSMuonT.DataSource = ctpmBUS.GetData();
            Clear();
        }

        private void dgvDSMuonT_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
          dgvDSMuonT.Rows[e.RowIndex].Cells["STTT"].Value = e.RowIndex + 1;
        }

        private void dgvMuon_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvMuon.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
    }
}
