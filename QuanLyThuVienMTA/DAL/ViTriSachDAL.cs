using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;

namespace DAL
{
     public class ViTriSachDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("XemThongTinViTri", null);
        }
        public DataTable GetDataByID(string ID)
        {
            SqlParameter[] para = { new SqlParameter("Ma", ID) };
            return conn.GetData("TTViTri", para);
        }
        public DataTable GetDataTTSach(String ID)
        {
            SqlParameter[] para = { new SqlParameter("Ma", ID) };
            return conn.GetData("TTSach", para);
        }
        public DataTable TimKiemViTri(string strTimKiem)
        {
            return conn.GetData(strTimKiem);
        }
        public int ThemViTri(ViTriSachEntity VT)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaVT",VT.MaVT),
                new SqlParameter("TenKe",VT.TenKe),
                new SqlParameter("ViTri",VT.ViTri),
            };
            return conn.ExcuteSQL("ThemViTri", para);
        }
        public int SuaViTri(ViTriSachEntity VT)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaVT",VT.MaVT),
                new SqlParameter("TenKe",VT.TenKe),
                new SqlParameter("ViTri",VT.ViTri),
        };
            return conn.ExcuteSQL("SuaViTri ", para);
        }
        public int XoaViTri(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("Ma",ID)
        };
            return conn.ExcuteSQL("XoaViTri ", para);
        }
        public string TangMa()
        {
            return conn.TangMa("Select * From ViTriSach", "VT");
        }
    }
}
