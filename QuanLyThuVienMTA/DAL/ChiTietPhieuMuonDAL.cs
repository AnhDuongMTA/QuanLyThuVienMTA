using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class ChiTietPhieuMuonDAL
    {
       
        KetNoi _connect = new KetNoi();

        public DataTable GetData()
        {
            return _connect.GetData("SP_CTPMselectAll ");
        }

        public DataTable TimKiemPhieuMuon(string MaSV)
        {
            return _connect.GetData("SELECT cm.MaPM, cm.MaSach, cm.NgayMuon,cm.NgayTra,cm.HanMuon,cm.TienPhat,pm.MaNV,pm.MaSV FROM dbo.ChiTietPhieuMuon cm, dbo.PhieuMuonSach pm WHERE cm.MaPM = pm.MaPM AND pm.MaSV = '"+MaSV+"'");
        }

        public int ThemCTPM(ChiTietPhieuMuon pm)
        {
            SqlParameter[] para =
            {
                  new SqlParameter("MaPM",pm.MaPM),
                  new SqlParameter("MaSach",pm.MaSach),
                  new SqlParameter("NgayMuon",pm.NgayMuon),
                  new SqlParameter("NgayTra",pm.NgayTra),
                  new SqlParameter("TienPhat",pm.TienPhat)
            };
            return _connect.ExcuteSQL("SP_ThemCTPM", para);

        }

        public int SuaCTPM(ChiTietPhieuMuon pm)
        {
            SqlParameter[] para =
            {
                  new SqlParameter("MaPM",pm.MaPM),
                  new SqlParameter("MaSach",pm.MaSach),
                  new SqlParameter("NgayMuon",pm.NgayMuon),                
                  new SqlParameter("NgayTra",pm.NgayTra),
                  new SqlParameter("TienPhat",pm.TienPhat)
            };
            return _connect.ExcuteSQL("SP_SuaCTPM", para);
        }

        public int XoaCTPM(string MaPM, string MaSach)
        {
            SqlParameter[] para =
            {
                  new SqlParameter("MaPM",MaPM),
                  new SqlParameter("MaSach",MaSach)
            };
            return _connect.ExcuteSQL("SP_XoaCTPM", para);
        }

        public string TangMa()
        {
            return _connect.TangMa("Select * From PhieuMuonSach", "PM");
        }
    }
}
