using DataAccessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TaiKhoanDAL : ITaiKhoanDAL
    {
        private const string PARM_MATK = "@MaTK";
        private const string PARM_TENTK = "@TenTaiKhoan";
        private const string PARM_MATKHAU = "@MatKhau";
        private const string PARM_MANV = "@MaNhanVien";             
        public int Insert(string tentaikhoan, string matkhau, int manhanvien)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_TENTK,SqlDbType.VarChar,50),
                new SqlParameter(PARM_MATKHAU,SqlDbType.VarChar,100),
                new SqlParameter(PARM_MANV,SqlDbType.Int),
            };
            parm[0].Value = tentaikhoan;
            parm[1].Value = matkhau;
            parm[2].Value = manhanvien;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_TaiKhoan_Ins", parm);
        }
        public int Delete(int matk)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MATK,SqlDbType.Int)
            };
            parm[0].Value = matk;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_TaiKhoan_Del", parm);
        }
       
        public int Update(int matk, string tentaikhoan, string matkhau, int manhanvien)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MATK,SqlDbType.Int),
                new SqlParameter(PARM_TENTK,SqlDbType.Int),
                new SqlParameter(PARM_MATKHAU,SqlDbType.VarChar,20),
                new SqlParameter(PARM_MANV,SqlDbType.Int),
            };
            parm[0].Value = matk;
            parm[1].Value = tentaikhoan;
            parm[2].Value = matkhau;
            parm[3].Value = manhanvien;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_TaiKhoan_Upd", parm);
        }     
        public DataTable getAll()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_TaiKhoan_Sel_All", null);
            DataTable table = new DataTable();
            table.Columns.Add("MaTK", typeof(int));
            table.Columns.Add("TenTaiKhoan", typeof(string));
            table.Columns.Add("MatKhau", typeof(string));
            table.Columns.Add("MaNhanVien", typeof(int));
            while (dra.Read())
            {
                table.Rows.Add(int.Parse(dra["MaTK"].ToString()), dra["TenTaiKhoan"].ToString(), dra["MatKhau"].ToString(), dra["MaNhanVien"].ToString());
            }
            dra.Dispose();
            return table;
        }              
        public int checkTaiKhoan_ID(int matk)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MATK,SqlDbType.Int)
            };
            parm[0].Value = matk;
            return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_TaiKhoan_Check", parm);
        }
    }
}
