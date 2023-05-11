
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace DataAccessLayer 
{
    public class ClassDAL : IClassDAL
    {
        private const string PARM_CLASSID = "@classID";
        private const string PARM_CLASSNAME = "@className";
        private const string PARM_MONITORNAME = "@monitorName";
        private const string PARM_TEACHERNAME = "@teacherName";
        /// <summary>
        /// Hàm chèn thông tin một lớp học với mã lớp, tên lớp,... đã cho
        /// </summary>
        /// <param name="classID">Mã lớp</param>
        /// <param name="className">Tên lớp</param>
        /// <param name="monitorName">Lớp trưởng</param>
        /// <param name="teacherName">Giáo viên chủ nhiệm</param>        
        public int Insert(string className, string monitorName, string teacherName)
        {             
            SqlParameter[] parm = new SqlParameter[] 
            { 
                new SqlParameter(PARM_CLASSNAME,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_MONITORNAME,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_TEACHERNAME,SqlDbType.NVarChar,50), 
            };
            parm[0].Value = className;
            parm[1].Value = monitorName;
            parm[2].Value = teacherName;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_Classes_Ins", parm);
        }
        /// <summary>
        /// Hàm xóa lớp được chỉ định bởi mã lớp
        /// </summary>
        /// <param name="classID">Mã lớp</param>
         
        public int Delete(int classID)
        {
            SqlParameter[] parm = new SqlParameter[] 
            { 
                new SqlParameter(PARM_CLASSID,SqlDbType.Int) 
            };
            parm[0].Value = classID;

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_Classes_Del", parm);
        }
        /// <summary>
        /// Hàm cập nhật thông tin lớp học với các thông tin tên lớp, mã lớp,... chỉ định dùng để thay thế
        /// </summary>
        /// <param name="classID">Mã lớp</param>
        /// <param name="className">Tên lớp</param>
        /// <param name="monitorName">Lớp trưởng</param>
        /// <param name="teacherName">Giáo viên chủ nhiệm</param>   
        public int Update(int classID, string className, string monitorName, string teacherName)
        {
            SqlParameter[] parm = new SqlParameter[] 
            { 
                new SqlParameter(PARM_CLASSID,SqlDbType.Int),
                new SqlParameter(PARM_CLASSNAME,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_MONITORNAME,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_TEACHERNAME,SqlDbType.NVarChar,50), 
            };
            parm[0].Value = classID;
            parm[1].Value = className;
            parm[2].Value = monitorName;
            parm[3].Value = teacherName;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_Classes_Upd", parm);
        }
        /// <summary>
        /// Hàm lấy về toàn bộ các lớp có trong CSDL
        /// </summary> 
        public DataTable getAll()
        { 
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_Classes_Sel_All", null);
            DataTable table = new DataTable();
            table.Columns.Add("classID", typeof(int));
            table.Columns.Add("className", typeof(string));
            table.Columns.Add("monitorName", typeof(string));
            table.Columns.Add("teacherName", typeof(string)); 
            while (dra.Read())
            {
                table.Rows.Add(int.Parse(dra["classID"].ToString()), dra["className"].ToString(), dra["monitorName"].ToString(), dra["teacherName"].ToString());             
            }
            dra.Dispose(); 
            return table; 
        }
        /// <summary>
        /// Hàm lấy về thông tin một lớp học cụ thể
        /// </summary> 
        public DataTable getClass_ID(int classID)
        {
            SqlParameter[] parm = new SqlParameter[] 
            { 
                new SqlParameter(PARM_CLASSID,SqlDbType.Int) 
            };
            parm[0].Value = classID;
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_Classes_Sel_ID", parm);
            DataTable table = new DataTable();
            table.Columns.Add("classID", typeof(int));
            table.Columns.Add("className", typeof(string));
            table.Columns.Add("monitorName", typeof(string));
            table.Columns.Add("teacherName", typeof(string));
            while (dra.Read())
            {
                table.Rows.Add(int.Parse(dra["classID"].ToString()), dra["className"].ToString(), dra["monitorName"].ToString(), dra["teacherName"].ToString());
            }
            dra.Dispose();
            return table;
        }
        public int getclassID_Last()
        {
            return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.Text, "select top 1 ClassID from tbl_Classes order by ClassID desc", null);
        }
        public int checkClass_ID(int classID)
        {
            SqlParameter[] parm = new SqlParameter[] 
            { 
                new SqlParameter(PARM_CLASSID,SqlDbType.Int) 
            };
            parm[0].Value = classID;
            return (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_Classes_Check", parm);
        }
    }
}
