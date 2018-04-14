using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using System.Data;
namespace BUS
{
    public class SinhVienBUS
    {
        SinhVienDAL da = new SinhVienDAL();
        public DataTable GetData()
        {
            return da.GetData();
        }
        public string TangMa()
        {
            return da.TangMa();
        }
        public int ThemSV(SinhVienEntity sv)
        {
            return da.ThemSV(sv);
        }
        public int SuaSV(SinhVienEntity sv)
        {
            return da.SuaSV(sv);
        }
        public int XoaSV(string ID)
        {
            return da.XoaSV(ID);
        }
        public DataTable TimKiemSV(string str)
        {
            return da.TimKiemSV(str);
        }
    }
}
