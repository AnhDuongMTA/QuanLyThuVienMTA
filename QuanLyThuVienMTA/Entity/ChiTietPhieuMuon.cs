using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ChiTietPhieuMuon
    {
        private string _MaNV;
        private string _MaSV;
        private string _MaPM;
        private string _MaSach;
        private string _NgayMuon;
        private string _NgayTra;
       // private string _HanMuon;
        private int _TienPhat;
        private int _SoLuong;

        public string MaPM
        {
            get
            {
                return _MaPM;
            }

            set
            {
                _MaPM = value;
            }
        }

        public string MaSach
        {
            get
            {
                return _MaSach;
            }

            set
            {
                _MaSach = value;
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

        public string NgayTra
        {
            get
            {
                return _NgayTra;
            }

            set
            {
                _NgayTra = value;
            }
        }

        //public string HanMuon
        //{
        //    get
        //    {
        //        return _HanMuon;
        //    }

        //    set
        //    {
        //        _HanMuon = value;
        //    }
        //}

        public int TienPhat
        {
            get
            {
                return _TienPhat;
            }

            set
            {
                _TienPhat = value;
            }
        }

        public string MaNV
        {
            get
            {
                return _MaNV;
            }

            set
            {
                _MaNV = value;
            }
        }

        public string MaSV
        {
            get
            {
                return _MaSV;
            }

            set
            {
                _MaSV = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return _SoLuong;
            }

            set
            {
                _SoLuong = value;
            }
        }
    }
 }
