using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ChiTietPhieuMuon
    {

        private string _MaPM;
        private string _MaSach;
        private string _NgayMuon;
        private string _NgayTra;
        private string _NgayHenTra;
        private int _TienPhat;


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

        public string NgayHenTra
        {
            get
            {
                return _NgayHenTra;
            }

            set
            {
                _NgayHenTra = value;
            }
        }
    }
}
