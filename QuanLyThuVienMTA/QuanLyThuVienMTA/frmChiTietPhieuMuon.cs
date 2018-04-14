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
        NhanVienBUS nvBUS = new NhanVienBUS();

        public frmChiTietPhieuMuon()
        {
            InitializeComponent();
        }

        public void HienThiDSPM()
        {
            dgvMuon.DataSource =  ctpmBUS.GetData();
            dgvDSMuon1.DataSource = ctpmBUS.GetData();
            ShowTenSach();
            ShowMaNV();
        }

        public void ShowMaNV()
        {
            DataTable dt = new DataTable();
            dt = nvBUS.GetData();
            cbMaNV0.DataSource = dt.Copy();
            cbMaNV0.DisplayMember = "MaNV";
            cbMaNV0.ValueMember = "MaNV";

        }
        public void Clear()
        {
            txtMaSach1.Text = "";
            txtMaPM1.Text = "";
            txtMaSV1.Text = "";
            dtpNgayHenTra1.Text = "";
            dtpNgayMuon1.Text = "";
            //txtSoLuongTra.Text = "";

        }

        public void ShowTenSach()
        {
            DataTable dt = new DataTable();
            dt = SachBUS.GetData();
            cbTenSach0 .DataSource = dt.Copy();
            cbTenSach0.DisplayMember = "TenSach";
            cbTenSach0.ValueMember = "TenSach";

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

                frmMain main = new frmMain();
                main.Show();
                this.Close();
            }
            else
            {
                HienThiDSPM();
            }
        }

        private void cbTenSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView d = (DataRowView)cbTenSach0.SelectedItem;

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
            if (cbMaNV0.Text==""|| txtMaPM0.Text=="")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin!");
            }
            else {
                ctpm.MaNV = cbMaNV0.Text;
                ctpm.MaPM = txtMaPM0.Text;
                ctpm.MaSach = lbMaSach.Text;
                ctpm.MaSV = txtMaSV0.Text;
                ctpm.NgayMuon = dtpNgayMuon0.Text;
                ctpm.NgayTra = dtpNgayTra0.Text;
                ctpm.TienPhat = 0;

                // ctpm.SoLuong = Convert.ToInt32(txtSoLuong.Text);

                ctpmBUS.ThemPhieuMuon(ctpm);
                ctpmBUS.ThemCTPM(ctpm);
                MessageBox.Show("Thêm thành công!");
                HienThiDSPM();
            }
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            if (txtMaPM1.Text=="" || txtMaSach1.Text=="")
            {
                MessageBox.Show("Chưa nhập thông tin đầy đủ!");

            }
            else{
                ctpmBUS.XoaCTPM(txtMaPM1.Text, txtMaSach1.Text);
                ctpmBUS.XoaPhieuMuon(txtMaPM1.Text);
                MessageBox.Show("Trả thành công!");
                Clear();
                HienThiDSPM();
            }
        }

        private void dgvDSMuonT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPM1.Text = Convert.ToString(dgvDSMuon1.CurrentRow.Cells["MaPMT"].Value);
            txtMaSach1.Text = Convert.ToString(dgvDSMuon1.CurrentRow.Cells["MaSachT"].Value);
            txtMaSV1.Text = Convert.ToString(dgvDSMuon1.CurrentRow.Cells["MaSVT"].Value);
            dtpNgayMuon1.Text = Convert.ToString(dgvDSMuon1.CurrentRow.Cells["NgayMuonT"].Value);
            dtpNgayHenTra1.Text = Convert.ToString(dgvDSMuon1.CurrentRow.Cells["NgayTraT"].Value);
        }

        private void btnTimKiemTra_Click(object sender, EventArgs e)
        {
            if(txtMaSVTK.Text=="")
            {
                MessageBox.Show("Chưa nhập Mã sinh viên cần tìm kiếm!");

            }
            else
            dgvDSMuon1.DataSource = ctpmBUS.TimKiemPhieuMuon(txtMaSVTK.Text);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvDSMuon1.DataSource = ctpmBUS.GetData();
            Clear();
        }

        private void dgvDSMuonT_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
          dgvDSMuon1.Rows[e.RowIndex].Cells["STTT"].Value = e.RowIndex + 1;
        }

        private void dgvMuon_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvMuon.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
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
                HienThiDSPM();
            }
        }
    }
}
