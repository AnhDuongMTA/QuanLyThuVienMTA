using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhieuMuonBUS
    {
        PhieuMuonDAL dal = new PhieuMuonDAL();
        public DataTable GetData()
        {
            return dal.GetData();
        }
        public int InsertData(PhieuMuon pm)
        {
            return dal.InsertData(pm);
        }
        public int UpdateData(PhieuMuon pm)
        {
            return dal.UpdateData(pm);
        }
        public int DeleteData(string ID)
        {
            return dal.DeleteData(ID);
        }
        public string TangMa()
        {
            return dal.TangMa();
        }
    }
}
