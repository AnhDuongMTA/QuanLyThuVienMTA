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
    public class SachDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("SP_XemThongTinSach", null);
        }
        public DataTable TimKiemSach(string strTimKiem)
        {
            return conn.GetData(strTimKiem);
        }
        public int ThemSach(Sach sach)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaSach",sach.MaSach),
                new SqlParameter("TenSach",sach.TenSach),
                new SqlParameter("TacGia",sach.TacGia),
                new SqlParameter("TheLoai",sach.TheLoai),
                new SqlParameter ("NXB",sach.NXB),
                new SqlParameter("NgonNgu",sach.NgonNgu),
                new SqlParameter("LinhVuc",sach.LinhVuc),
                new SqlParameter("NamXB",sach.NamXB),
                new SqlParameter("MaViTri",sach.MaViTri),
                new SqlParameter ("SoLuong",sach.SoLuong)
            };
            return conn.ExcuteSQL("SP_ThemSach ", para);
        }
        public int SuaSach(Sach sach)
        {
            SqlParameter[] para =
            {
                 new SqlParameter("MaSach",sach.MaSach),
                new SqlParameter("TenSach",sach.TenSach),
                new SqlParameter("TacGia",sach.TacGia),
                new SqlParameter("TheLoai",sach.TheLoai),
                new SqlParameter ("NXB",sach.NXB),
                new SqlParameter("NgonNgu",sach.NgonNgu),
                new SqlParameter("LinhVuc",sach.LinhVuc),
                new SqlParameter("NamXB",sach.NamXB),
                new SqlParameter("MaViTri",sach.MaViTri),
                new SqlParameter ("SoLuong",sach.SoLuong)
        };
            return conn.ExcuteSQL("SP_SuaSach ", para);
        }
        public int XoaSach(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaSach",ID)
        };
            return conn.ExcuteSQL("SP_XoaSach ", para);
        }
        public string TangMa()
        {
            return conn.TangMa("Select * From ChiTietSach", "MS");
        }
    }
}
