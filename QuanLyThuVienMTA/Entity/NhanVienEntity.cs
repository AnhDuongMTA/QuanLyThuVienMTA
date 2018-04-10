using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class NhanVienEntity
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DienThoai { get; set; }

        public NhanVienEntity()
        {
            MaNV = "";
            TenNV = "";
            GioiTinh = "";
            NgaySinh = DateTime.Parse("1/1/1997");
            DienThoai = "";
        }
        public NhanVienEntity(string _MaNV, string _TenNV, string _GT, DateTime _NgaySinh, string _DienThoai)
        {
            MaNV = _MaNV;
            TenNV = _TenNV;
            GioiTinh = _GT;
            NgaySinh = _NgaySinh;
            DienThoai = _DienThoai;

        }
    }
}
