﻿using DataAccessLayer.Interface;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class NhanVienDAL : INhanVienDAL
    {
        private const string PARM_NHANVIENID = "@MaNhanVien";
        private const string PARM_VAITRO = "@MaLoai";
        private const string PARM_HOTEN = "@HoTen";
        private const string PARM_DIACHI = "@DiaChi";
        private const string PARM_DIENTHOAI = "@DienThoai";
        private const string PARM_EMAIL = "@Email";
        private const string PARM_NGAYSINH = "@NgaySinh";
        private const string PARM_GIOITINH = "@GioiTinh";
        public int Insert(int vaitro, string hoten, bool gioitinh, DateTime ngaysinh, string diachi, string dienthoai, string email)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_VAITRO,SqlDbType.Int),
                new SqlParameter(PARM_HOTEN,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_GIOITINH,SqlDbType.Bit),  
                new SqlParameter(PARM_NGAYSINH,SqlDbType.DateTime),
                new SqlParameter(PARM_DIACHI,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_DIENTHOAI,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_EMAIL,SqlDbType.NVarChar,50),
            };
            parm[0].Value = vaitro;
            parm[1].Value = hoten;
            parm[2].Value = gioitinh;
            parm[3].Value = ngaysinh;
            parm[4].Value = diachi;
            parm[5].Value = dienthoai;
            parm[6].Value = email;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_NhanVien_Ins", parm);
        }
        public int Insert(NhanVien nv)
        {
            SqlParameter[] parm = new SqlParameter[]
           {
                new SqlParameter(PARM_VAITRO,SqlDbType.Int),
                new SqlParameter(PARM_HOTEN,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_GIOITINH,SqlDbType.Bit),
                new SqlParameter(PARM_NGAYSINH,SqlDbType.DateTime),
                new SqlParameter(PARM_DIACHI,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_DIENTHOAI,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_EMAIL,SqlDbType.NVarChar,50),
           };
            if (string.IsNullOrEmpty(nv.VaiTro.ToString()))
                parm[0].Value = DBNull.Value;
            else
                parm[0].Value = nv.VaiTro;

            if (nv.Hoten == null)
                parm[1].Value = DBNull.Value;
            else
                parm[1].Value = nv.Hoten;

            if (string.IsNullOrEmpty(nv.Gioitinh.ToString()))
                parm[2].Value = DBNull.Value;
            else
                parm[2].Value = nv.Gioitinh;


            if (string.IsNullOrEmpty(nv.Ngaysinh.ToString()))
                parm[3].Value = DBNull.Value;
            else
                parm[3].Value = nv.Ngaysinh;

            if (string.IsNullOrEmpty(nv.Diachi))
                parm[4].Value = DBNull.Value;
            else
                parm[4].Value = nv.Diachi;

            if (string.IsNullOrEmpty(nv.Dienthoai))
                parm[5].Value = DBNull.Value;
            else
                parm[5].Value = nv.Dienthoai;
            if (string.IsNullOrEmpty(nv.Email))
                parm[6].Value = DBNull.Value;
            else
                parm[6].Value = nv.Email;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "[tbl_NhanVien_Ins]", parm);
        }
        public DataTable getAll()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_NhanVien_Sel_All", null);
            DataTable table = new DataTable();
            table.Columns.Add("MaNhanVien", typeof(int));
            table.Columns.Add("MaLoai", typeof(int));
            table.Columns.Add("Hoten", typeof(string));
            table.Columns.Add("GioiTinh", typeof(Boolean));
            table.Columns.Add("NgaySinh", typeof(DateTime));
            table.Columns.Add("DiaChi", typeof(string));
            table.Columns.Add("DienThoai", typeof(string));
            table.Columns.Add("Email", typeof(string));
            while (dra.Read())
            {
                table.Rows.Add(int.Parse(dra["MaNhanVien"].ToString()), int.Parse(dra["MaLoai"].ToString()), dra["HoTen"].ToString(), dra["GioiTinh"].ToString(), dra["NgaySinh"].ToString(), dra["DiaChi"].ToString(), dra["DienThoai"].ToString(), dra["Email"].ToString());
            }
            dra.Dispose();
            Console.WriteLine(table);
            return table;
        }
        public int Delete(int NhanVienID)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_NHANVIENID,SqlDbType.Int)
            };
            parm[0].Value = NhanVienID;
            Console.WriteLine(NhanVienID);

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_NhanViesn_Del", parm);
        }
        public int checkNhanVien_ID(int nhanvienID)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_NHANVIENID,SqlDbType.Int)
            };
            parm[0].Value = nhanvienID;
            return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_NhanViens_Check", parm);
        }
        public int Update(int nhanvienID, int vaitro, string hoten, bool gioitinh, DateTime ngaysinh, string diachi, string dienthoai, string email)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_NHANVIENID,SqlDbType.Int),
                new SqlParameter(PARM_VAITRO,SqlDbType.Int),
                new SqlParameter(PARM_HOTEN,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_GIOITINH,SqlDbType.Bit),
                new SqlParameter(PARM_NGAYSINH,SqlDbType.DateTime),
                new SqlParameter(PARM_DIACHI,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_DIENTHOAI,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_EMAIL,SqlDbType.NVarChar,50),

            };
            parm[0].Value = nhanvienID;
            parm[1].Value = vaitro;
            parm[2].Value = hoten;
            parm[3].Value = gioitinh;
            parm[4].Value = ngaysinh;
            parm[5].Value = diachi;
            parm[6].Value = dienthoai;
            parm[7].Value = email;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_NhanVien_Upd", parm);
        }
    }
}
