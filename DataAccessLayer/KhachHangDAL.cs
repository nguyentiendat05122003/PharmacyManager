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
    public class KhachHangDAL : IKhachHangDAL
    {
        private const string PARM_MANCC = "@Makh";
        private const string PARM_TENNCC = "@Tenkh";
        private const string PARM_DIACHI = "@Diachi";
        private const string PARM_DIENTHOAI = "@DienThoai";
        private const string PARM_EMAIL = "@Email";
        public int Insert(string tenkh, string diachi, string dienthoai, string email)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_TENNCC,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_DIACHI,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_DIENTHOAI,SqlDbType.VarChar,20),
                new SqlParameter(PARM_EMAIL,SqlDbType.VarChar,50),
            };
            parm[0].Value = tenkh;
            parm[1].Value = diachi;
            parm[2].Value = dienthoai;
            parm[3].Value = email;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_KhachHangs_Ins", parm);
        }

        public int Delete(int makh)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MANCC,SqlDbType.Int)
            };
            parm[0].Value = makh;

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_Khachhang_Del", parm);
        }

        public int Update(int makh, string tenkh, string diachi, string dienthoai, string email)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MANCC,SqlDbType.Int),
                new SqlParameter(PARM_TENNCC,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_DIACHI,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_DIENTHOAI,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_EMAIL,SqlDbType.NVarChar,50),
            };
            parm[0].Value = makh;
            parm[1].Value = tenkh;
            parm[2].Value = diachi;
            parm[3].Value = dienthoai;
            parm[4].Value = email;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_KhachHang_Upd", parm);
        }
        public DataTable getAll()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_KhachHang_Sel_All", null);
            DataTable table = new DataTable();
            table.Columns.Add("MaKhachHang", typeof(int));
            table.Columns.Add("HoTen", typeof(string));
            table.Columns.Add("DiaChi", typeof(string));
            table.Columns.Add("DienThoai", typeof(string));
            table.Columns.Add("Email", typeof(string));
            while (dra.Read())
            {
                table.Rows.Add(int.Parse(dra["MaKhachHang"].ToString()), dra["HoTen"].ToString(), dra["DiaChi"].ToString(), dra["DienThoai"].ToString(), dra["Email"].ToString());
            }
            dra.Dispose();
            return table;
        }

        public int checkKh_ID(int mancc)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MANCC,SqlDbType.Int)
            };
            parm[0].Value = mancc;
            return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_KhachHang_Check", parm);
        }
    }
}
