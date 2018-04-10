using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVienDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("NV_SelectAll", null);
        }
        public int InsertData(NhanVienEntity NV)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaNV",NV.MaNV),
                new SqlParameter("TenNV",NV.TenNV),                
                new SqlParameter("GioiTinh",NV.GioiTinh),
                new SqlParameter("NgaySinh",NV.NgaySinh),
                new SqlParameter("DienThoai",NV.DienThoai)
            };
            return conn.ExcuteSQL("ThemNV", para);
        }
        public int UpdateData(NhanVienEntity NV)
        {
            SqlParameter[] para =
            {
               new SqlParameter("MaNV",NV.MaNV),
                new SqlParameter("TenNV",NV.TenNV),
                new SqlParameter("GioiTinh",NV.GioiTinh),
                new SqlParameter("NgaySinh",NV.NgaySinh),
                new SqlParameter("DienThoai",NV.DienThoai)
        };
            return conn.ExcuteSQL("SuaNV ", para);
        }
        public int DeleteData(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaNV",ID)
        };
            return conn.ExcuteSQL("XoaNV", para);
        }
        public string TangMa()
        {
            return conn.TangMa("Select * From NhanVien", "NV");
        }
        public static List<NhanVienEntity> TimKiem(int type, string TuKhoa)
        {
            string query = "";
            KetNoi conn = new KetNoi();
            switch (type)
            {
                case 0:
                    query = string.Format("SELECT * FROM dbo.NhanVien WHERE MaNV LIKE '%{0}%'", TuKhoa);
                    return Helper.ToListof<NhanVienEntity>(conn.GetData(query));
                case 1:

                    query = string.Format("SELECT * FROM dbo.NhanVien WHERE TenNV LIKE N'%{0}%'", TuKhoa);
                    return Helper.ToListof<NhanVienEntity>(conn.GetData(query));
                case 2:
                    query = string.Format(" SELECT * FROM dbo.NhanVien NV WHERE GioiTinh LIKE N'%{0}%'", TuKhoa);
                    return Helper.ToListof<NhanVienEntity>(conn.GetData(query));
                case 3:
                    query = string.Format("SELECT * FROM dbo.NhanVien WHERE NgaySinh LIKE '%{0}%'", TuKhoa);
                    return Helper.ToListof<NhanVienEntity>(conn.GetData(query));
                case 4:
                    query = string.Format("SELECT * FROM dbo.NhanVien WHERE DienThoai LIKE '%{0}%'", TuKhoa);
                    return Helper.ToListof<NhanVienEntity>(conn.GetData(query));
            }
            return Helper.ToListof<NhanVienEntity>(conn.GetData(" SELECT * from NhanVien "));
        }
    }
}
