﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO_DingDoong;
namespace DAL_DingDoong
{
    public class DAL_ThucDon : Dbconnect
    {
        public bool ThemThucDon(DTO_ThucDon td)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Sp_InsertTD";
                cmd.Parameters.AddWithValue("tenTD", td.TenTD);
                cmd.Parameters.AddWithValue("GiaBan", td.GiaBan);
                cmd.Parameters.AddWithValue("hinhAnh", td.Hinh);
                cmd.Parameters.AddWithValue("nhom", td.Nhom);
                cmd.Parameters.AddWithValue("mota", td.MoTa);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }                
                
            }
            
            finally
            {
                _conn.Close();
            }
            return false;
        }


        public DataTable DanhSachThucDonBan()
        {
            try
            {
                _conn.Open();
                SqlCommand cm = new SqlCommand();
                cm.Connection = _conn;
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "sp_DanhSachTDBan";
                DataTable dtThucDon = new DataTable();
                dtThucDon.Load(cm.ExecuteReader());
                return dtThucDon;
            }
            finally
            {
                _conn.Close();
            }
        }
        public byte[] GetHinhTD(string MaTD)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Sp_LayHinhHangHoa";
                cmd.Parameters.AddWithValue("MaTD", MaTD);

                var hinh = (byte[])cmd.ExecuteScalar();
                return hinh;

            }

            catch
            {
                return null;
            }
            finally
            {
                _conn.Close();
            }
        }

        public DataTable dtsearchTDBan(string TenTD)
        {
            try
            {
                _conn.Open();
                SqlCommand cm = new SqlCommand();
                cm.Connection = _conn;
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "sp_searchTDBan";
                cm.Parameters.AddWithValue("TenTd", TenTD);
                DataTable dtThucDon = new DataTable();
                dtThucDon.Load(cm.ExecuteReader());
                return dtThucDon;
            }
            finally
            {
                _conn.Close();
            }
        }

        public DataTable dtsearchTDNhom(string Nhom)
        {
            try
            {
                _conn.Open();
                SqlCommand cm = new SqlCommand();
                cm.Connection = _conn;
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "sp_TDtheoNhom";
                cm.Parameters.AddWithValue("Nhom", Nhom);
                DataTable dtThucDon = new DataTable();
                dtThucDon.Load(cm.ExecuteReader());
                return dtThucDon;
            }
            finally
            {
                _conn.Close();
            }
        }

        public DataTable DanhSachThucDon()
        {
            try
            {
                _conn.Open();
                SqlCommand cm = new SqlCommand();
                cm.Connection = _conn;
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "sp_DanhSachTD";
                DataTable dtThucDon = new DataTable();
                dtThucDon.Load(cm.ExecuteReader());
                return dtThucDon;
            }
            finally
            {
                _conn.Close();
            }
        }


        //Danh Sach Thuc Don FormThucDon
        public DataTable DanhSachThucDon_1()
        {
            try
            {
                _conn.Open();
                SqlCommand cm = new SqlCommand();
                cm.Connection = _conn;
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "sp_DanhSachTD";
                DataTable dtThucDon = new DataTable();
                dtThucDon.Load(cm.ExecuteReader());
                return dtThucDon;
            }
            finally
            {
                _conn.Close();
            }
        }

        //Tim kiem mon trong thuc don
        public DataTable SearchThucDon(string tenThucDon)
        { 
            try
            {
                _conn.Open();
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "Sp_SearchTD";
                cm.Connection = _conn;
                cm.Parameters.AddWithValue("tenTD", tenThucDon);
                DataTable dtThucDon = new DataTable();
                dtThucDon.Load(cm.ExecuteReader());
                return dtThucDon;
            }
            finally
            {
                _conn.Close();
            }
        }

        //Xoa mon trong thuc don
        public bool XoaThucDon(string maTD)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Sp_DeleteTD";
                cmd.Parameters.AddWithValue("maTD",maTD);
                

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }

            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool CapNhatThucDon(string maThucDon, DTO_ThucDon td)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Sp_UpdateTD";
                cmd.Parameters.AddWithValue("maTD", maThucDon);
                cmd.Parameters.AddWithValue("tenTD", td.TenTD);
                cmd.Parameters.AddWithValue("GiaBan", td.GiaBan);
                cmd.Parameters.AddWithValue("hinhAnh", td.Hinh);
                cmd.Parameters.AddWithValue("nhom", td.Nhom);
                cmd.Parameters.AddWithValue("mota", td.MoTa);

                if(cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                _conn.Close();
            }
            return false;
        }

        //Show all danh sach thuc don
        public DataTable DanhSachThucDonAll()
        {
            try
            {
                _conn.Open();
                SqlCommand cm = new SqlCommand();
                cm.Connection = _conn;
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "Sp_DanhSachTDAll";
                DataTable dtThucDonAll = new DataTable();
                dtThucDonAll.Load(cm.ExecuteReader());
                return dtThucDonAll;
            }
            finally
            {
                _conn.Close();
            }
        }

        public bool CapNhatTrangThai(string maThucDon)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Sp_UpdateTD_Enable";
                cmd.Parameters.AddWithValue("maTD", maThucDon);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }


        



    }
}
