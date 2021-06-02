﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_DingDoong
{
    public class DTO_HoaDon
    {
        private string _MaHD;
        private string _MaNV;
        private string _SDT;
        private int _IdBan;
       
        private float _KhuyenMai;
        private float _ThanhTien;
        private DateTime _NgayHD;
        public string MaHD
        {
            get
            {
                return _MaHD;
            }
            set
            {
                _MaHD = value;
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
        public string SDT_KH
        {
            get
            {
                return _SDT;
            }
            set
            {
                _SDT = value;
            }
        }

        public int IdBan
        {
            get
            {
                return _IdBan;
            }
            set
            {
                _IdBan = value;
            }
        }

     

        public float KhuyenMai
        {
            get
            {
                return _KhuyenMai;
            }
            set
            {
                _KhuyenMai = value;
            }
        }

        public DateTime NgayHD
        {
            get
            {
                return _NgayHD;
            }
            set
            {
                _NgayHD = value;
            }
        }

        public float ThanhTien
        {
            get
            {
                return _ThanhTien;
            }
            set
            {
                _ThanhTien = value;
            }
        }

        public DTO_HoaDon(string MaHD, string MaNV, int MaBan, float KhuyenMai, string SDT_KH = null)
        {
            this._MaHD = MaHD;
            this._MaNV = MaNV;
            this._SDT = SDT_KH;
            this._IdBan = MaBan;
            this._KhuyenMai = KhuyenMai;

        }

        public DTO_HoaDon(string MaHD, string MaNV, string SDT_KH, int MaBan)
        {
            this._MaHD = MaHD;
            this._MaNV = MaNV;
            this._SDT = SDT_KH;
            this._IdBan = MaBan;
         
            this._KhuyenMai = 0;
        }

        public DTO_HoaDon(string MaHD, int MaBan)
        {
            this._MaHD = MaHD;
            this._IdBan = MaBan;
          

        }
        public DTO_HoaDon()
        { }
    }
}
