using DataAccessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Text.RegularExpressions;

namespace DataAccessLayer
{
    public class ProductDAL : IProductDAL
    {
        private const string PARM_MATHUOC = "@MaThuoc";
        private const string PARM_TENTHUOC = "@TenThuoc";
        private const string PARM_GIABAN = "@GiaBan";
        private const string PARM_HANSUDUNG = "@HanSuDung";
        private const string PARM_DUNGKINHDOANH = "@DungKinhDoanh";
        private const string PARM_MADONVITINH = "@MaDonViTinh";
        private const string PARM_SPLUONG = "@Soluong";


        public int Insert(string tenthuoc, float giaban, DateTime hansudung, bool dungkinhdoanh, int madonvitinh,int soluong)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_TENTHUOC,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_GIABAN,SqlDbType.Float),
                new SqlParameter(PARM_HANSUDUNG,SqlDbType.DateTime),
                new SqlParameter(PARM_DUNGKINHDOANH,SqlDbType.Bit),
                new SqlParameter(PARM_MADONVITINH,SqlDbType.Int),
                new SqlParameter(PARM_SPLUONG,SqlDbType.Int),
            };
            parm[0].Value = tenthuoc;
            parm[1].Value = giaban;
            parm[2].Value = hansudung;
            parm[3].Value = dungkinhdoanh;
            parm[4].Value = madonvitinh;
            parm[5].Value = soluong;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_Products_Insert", parm);
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
       
        public int Update(int mathuoc, string tenthuoc, float giaban, DateTime hansudung, bool dungkinhdoanh, int madonvitinh,int soluong)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MATHUOC,SqlDbType.Int),
                new SqlParameter(PARM_TENTHUOC,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_GIABAN,SqlDbType.Float),
                new SqlParameter(PARM_HANSUDUNG,SqlDbType.DateTime),
                new SqlParameter(PARM_DUNGKINHDOANH,SqlDbType.Bit),
                new SqlParameter(PARM_MADONVITINH,SqlDbType.Int),
                new SqlParameter(PARM_SPLUONG,SqlDbType.Int),
            };
            parm[0].Value = mathuoc;
            parm[1].Value = tenthuoc;
            parm[2].Value = giaban;
            parm[3].Value = hansudung;
            parm[4].Value = dungkinhdoanh;
            parm[5].Value = madonvitinh;
            parm[6].Value = soluong;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_Products_Update", parm);
        }
     
        public DataTable getAll()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_Product_Sel_All", null);
            DataTable table = new DataTable();
            table.Columns.Add("MaThuoc", typeof(int));
            table.Columns.Add("TenThuoc", typeof(string));
            table.Columns.Add("GiaBan", typeof(float));
            table.Columns.Add("HanSuDung", typeof(DateTime));
            table.Columns.Add("DungKinhDoanh", typeof(bool));
            table.Columns.Add("MaDonViTinh", typeof(int));
            table.Columns.Add("Soluong", typeof(int));
            while (dra.Read())
            {
                table.Rows.Add(int.Parse(dra["MaThuoc"].ToString()), dra["TenThuoc"].ToString(), dra["GiaBan"].ToString(), dra["HanSuDung"].ToString(),dra["DungKinhDoanh"].ToString(),dra["MaDonViTinh"].ToString(),dra["Soluong"].ToString());
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
