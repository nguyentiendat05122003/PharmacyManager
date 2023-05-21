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
    public class PhieuNhapDAL : IPhieuNhapDAL
    {
        private const string PARM_MAPHIEUNHAP = "@maphieunhap";
        private const string PARM_MATHUOCID = "@mathuoc";
        private const string PARM_NGAYNHAP = "@ngaynhap";
        private const string PARM_TONGTIEN = "@tongtien";
        private const string PARM_MANHANVIEN = "@manhanvien";

        public int Insert(int mathuoc, DateTime ngaynhap, float tongtien, int manhanvien)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MATHUOCID,SqlDbType.Int),
                new SqlParameter(PARM_NGAYNHAP,SqlDbType.DateTime),
                new SqlParameter(PARM_TONGTIEN,SqlDbType.Float),
                new SqlParameter(PARM_MANHANVIEN,SqlDbType.Int),
            };
            parm[0].Value = mathuoc;
            parm[1].Value = ngaynhap;
            parm[2].Value = tongtien;
            parm[3].Value = manhanvien;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_PhieuNhap_Ins", parm);
        }

        public int Delete(int manhapID)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MAPHIEUNHAP,SqlDbType.Int)
            };
            parm[0].Value = manhapID;

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_PhieuNhap_Del", parm);
        }

        public int Update(int maphieunhap, int mathuoc, DateTime ngaynhap, float tongtien, int manhanvien)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MAPHIEUNHAP,SqlDbType.Int),
                new SqlParameter(PARM_MATHUOCID,SqlDbType.Int),
                new SqlParameter(PARM_NGAYNHAP,SqlDbType.DateTime),
                new SqlParameter(PARM_TONGTIEN,SqlDbType.Float),
                new SqlParameter(PARM_MANHANVIEN,SqlDbType.Int),
            };
            parm[0].Value = maphieunhap;
            parm[1].Value = mathuoc;
            parm[2].Value = ngaynhap;
            parm[3].Value = tongtien;
            parm[4].Value = manhanvien;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_PhieuNhap_Upd", parm);
        }

        public DataTable getAll()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_PhieuNhap_Sel_All", null);
            DataTable table = new DataTable();
            table.Columns.Add("MaPhieuNhap", typeof(int));
            table.Columns.Add("MaThuoc", typeof(int));
            table.Columns.Add("NgayNhap", typeof(DateTime));
            table.Columns.Add("TongTien", typeof(float));
            table.Columns.Add("MaNhanVien", typeof(int));
            while (dra.Read())
            {
                table.Rows.Add(int.Parse(dra["MaPhieuNhap"].ToString()), dra["MaThuoc"].ToString(), dra["NgayNhap"].ToString(), dra["TongTien"].ToString(), dra["MaNhanVien"].ToString());
            }
            dra.Dispose();
            return table;
        }

        public int checkPhieuNhap_ID(int classID)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MAPHIEUNHAP,SqlDbType.Int)
            };
            parm[0].Value = classID;
            return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_PhieuNhap_Check", parm);
        }
    }
}
