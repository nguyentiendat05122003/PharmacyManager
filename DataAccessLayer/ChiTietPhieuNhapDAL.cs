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
    public class ChiTietPhieuNhapDAL: IChiTietPhieuNhapDAL
    {
        private const string PARM_CHITIETPN = "@MaChiTietPhieuNhap";
        private const string PARM_MAPN = "@MaPhieuNhap";
        private const string PARM_THUOC = "@MaThuoc";
        private const string PARM_SOLUONG = "@SoLuong";
        private const string PARM_DONGIA = "@DonGia";
        public int Insert(int maphieunhap,int mathuoc, int soluong, float dongia)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MAPN,SqlDbType.Int),
                new SqlParameter(PARM_THUOC,SqlDbType.Int),
                new SqlParameter(PARM_SOLUONG,SqlDbType.Int),
                new SqlParameter(PARM_DONGIA,SqlDbType.Float),
            };
            parm[0].Value = maphieunhap;
            parm[1].Value = mathuoc;
            parm[2].Value = soluong;
            parm[3].Value = dongia;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_Chitietphieunhap_Insert", parm);
        }

        public int Delete(int machitietphieunhap)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_CHITIETPN,SqlDbType.Int)
            };
            parm[0].Value = machitietphieunhap;

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_Chitietphieunhap_Del", parm);
        }

        public int Update(int machitietphieunhap, int maphieunhap, int mathuoc ,int soluong, float dongia)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_CHITIETPN,SqlDbType.Int),
                new SqlParameter(PARM_MAPN,SqlDbType.Int),
                new SqlParameter(PARM_THUOC,SqlDbType.Int),
                new SqlParameter(PARM_SOLUONG,SqlDbType.Int),
                new SqlParameter(PARM_DONGIA,SqlDbType.Float),
            };
            parm[0].Value = machitietphieunhap;
            parm[1].Value = maphieunhap;
            parm[2].Value = mathuoc;
            parm[2].Value = soluong;
            parm[3].Value = dongia;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_Chitietphieunhap_Update", parm);
        }

        public DataTable getAll()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_Chitietphieunhap_Sel_All", null);
            DataTable table = new DataTable();
            table.Columns.Add("MaChiTietPhieuNhap", typeof(int));
            table.Columns.Add("MaPhieuNhap", typeof(int));
            table.Columns.Add("Mathuoc", typeof(int));
            table.Columns.Add("SoLuong", typeof(int));
            table.Columns.Add("DonGiaNhap", typeof(float));
            while (dra.Read())
            {
                table.Rows.Add(int.Parse(dra["MaChiTietPhieuNhap"].ToString()), dra["MaPhieuNhap"].ToString(), dra["Mathuoc"].ToString(), dra["SoLuong"].ToString(), dra["DonGiaNhap"].ToString());
            }
            dra.Dispose();
            return table;
        }

        public int checkChiTietPN_ID(int machitietphieunhap)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_CHITIETPN,SqlDbType.Int)
            };
            parm[0].Value = machitietphieunhap;
            return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_Chitietphieunhap_Check", parm);
        }
    }
}
