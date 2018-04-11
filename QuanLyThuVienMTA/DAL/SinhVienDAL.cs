using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entity;
namespace DAL
{
    public class SinhVienDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("Xem_SV", null);
        }
        public int ThemSV(SinhVienEntity sv)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaSV",sv.MaSV),
                new SqlParameter("TenSV",sv.TenSV),
                new SqlParameter("GioiTinh",sv.GioiTinh),
                new SqlParameter("NgaySinh",sv.NgaySinh),
                new SqlParameter("SDT",sv.SoDT),
                new SqlParameter("Lop",sv.Lop)
            };
            return conn.ExcuteSQL("Them_SV", para);
        }
        public int SuaSV(SinhVienEntity sv)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaSV",sv.MaSV),
                new SqlParameter("TenSV",sv.TenSV),
                new SqlParameter("GioiTinh",sv.GioiTinh),
                new SqlParameter("NgaySinh",sv.NgaySinh),
                new SqlParameter("SDT",sv.SoDT),
                new SqlParameter("Lop",sv.Lop)
            };
            return conn.ExcuteSQL("Sua_SV", para);
        }
        public int XoaSV(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaSV",ID)
            };
            return conn.ExcuteSQL("Xoa_SV", para);
        }
       // public string TangMa()
        //{
          //  return conn.TangMa("SELECT * FROM SinhVien", "SV");
        //}
        public DataTable TimKiemSV(string str)
        {
            return conn.GetData(str);
        }
    }
}
