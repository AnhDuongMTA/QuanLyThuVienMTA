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
    public partial class frmMuonTraSach : Form
    {

        ChiTietPhieuMuon ctpm = new ChiTietPhieuMuon();
        ChiTietPhieuMuonBUS ctpmBUS = new ChiTietPhieuMuonBUS();
        SachBUS busSach = new SachBUS();
        Sach EntitySach = new Sach();
        SinhVienBUS busSinhVien = new SinhVienBUS();
        NhanVienBUS busNhanVien = new NhanVienBUS();
        PhieuMuon phieuMuon = new PhieuMuon();
        PhieuMuonBUS Bus_PhieuMuon = new PhieuMuonBUS();

        public frmMuonTraSach()
        {
            InitializeComponent();
        }

        private void KhoaDieuKhien(bool k)
        {
            btnHuy.Enabled = k;
            btnGhiNhan.Enabled = k;
            btnMuonMoi.Enabled = !k;
            txtMaPhieu_Muon.Enabled = k;
            cbMaNhanVien_Muon.Enabled = k;
            cbMaSinhVien_Muon.Enabled = k;
            dtpNgayHenTra_Muon.Enabled = k;
            dtpNgayMuon_Muon.Enabled = k;

        }
        private void KhoaTextBox_Tra()
        {
            txtMaSach_Tra.Enabled = false;
            txtMaPM_Tra.Enabled = false;
            txtMaSV_Tra.Enabled = false;
            dtpNgayHenTra_Tra.Enabled = false;
            dtpNgayMuon_Tra.Enabled = false;
        }
        private void ClearTxt()
        {
            txtMaPhieu_Muon.Text = "";
            cbMaNhanVien_Muon.Text = "";
            cbMaSinhVien_Muon.Text = "";

        }
        private void HienThiSach()
        {
            dgvListBook.DataSource = busSach.GetData();
            dgvDanhSachPhieuMuon.DataSource = ctpmBUS.GetData();
            KhoaTextBox_Tra();
        }
        private void HienThiMaNV_MaSV()
        {
            cbMaNhanVien_Muon.DataSource = busNhanVien.GetData();
            cbMaNhanVien_Muon.DisplayMember = "MaNV";
            cbMaNhanVien_Muon.ValueMember = "MaNV";
            cbMaSinhVien_Muon.DataSource = busSinhVien.GetData();
            cbMaSinhVien_Muon.DisplayMember = "MaSV";
            cbMaSinhVien_Muon.ValueMember = "MaSV";
        }


   
        private void frmMuonTraSach_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien(false);
            HienThiSach();
   
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {             
                ClearTxt();
                HienThiSach();
                KhoaDieuKhien(false);
            }
            else
                return;
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            txtMaPhieu_Muon.Text = ctpmBUS.TangMa();
            HienThiMaNV_MaSV();
            KhoaDieuKhien(true);
            txtMaPhieu_Muon.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
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
                HienThiSach();
            }
        }

        private void dgvListBook_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvListBook.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void dgvListBookSelected_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvListBookSelected.Rows[e.RowIndex].Cells["STT_Muon"].Value = e.RowIndex + 1;
        }
        
        //private void dgvListBook_SelectionChanged(object sender, EventArgs e)
        //{
        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("MaSach");
        //    dt.Columns.Add("TenSach");
        //    dt.Columns.Add("TacGia");
        //    dt.Columns.Add("TheLoai");
        //    dt.Columns.Add("NXB");
        //    dt.Columns.Add("NgonNgu");
        //    dt.Columns.Add("LinhVuc");
        //    dt.Columns.Add("NamXB");
        //    dt.Columns.Add("MaVT");

        //    for (int i = 0; i <= dgvListBook.Rows.Count - 1; i++)
        //    {


        //        bool dong_DaCo = false;
        //        DataGridViewRow row = dgvListBook.Rows[i];

        //        if ((bool)row.Cells[1].FormattedValue)
        //        {
        //            DataRow r = dt.NewRow();

        //            if (dgvListBookSelected.Rows.Count != 0)
        //            {
        //                for (int j = 0; j < dgvListBookSelected.Rows.Count; j++)
        //                {

        //                    if (dgvListBookSelected.Rows[j].Cells["MaSach_Muon"].Value == row.Cells[2].Value)
        //                    {
        //                        //MessageBox.Show("Da co");
        //                        dong_DaCo = true;
        //                        break;
        //                    }
        //                }
        //            }

        //            if (dong_DaCo == false)
        //            {

        //                r["MaSach"] = row.Cells["MaSach"].Value.ToString();
        //                r["TenSach"] = row.Cells["TenSach"].Value.ToString();
        //                r["TacGia"] = row.Cells["TacGia"].Value.ToString();
        //                r["TheLoai"] = row.Cells["TheLoai"].Value.ToString();
        //                r["NXB"] = row.Cells["NXB"].Value.ToString();
        //                r["NgonNgu"] = row.Cells["NgonNgu"].Value.ToString();
        //                r["LinhVuc"] = row.Cells["LinhVuc"].Value.ToString();
        //                r["NamXB"] = row.Cells["NamXB"].Value.ToString();
        //                r["MaVT"] = row.Cells["MaVT"].Value.ToString();
        //                dt.Rows.Add(r);
        //            }

        //            else
        //            {

        //                r["MaSach"] = row.Cells["MaSach"].Value.ToString();
        //                r["TenSach"] = row.Cells["TenSach"].Value.ToString();
        //                r["TacGia"] = row.Cells["TacGia"].Value.ToString();
        //                r["TheLoai"] = row.Cells["TheLoai"].Value.ToString();
        //                r["NXB"] = row.Cells["NXB"].Value.ToString();
        //                r["NgonNgu"] = row.Cells["NgonNgu"].Value.ToString();
        //                r["LinhVuc"] = row.Cells["LinhVuc"].Value.ToString();
        //                r["NamXB"] = row.Cells["NamXB"].Value.ToString();
        //                r["MaVT"] = row.Cells["MaVT"].Value.ToString();
        //                dt.Rows.Add(r);
        //            }

        //        }
        //        dgvListBookSelected.DataSource = dt;
        //    }
        //}

        private void btnGhiNhan_Click(object sender, EventArgs e)
        {
            phieuMuon.MaPhieuMuon = txtMaPhieu_Muon.Text;
            phieuMuon.MaSinhVien = cbMaSinhVien_Muon.Text;
            phieuMuon.MaNhanVien = cbMaNhanVien_Muon.Text;
            phieuMuon.NgayMuon = dtpNgayMuon_Muon.Text;

            Bus_PhieuMuon.InsertData(phieuMuon);
            for (int i = 0; i < dgvListBookSelected.Rows.Count - 1; i++)
            {

                ctpm.MaPM = txtMaPhieu_Muon.Text;
                ctpm.MaSach = dgvListBookSelected.Rows[i].Cells[1].Value.ToString();
                ctpm.NgayMuon = dtpNgayMuon_Muon.Text;
                ctpm.NgayHenTra = dtpNgayHenTra_Muon.Text;
                ctpm.NgayTra = dtpNgayHenTra_Muon.Text;
                ctpm.TienPhat = 0;

                ctpmBUS.ThemCTPM(ctpm);

                EntitySach.MaSach = dgvListBookSelected.Rows[i].Cells[1].Value.ToString();
                EntitySach.SoLuong = -1;

                busSach.CapNhatSoLuong(EntitySach);
            }

            ClearTxt();
            MessageBox.Show("Đã ghi nhận !");
            HienThiSach();
            KhoaDieuKhien(false);
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            if (txtMaPM_Tra.Text == "" || txtMaSach_Tra.Text == "")
            {
                MessageBox.Show("Chưa nhập thông tin đầy đủ!");

            }
            else
            {
                EntitySach.MaSach = txtMaSach_Tra.Text;
                EntitySach.SoLuong = 1;

                busSach.CapNhatSoLuong(EntitySach);

                ctpmBUS.XoaCTPM(txtMaPM_Tra.Text, txtMaSach_Tra.Text);
                Bus_PhieuMuon.DeleteData(txtMaPM_Tra.Text);
                MessageBox.Show("Trả thành công!");
                ClearTxtTra();
                HienThiSach();
            }
        }

        private void ClearTxtTra()
        {
            txtMaPM_Tra.Text = "";
            txtMaSach_Tra.Text = "";
            txtMaSVTK.Text = "";
            txtMaSV_Tra.Text = "";
            HienThiSach();
        }
        private void btnLamMoi_tra_Click(object sender, EventArgs e)
        {
            ClearTxtTra();
        }

        private void btnThoat_Tra_Click(object sender, EventArgs e)
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
                ClearTxtTra();
            }
        }

        private void btnTimKiem_Tra_Click(object sender, EventArgs e)
        {
            if (txtMaSVTK.Text == "")
            {
                MessageBox.Show("Chưa nhập mã sinh viên cần tìm kiếm!");

            }
            else
            dgvDanhSachPhieuMuon.DataSource = ctpmBUS.TimKiemPhieuMuon(txtMaSVTK.Text);
        }

        private void dgvDanhSachPhieuMuon_Click(object sender, EventArgs e)
        {
            txtMaPM_Tra.Text = Convert.ToString(dgvDanhSachPhieuMuon.CurrentRow.Cells["MaPM"].Value);
            txtMaSach_Tra.Text = Convert.ToString(dgvDanhSachPhieuMuon.CurrentRow.Cells["MaSach_Tra"].Value);
            txtMaSV_Tra.Text = Convert.ToString(dgvDanhSachPhieuMuon.CurrentRow.Cells["MaSV"].Value);
            dtpNgayMuon_Tra.Text = Convert.ToString(dgvDanhSachPhieuMuon.CurrentRow.Cells["NgayMuon_Tra"].Value);
            dtpNgayHenTra_Tra.Text = Convert.ToString(dgvDanhSachPhieuMuon.CurrentRow.Cells["NgayHenTra_Tra"].Value);
        }

        private void dgvDanhSachPhieuMuon_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvDanhSachPhieuMuon.Rows[e.RowIndex].Cells["STTT"].Value = e.RowIndex + 1;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnLayDS_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaSach");
            dt.Columns.Add("TenSach");
            dt.Columns.Add("TacGia");
            dt.Columns.Add("TheLoai");
            dt.Columns.Add("NXB");
            dt.Columns.Add("NgonNgu");
            dt.Columns.Add("LinhVuc");
            dt.Columns.Add("NamXB");
            dt.Columns.Add("MaVT");

            for (int i = 0; i <= dgvListBook.Rows.Count - 1; i++)
            {
                bool dong_DaCo = false;
                DataGridViewRow row = dgvListBook.Rows[i];

                if ((bool)row.Cells[1].FormattedValue)
                {
                    DataRow r = dt.NewRow();

                    if (dgvListBookSelected.Rows.Count != 0)
                    {
                        for (int j = 0; j < dgvListBookSelected.Rows.Count; j++)
                        {

                            if (dgvListBookSelected.Rows[j].Cells["MaSach_Muon"].Value == row.Cells[2].Value)
                            {
                               
                                dong_DaCo = true;
                                break;
                            }
                        }
                    }

                    if (dong_DaCo == false)
                    {

                        r["MaSach"] = row.Cells["MaSach"].Value.ToString();
                        r["TenSach"] = row.Cells["TenSach"].Value.ToString();
                        r["TacGia"] = row.Cells["TacGia"].Value.ToString();
                        r["TheLoai"] = row.Cells["TheLoai"].Value.ToString();
                        r["NXB"] = row.Cells["NXB"].Value.ToString();
                        r["NgonNgu"] = row.Cells["NgonNgu"].Value.ToString();
                        r["LinhVuc"] = row.Cells["LinhVuc"].Value.ToString();
                        r["NamXB"] = row.Cells["NamXB"].Value.ToString();
                        r["MaVT"] = row.Cells["MaVT"].Value.ToString();
                        dt.Rows.Add(r);
                    }

                    else
                    {

                        r["MaSach"] = row.Cells["MaSach"].Value.ToString();
                        r["TenSach"] = row.Cells["TenSach"].Value.ToString();
                        r["TacGia"] = row.Cells["TacGia"].Value.ToString();
                        r["TheLoai"] = row.Cells["TheLoai"].Value.ToString();
                        r["NXB"] = row.Cells["NXB"].Value.ToString();
                        r["NgonNgu"] = row.Cells["NgonNgu"].Value.ToString();
                        r["LinhVuc"] = row.Cells["LinhVuc"].Value.ToString();
                        r["NamXB"] = row.Cells["NamXB"].Value.ToString();
                        r["MaVT"] = row.Cells["MaVT"].Value.ToString();
                        dt.Rows.Add(r);
                    }

                }

            }
            dgvListBookSelected.DataSource = dt;
        }
    }
}

