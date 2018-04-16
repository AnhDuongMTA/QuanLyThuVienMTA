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
    public class SachBUS
    {
        SachDAL da = new SachDAL();
        public DataTable GetData()
        {
            return da.GetData();
        }
        public DataTable ViTriSach(string str)
        {
            return da.ViTriSach(str);
        }
        public DataTable TimKiemSach(string strTimKiem)
        {
            return da.TimKiemSach(strTimKiem);
        }
        public int ThemSach(Sach sach)
        {
            return da.ThemSach(sach);
        }
        public int SuaSach(Sach sach)
        {
            return da.SuaSach(sach);
        }
        public int XoaSach(string ID)
        {
            return da.XoaSach(ID);
        }
        public string TangMa()
        {
            return da.TangMa();
        }

        public int CapNhatSoLuong(Sach s)
        {
            return da.CapNhatSoLuong(s);
        }
    }
}
