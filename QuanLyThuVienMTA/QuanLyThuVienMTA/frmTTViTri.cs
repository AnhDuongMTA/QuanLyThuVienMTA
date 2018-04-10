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
    public partial class frmTTViTri : Form
    {
        ViTriSachBus bus = new ViTriSachBus();
        public frmTTViTri()
        {
            InitializeComponent();
        }
        private void frmTTViTri_Load(object sender, EventArgs e)
        {
            dgvTTViTri.DataSource = bus.GetDataByID(frmViTri.Ma);
        }
    }
}
