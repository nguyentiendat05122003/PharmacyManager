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
    public class ProductDAL : IProductDAL
    {
        private const string PARM_MATHUOC = "@MaThuoc";
        private const string PARM_TENTHUOC = "@TenThuoc";
        private const string PARM_GIABAN = "@GiaBan";
        private const string PARM_HANSUDUNG = "@HanSuDung";
        private const string PARM_MANCC = "@MaNCC";
        private const string PARM_MADONVITINH = "@MaDonViTinh";

        public int Insert(string tenthuoc, float giaban, DateTime hansudung, int mancc, int madonvitinh)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_TENTHUOC,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_GIABAN,SqlDbType.Float),
                new SqlParameter(PARM_HANSUDUNG,SqlDbType.DateTime),
                new SqlParameter(PARM_MANCC,SqlDbType.Int),
                new SqlParameter(PARM_MADONVITINH,SqlDbType.Int),
            };
            parm[0].Value = tenthuoc;
            parm[1].Value = giaban;
            parm[2].Value = hansudung;
            parm[3].Value = mancc;
            parm[4].Value = madonvitinh;

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_Product_Ins", parm);
        }
        public int Delete(int mathuoc)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MATHUOC,SqlDbType.Int)
            };
            parm[0].Value = mathuoc;

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_Product_Del", parm);
        }
       
        public int Update(int mathuoc, string tenthuoc, float giaban, DateTime hansudung, int mancc, int madonvitinh)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MATHUOC,SqlDbType.Int),
                new SqlParameter(PARM_TENTHUOC,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_GIABAN,SqlDbType.Float),
                new SqlParameter(PARM_HANSUDUNG,SqlDbType.DateTime),
                new SqlParameter(PARM_MANCC,SqlDbType.Int),
                new SqlParameter(PARM_MADONVITINH,SqlDbType.Int),

            };
            parm[0].Value = mathuoc;
            parm[1].Value = tenthuoc;
            parm[2].Value = giaban;
            parm[3].Value = hansudung;
            parm[4].Value = mancc;
            parm[5].Value = madonvitinh;

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_Product_Upd", parm);
        }
     
        public DataTable getAll()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_Product_Sel_All", null);
            DataTable table = new DataTable();
            table.Columns.Add("MaThuoc", typeof(int));
            table.Columns.Add("TenThuoc", typeof(string));
            table.Columns.Add("GiaBan", typeof(float));
            table.Columns.Add("HanSuDung", typeof(DateTime));
            table.Columns.Add("MaNCC", typeof(int));
            table.Columns.Add("MaDonViTinh", typeof(int));
            while (dra.Read())
            {
                table.Rows.Add(int.Parse(dra["MaThuoc"].ToString()), dra["TenThuoc"].ToString(), dra["GiaBan"].ToString(), dra["HanSuDung"].ToString(),dra["MaNCC"].ToString(),dra["MaDonViTinh"].ToString());
            }
            dra.Dispose();
            return table;
        }            
        public int checkProduct_ID(int mathuoc)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MATHUOC,SqlDbType.Int)
            };
            parm[0].Value = mathuoc;
            return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_Product_Check", parm);
        }
    }
}
