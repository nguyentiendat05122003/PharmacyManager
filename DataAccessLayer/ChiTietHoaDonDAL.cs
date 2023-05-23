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
    public class ChiTietHoaDonDAL : IChiTietHoaDonDAL
    {
        private const string PARM_MACHITIET = "@MaChiTiet";
        private const string PARM_MAHOADON = "@MaHoaDon";
        private const string PARM_DONGIA = "@DonGia";
        private const string PARM_MATHUOC = "@MaThuoc";
        private const string PARM_SOLUONG = "@SoLuong";

        public int Insert(int mahoadon, float dongia, int mathuoc, int soluong)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MAHOADON,SqlDbType.Int),
                new SqlParameter(PARM_DONGIA,SqlDbType.Float),
                new SqlParameter(PARM_MATHUOC,SqlDbType.Int),
                new SqlParameter(PARM_SOLUONG,SqlDbType.Int),
            };
            parm[0].Value = mahoadon;
            parm[1].Value = dongia;
            parm[2].Value = mathuoc;
            parm[3].Value = soluong;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_ChiTietHoaDonBan_Ins", parm);
        }

        public int Delete(int machitietID)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MACHITIET,SqlDbType.Int)
            };
            parm[0].Value = machitietID;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_ChiTietHoaDonBan_Del", parm);
        }
        public int Update(int machitiet, int mahoadon, float dongia, int mathuoc, int soluong)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MACHITIET,SqlDbType.Int),
                new SqlParameter(PARM_MAHOADON,SqlDbType.Int),
                new SqlParameter(PARM_DONGIA,SqlDbType.Float),
                new SqlParameter(PARM_MATHUOC,SqlDbType.Int),
                new SqlParameter(PARM_SOLUONG,SqlDbType.Int),
            };
            parm[0].Value = machitiet;
            parm[1].Value = mahoadon;
            parm[2].Value = dongia;
            parm[3].Value = mathuoc;
            parm[4].Value = soluong;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_ChiTietHoaDonBan_Update", parm);
        }
        public DataTable getAll()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_ChiTietHoaDonBan_Sel_All", null);
            DataTable table = new DataTable();
            table.Columns.Add("MaChiTiet", typeof(int));
            table.Columns.Add("MaHoaDon", typeof(int));
            table.Columns.Add("DonGia", typeof(float));
            table.Columns.Add("MaThuoc", typeof(int));
            table.Columns.Add("SoLuong", typeof(int));
            while (dra.Read())
            {
                table.Rows.Add(int.Parse(dra["MaChiTiet"].ToString()), dra["MaHoaDon"].ToString(), dra["DonGia"].ToString(), dra["MaThuoc"].ToString(), dra["SoLuong"].ToString());
            }
            dra.Dispose();
            return table;
        }
        public int checkChitiet_ID(int machitiet)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MACHITIET,SqlDbType.Int)
            };
            parm[0].Value = machitiet;
            return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_ChiTietHoaDonBan_Check", parm);
        }
    }
}
