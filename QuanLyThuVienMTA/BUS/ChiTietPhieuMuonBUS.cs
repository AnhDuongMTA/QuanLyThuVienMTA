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
    public class ChiTietPhieuMuonBUS
    {
        ChiTietPhieuMuonDAL dal = new ChiTietPhieuMuonDAL();

        public DataTable GetData()
        {
            return dal.GetData();
        }

        public DataTable TimKiemPhieuMuon(string MaSV)
        {
            return dal.TimKiemPhieuMuon(MaSV);
        }
        public string TangMa()
        {
            return dal.TangMa();
        }
        public int ThemCTPM(ChiTietPhieuMuon pm)
        {
            return dal.ThemCTPM(pm);
        }

        public int SuaCTPM(ChiTietPhieuMuon pm)
        {
            return dal.SuaCTPM(pm);

        }
        public int XoaCTPM(string MaPM,string MaSach)
        {
            return dal.XoaCTPM(MaPM,MaSach);
        }
    }
}
