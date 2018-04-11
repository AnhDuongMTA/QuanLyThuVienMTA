using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class SinhVienEntity
    {
        public string MaSV { get; set; }
        public string TenSV { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SoDT { get; set; }
        public string Lop { get; set; }

        public SinhVienEntity()
        {
            MaSV = "";
            TenSV = "";
            GioiTinh = "";
            NgaySinh = DateTime.Parse("1/1/1997");
            SoDT = "";
            Lop = "";
        }
        public SinhVienEntity(string _MaSV,string _TenSV,string _GioiTinh,DateTime _NgaySinh,string _SoDT,string _Lop)
        {
            MaSV = _MaSV;
            TenSV = _TenSV;
            GioiTinh = _GioiTinh;
            NgaySinh = _NgaySinh;
            SoDT = _SoDT;
            Lop = _Lop;
        }
    }
}
