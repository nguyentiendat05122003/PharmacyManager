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
    public class HoaDonDAL:IHoaDonDAL
    {
        private const string PARM_HOADONID = "@MaHoaDon";
        private const string PARM_NGAYLAP = "@NgayLap";
        private const string PARM_TONGTIEN = "@TongTien";
        private const string PARM_MAKHACHHANG = "@MaKhachHang";
        private const string PARM_MANHANVIEN = "@MaNhanVien";
        private const string PARM_MONTH = "@Month";
        private const string PARM_YEAR = "@Year";

        public int Insert(DateTime ngaylap, float tongtien, int makhachhang, int manhanvien)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_NGAYLAP,SqlDbType.DateTime),
                new SqlParameter(PARM_TONGTIEN,SqlDbType.Float),
                new SqlParameter(PARM_MAKHACHHANG,SqlDbType.Int),
                new SqlParameter(PARM_MANHANVIEN,SqlDbType.Int),
            };
            parm[0].Value = ngaylap;
            parm[1].Value = tongtien;
            parm[2].Value = makhachhang;
            parm[3].Value = manhanvien;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_HoaDon_Insert", parm);
        }     
        public int Delete(int classID)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_HOADONID,SqlDbType.Int)
            };
            parm[0].Value = classID;

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_HoaDon_Delete", parm);
        }       
        public int Update(int mahoadon, DateTime ngaylap, float tongtien, int makhachhang, int manhanvien)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_HOADONID,SqlDbType.Int),
                new SqlParameter(PARM_NGAYLAP,SqlDbType.DateTime),
                new SqlParameter(PARM_TONGTIEN,SqlDbType.Float),
                new SqlParameter(PARM_MAKHACHHANG,SqlDbType.Int),
                new SqlParameter(PARM_MANHANVIEN,SqlDbType.Int),
            };
            parm[0].Value = mahoadon;
            parm[1].Value = ngaylap;
            parm[2].Value = tongtien;
            parm[3].Value = makhachhang;
            parm[4].Value = manhanvien;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_HoaDon_Update", parm);
        }
        /// <summary>
        /// Hàm lấy về toàn bộ các lớp có trong CSDL
        /// </summary> 
        public DataTable getAll()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_HoaDonBan_Sel_All", null);
            DataTable table = new DataTable();
            table.Columns.Add("MaHoaDon", typeof(int));
            table.Columns.Add("NgayLap", typeof(DateTime));
            table.Columns.Add("TongTien", typeof(float));
            table.Columns.Add("MaKhachHang", typeof(int));
            table.Columns.Add("MaNhanVien", typeof(int));
            while (dra.Read())
            {
                table.Rows.Add(int.Parse(dra["MaHoaDon"].ToString()), dra["NgayLap"].ToString(), dra["TongTien"].ToString(), dra["MaKhachHang"],dra["MaNhanVien"].ToString());
            }
            dra.Dispose();
            return table;
        }

        public int checkHoaDon_ID(int classID)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_HOADONID,SqlDbType.Int)
            };
            parm[0].Value = classID;
            return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_HoaDonBan_Check", parm);
        }

        public float GetDoanhThu(int month, int year)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_MONTH,SqlDbType.Int),
                new SqlParameter(PARM_YEAR,SqlDbType.Int),
            };
            parm[0].Value = month;
            parm[1].Value = year;
            object result = SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.StoredProcedure, "GetMonthlyRevenues", parm);
            float doanhThu = (result == null || result == DBNull.Value) ? 0 : Convert.ToSingle(result);
            return doanhThu;
        }
    }
}
