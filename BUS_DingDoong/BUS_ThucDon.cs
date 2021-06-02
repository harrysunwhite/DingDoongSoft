﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DingDoong;
using DTO_DingDoong;
namespace BUS_DingDoong
{
    public class BUS_ThucDon
    {
        DAL_ThucDon dalThucDon = new DAL_ThucDon();

        public bool insertThucDon(DTO_ThucDon td)
        {
            return dalThucDon.ThemThucDon(td);
        }

        public byte[] getHinhTD(string MaTD)
        {
            return dalThucDon.GetHinhTD(MaTD);
        }

        public DataTable DanhSachThucDonBan()
        {
            return dalThucDon.DanhSachThucDonBan();
        }
        public DataTable DanhSachThucDon()
        {
            return dalThucDon.DanhSachThucDon();
        }

        public DataTable DanhSachThucDon_1()
        {
            return dalThucDon.DanhSachThucDon_1();
        }

        public DTO_ThucDon curTD(string TenTD)
        {
            DTO_ThucDon curTD = (from DataRow dr in dalThucDon.DanhSachThucDonAll().Rows
                                 //where string.Compare(dr[1].ToString(), TenTD, true) == 0
                                 where TenTD.Contains(dr[1].ToString())
                                 select new DTO_ThucDon
                                 {
                                     MaTD = dr[0].ToString(),
                                     TenTD = dr[1].ToString(),
                                     GiaBan = float.Parse(dr[2].ToString()),

                                     Nhom = dr[3].ToString(),
                                     MoTa = dr[4].ToString(),
                                     TrangThai = string.Compare(dr[5].ToString(),"Enable", true) == 0 ? 1 : 0



                                 }).FirstOrDefault();
            return curTD;

        }

        public DataTable TimKiemThucDon(string tenTD)
        {
            return dalThucDon.SearchThucDon(tenTD);
        }
        public DataTable dtsearchTDBan(string TenTD)
        {
            return dalThucDon.dtsearchTDBan(TenTD);
        }
        public bool XoaThucDon(string maTD)
        {
            return dalThucDon.XoaThucDon(maTD);
        }

        public bool CapNhatThucDon(string maTD,DTO_ThucDon td)
        {
            return dalThucDon.CapNhatThucDon(maTD,td);
        }

        public DataTable DanhSachThucDonAll()
        {
            return dalThucDon.DanhSachThucDonAll();
        }
        public DataTable dtsearchTDNhom(string Nhom)
        {
            return dalThucDon.dtsearchTDNhom(Nhom);
        }
        public bool CapNhatTrangThaiTD(string matd)
        {
            return dalThucDon.CapNhatTrangThai(matd);
        }
    }
}
