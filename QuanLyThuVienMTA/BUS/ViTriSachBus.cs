using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;
using DAL;

namespace BUS
{
    public class ViTriSachBus
    {
        ViTriSachDAL da = new ViTriSachDAL();

        public DataTable GetData()
        {
            return da.GetData();
        }
        public DataTable TimKiemViTri(string strTimKiem)
        {
            return da.TimKiemViTri(strTimKiem);
        }
        public int ThemViTri(ViTriSachEntity VT)
        {
            return da.ThemViTri(VT);
        }
        public int SuaViTri(ViTriSachEntity VT)
        {
            return da.SuaViTri(VT);
        }
        public int XoaViTri(string ID)
        {
            return da.XoaViTri(ID);
        }
        public string TangMa()
        {
            return da.TangMa();
        }
        public DataTable GetDataByID(string Ma)
        {
            return da.GetDataByID(Ma);
        }
        public DataTable GetDataTTSach(string Ma)
        {
            return da.GetDataTTSach(Ma);
        }
    }
}
