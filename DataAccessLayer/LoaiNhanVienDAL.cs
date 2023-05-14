using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Interface;

namespace DataAccessLayer
{
    public class LoaiNhanVienDAL:ILoaiNhanVienDAL
    {
        public DataTable getAll()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_LoaiNhanVien_Sel_All", null);
            DataTable table = new DataTable();
            table.Columns.Add("MaLoai", typeof(int));
            table.Columns.Add("TenLoai", typeof(string));
            while (dra.Read())
            {
                table.Rows.Add(int.Parse(dra["MaLoai"].ToString()), dra["TenLoai"].ToString());
            }
            dra.Dispose();
            return table;
        }
    }
}
