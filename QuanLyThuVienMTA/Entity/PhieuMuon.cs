using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PhieuMuon
    {
        private string _MaPhieuMuon;
        private string _MaSinhVien;
        private string _NgayMuon;
        private string _MaNhanVien;

        public string MaPhieuMuon
        {
            get
            {
                return _MaPhieuMuon;
            }

            set
            {
                _MaPhieuMuon = value;
            }
        }

        public string MaSinhVien
        {
            get
            {
                return _MaSinhVien;
            }

            set
            {
                _MaSinhVien = value;
            }
        }

        public string NgayMuon
        {
            get
            {
                return _NgayMuon;
            }

            set
            {
                _NgayMuon = value;
            }
        }

        public string MaNhanVien
        {
            get
            {
                return _MaNhanVien;
            }

            set
            {
                _MaNhanVien = value;
            }
        }
    }
}
