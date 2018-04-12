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
    public class NguoiDungBUS
    {
        NguoiDungDAL nddal = new NguoiDungDAL();
        public DataTable DangNhap(string TaiKhoan, string MatKhau)
        {
            return nddal.GetUser(TaiKhoan, MatKhau);
        }
    }
}
