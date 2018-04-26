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
    public class PhieuMuonDAL
    {
        KetNoi _connect = new KetNoi();
        public DataTable GetData()
        {
            return _connect.GetData("SP_PhieuMuonSelectAll", null);
        }
        public int InsertData(PhieuMuon pm)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaPM",pm.MaPhieuMuon),
                new SqlParameter("MaNV",pm.MaNhanVien),
                new SqlParameter("MaSV",pm.MaSinhVien),
                new SqlParameter("NgayMuon",pm.NgayMuon)
            };
            return _connect.ExcuteSQL("SP_ThemPhieuMuon", para);
        }
        public int UpdateData(PhieuMuon pm)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaPM",pm.MaPhieuMuon),
                new SqlParameter("MaNV",pm.MaNhanVien),
                new SqlParameter("MaSV",pm.MaSinhVien),
                new SqlParameter("NgayMuon",pm.NgayMuon)
            };
            return _connect.ExcuteSQL("SP_SuaPhieuMuon", para);
        }
        public int DeleteData(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaPM",ID)
        };
            return _connect.ExcuteSQL("SP_XoaPhieuMuon", para);
        }
        public string TangMa()
        {
            return _connect.TangMa("Select * From PhieuMuonSach", "PM");
        }
    }
}
