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
    public class DonViTinhDAL:IDonViTinhDAL
    {
        public DataTable getAll()
        {
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_DonViTinh_Sel_All", null);
            DataTable table = new DataTable();
            table.Columns.Add("MaDonViTinh", typeof(int));
            table.Columns.Add("TenDonViTinh", typeof(string));        
            while (dra.Read())
            {
                table.Rows.Add(int.Parse(dra["MaDonViTinh"].ToString()), dra["TenDonViTinh"].ToString());
            }
            dra.Dispose();
            return table;
        }
    }
}
