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
    public class ProviderDAL :IProviderDAL
    {
        private const string PARM_MANCC = "@MaNCC";
        private const string PARM_TENNCC = "@TenNCC";
        private const string PARM_DIACHI = "@DiaChi";
        private const string PARM_DIENTHOAI = "@DienThoai";
        private const string PARM_EMAIL = "@Email";
        private const string PARM_NGUNGHOPTAC = "@NgungHopTac";

        public int Insert(string tenncc, string diachi, string dienthoai, string email, bool ngunghoptac)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_TENNCC,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_DIACHI,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_DIENTHOAI,SqlDbType.VarChar,20),
                new SqlParameter(PARM_EMAIL,SqlDbType.VarChar,50),
                new SqlParameter(PARM_NGUNGHOPTAC,SqlDbType.Bit)
            };
            parm[0].Value = tenncc;
            parm[1].Value = diachi;
            parm[2].Value = dienthoai;
            parm[3].Value = email;
            parm[4].Value = ngunghoptac;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_Provider_Insert", parm);
        }

        public int Delete(int mancc)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MANCC,SqlDbType.Int)
            };
            parm[0].Value = mancc;

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_Providers_Del", parm);
        }

        public int Update(int mancc, string tenncc, string diachi, string dienthoai, string email, bool ngunghoptac)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MANCC,SqlDbType.Int),
                new SqlParameter(PARM_TENNCC,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_DIACHI,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_DIENTHOAI,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_EMAIL,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_NGUNGHOPTAC,SqlDbType.Bit),
            };
            parm[0].Value = mancc;
            parm[1].Value = tenncc;
            parm[2].Value = diachi;
            parm[3].Value = dienthoai;
            parm[4].Value = email;
            parm[5].Value = ngunghoptac;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_Provider_Update", parm);
        }

        public DataTable getAll()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_Provider_Sel_All", null);
            DataTable table = new DataTable();
            table.Columns.Add("MaNCC", typeof(int));
            table.Columns.Add("TenNCC", typeof(string));
            table.Columns.Add("DiaChi", typeof(string));
            table.Columns.Add("DienThoai", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("NgungHopTac", typeof(bool));
            while (dra.Read())
            {
                table.Rows.Add(int.Parse(dra["MaNCC"].ToString()), dra["TenNCC"].ToString(), dra["DiaChi"].ToString(), dra["DienThoai"].ToString(), dra["Email"].ToString(), dra["NgungHopTac"].ToString());
            }
            dra.Dispose();
            return table;
        }

        public int checkNCC_ID(int mancc)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MANCC,SqlDbType.Int)
            };
            parm[0].Value = mancc;
            return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_Provider_Check", parm);
        }

    }
}
