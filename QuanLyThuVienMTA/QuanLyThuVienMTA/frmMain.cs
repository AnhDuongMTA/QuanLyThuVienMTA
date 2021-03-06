﻿using System;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmDangNhap dn = new frmDangNhap();
                dn.Show();
                this.Close();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void quảnLýMượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMuonTraSach ms = new frmMuonTraSach();
            ms.Show();
            this.Close();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmNhanVien nv = new frmNhanVien();
            nv.Show();
            this.Close();
        }

        private void quảnLýDinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmSinhVien sv = new frmSinhVien();
            sv.Show();
            this.Close();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmSach s = new frmSach();
            s.Show();
            this.Close();
        }

        private void quảnLýVịTríSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmViTri vt = new frmViTri();
            vt.Show();
            this.Close();
        }

        private int i = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbchuchay.Location = new Point(lbchuchay.Location.X - i, lbchuchay.Location.Y);

            if (lbchuchay.Location.X <= -510 || lbchuchay.Location.Y <= 0)
            {
                lbchuchay.Location = new Point(lbchuchay.Location.X + 1300, lbchuchay.Location.Y);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void toolStripQLMS_Click(object sender, EventArgs e)
        {

            frmMuonTraSach ms = new frmMuonTraSach();
            ms.Show();
            this.Close();
        }

        private void toolStripQLNV_Click(object sender, EventArgs e)
        {

            frmNhanVien nv = new frmNhanVien();
            nv.Show();
            this.Close();
        }

        private void toolStripQLSV_Click(object sender, EventArgs e)
        {

            frmSinhVien sv = new frmSinhVien();
            sv.Show();
            this.Close();
        }

        private void toolStripQLS_Click(object sender, EventArgs e)
        {


            frmSach s = new frmSach();
            s.ShowDialog();
            this.Close();
        }

        private void toolStripVTS_Click(object sender, EventArgs e)
        {

            frmViTri vt = new frmViTri();
            vt.Show();
            this.Close();
        }

        private void toolStripThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmhuongdan hd = new frmhuongdan();
            hd.Show();
        }
    }
}
