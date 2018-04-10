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

namespace QuanLyThuVienMTA
{
    public partial class frmDSSach : Form
    {
        ViTriSachBus bus = new ViTriSachBus();
        public frmDSSach()
        {
            InitializeComponent();
        }

        private void frmDSSach_Load(object sender, EventArgs e)
        {
            dgvDSSach.DataSource = bus.GetDataTTSach(frmViTri.Ma);
        }
    }
}
