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
        SachBUS busSach = new SachBUS();
        Sach EntitySach = new Sach();
        SinhVienBUS busSinhVien = new SinhVienBUS();
        NhanVienBUS busNhanVien = new NhanVienBUS();



        public frmChiTietPhieuMuon()
        {
            InitializeComponent();
        }

        public void HienThiDSPM()
        {
            txtMaPM_Muon.Text = ctpmBUS.TangMa();
            dgvMuon.DataSource =  ctpmBUS.GetData();
            dgvDSMuon_Tra.DataSource = ctpmBUS.GetData();
            ShowTenSach();
            ShowMaNV_MaSV();
        }

        public void ShowMaNV_MaSV()
        {
 
            cbMaNV_Muon.DataSource = busNhanVien.GetData();
            cbMaNV_Muon.DisplayMember = "MaNV";
            //cbMaNV_Muon.ValueMember = "MaNV";

            cbMaSV_muon.DataSource = busSinhVien.GetData();
            cbMaSV_muon.DisplayMember = "MaSV";

        }
        public void ClearTxtTra()
        {
            txtMaSach_Tra.Text = "";
            txtMaPM_Tra.Text = "";
            txtMaSV_Tra.Text = "";
            dtpNgayHenTra_Tra.Text = "";
            dtpNgayMuon_Tra.Text = "";
            

        }
        public void ClearTxtMuon()
        {
            txtMaPM_Muon.Text = "";
            cbMaSV_muon.Text = "";
           // txtMaSVTK.Text = "";
            dtpNgayTra_Muon.Text = "";
            dtpNgayMuon_Muon.Text = "";
           

        }

        public void ShowTenSach()
        {
            DataTable dt = new DataTable();
            dt = busSach.GetData();
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
            if (cbMaNV_Muon.Text==""|| txtMaPM_Muon.Text=="")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin!");
            }
            else {
                ctpm.MaNV = cbMaNV_Muon.Text;
                ctpm.MaPM = txtMaPM_Muon.Text;
                ctpm.MaSach = lbMaSach.Text;
                ctpm.MaSV = cbMaSV_muon.Text;
                ctpm.NgayMuon = dtpNgayMuon_Muon.Text;
                ctpm.NgayTra = dtpNgayTra_Muon.Text;
                ctpm.TienPhat = 0;

                EntitySach.MaSach = lbMaSach.Text;
                EntitySach.SoLuong = -1;

                busSach.CapNhatSoLuong(EntitySach);

                ctpmBUS.ThemPhieuMuon(ctpm);
                ctpmBUS.ThemCTPM(ctpm);
                MessageBox.Show("Thêm thành công!");
                ClearTxtMuon();
                HienThiDSPM();
            }
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            if (txtMaPM_Tra.Text=="" || txtMaSach_Tra.Text=="")
            {
                MessageBox.Show("Chưa nhập thông tin đầy đủ!");

            }
            else{
                EntitySach.MaSach = txtMaSach_Tra.Text;
                EntitySach.SoLuong = 1;

                busSach.CapNhatSoLuong(EntitySach);

                ctpmBUS.XoaCTPM(txtMaPM_Tra.Text, txtMaSach_Tra.Text);
                ctpmBUS.XoaPhieuMuon(txtMaPM_Tra.Text);
                MessageBox.Show("Trả thành công!");
                ClearTxtTra();
                HienThiDSPM();
            }
        }

        private void dgvDSMuonT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPM_Tra.Text = Convert.ToString(dgvDSMuon_Tra.CurrentRow.Cells["MaPMT"].Value);
            txtMaSach_Tra.Text = Convert.ToString(dgvDSMuon_Tra.CurrentRow.Cells["MaSachT"].Value);
            txtMaSV_Tra.Text = Convert.ToString(dgvDSMuon_Tra.CurrentRow.Cells["MaSVT"].Value);
            dtpNgayMuon_Tra.Text = Convert.ToString(dgvDSMuon_Tra.CurrentRow.Cells["NgayMuonT"].Value);
            dtpNgayHenTra_Tra.Text = Convert.ToString(dgvDSMuon_Tra.CurrentRow.Cells["NgayTraT"].Value);
        }

        private void btnTimKiemTra_Click(object sender, EventArgs e)
        {
            if(txtMaSVTK.Text=="")
            {
                MessageBox.Show("Chưa nhập Mã sinh viên cần tìm kiếm!");

            }
            else
            dgvDSMuon_Tra.DataSource = ctpmBUS.TimKiemPhieuMuon(txtMaSVTK.Text);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvDSMuon_Tra.DataSource = ctpmBUS.GetData();
            ClearTxtTra();
        }

        private void dgvDSMuonT_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
          dgvDSMuon_Tra.Rows[e.RowIndex].Cells["STTT"].Value = e.RowIndex + 1;
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

        private void gbThongTinSach_Enter(object sender, EventArgs e)
        {

        }
    }
}
