using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_PolyCafe;
using Microsoft.Data.SqlClient;

namespace DAL_PolyCafe
{
    public class DALNhanVien
    {
        // Lây nhân viên bằng hàm Value
        public NhanVien getNhanVien(string email, string password)
        {
            string sql = "SELECT * FROM NhanVien WHERE Email=@0 AND MatKhau=@1";
            List<object> thamSo = new List<object>();
            thamSo.Add(email);
            thamSo.Add(password);
            NhanVien nv = DBUtil.Value<NhanVien>(sql, thamSo);
            return nv;
        }

        // Lây nhân viên bằng hàm Query 

        public NhanVien? getNhanVien1(string email, string password)
        {
            string sql = "SELECT Top 1 * FROM NhanVien WHERE Email=@0 AND MatKhau=@1";
            List<object> thamSo = new List<object>();
            thamSo.Add(email);
            thamSo.Add(password);
            SqlDataReader reader = DBUtil.Query(sql, thamSo);
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    NhanVien nv = new NhanVien();
                    nv.MaNhanVien = reader["MaNhanVien"].ToString();
                    nv.HoTen = reader["HoTen"].ToString();
                    nv.Email = reader["Email"].ToString();
                    nv.MatKhau = reader["MatKhau"].ToString();
                    nv.VaiTro = bool.Parse(reader["VaiTro"].ToString());
                    nv.TrangThai = bool.Parse(reader["TrangThai"].ToString());

                    return nv;
                }
            }
            return null;
        }

        
    }
}
