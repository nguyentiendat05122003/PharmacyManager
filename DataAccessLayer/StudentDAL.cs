using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;

namespace DataAccessLayer
{
    public class StudentDAL : IStudentDAL
    {
        private const string PARM_STUDENTID = "@studentID";
        private const string PARM_STUDENTNAME = "@studentName";
        private const string PARM_BIRTHDAY = "@birthday";
        private const string PARM_ADDRESS = "@address";
        private const string PARM_SEX = "@sex";
        private const string PARM_PHONENUMBER = "@phoneNumber";
        private const string PARM_NOTE = "@note";
        private const string PARM_CLASSID = "@classID";

        /// <summary>
        /// Lấy toàn bộ thông tin về sinh viên
        /// </summary>
        /// <returns></returns>
        public DataTable getAll(int ClassID)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_CLASSID,SqlDbType.Int)
            };
            parm[0].Value = ClassID;
            SqlDataReader dra = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_Studetns_Sel_ClassID", parm);
            DataTable table = new DataTable();
            table.Columns.Add("StudentID", typeof(int));
            table.Columns.Add("StudentName", typeof(string));
            table.Columns.Add("Birthday", typeof(DateTime));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("Sex", typeof(string));
            table.Columns.Add("PhoneNumber", typeof(string));
            table.Columns.Add("Note", typeof(string));
            table.Columns.Add("ClassID", typeof(int));
            table.Columns.Add("ClassName", typeof(string));
            while (dra.Read())
            {
                table.Rows.Add(
                    int.Parse(dra["StudentID"].ToString()),
                    dra["StudentName"].ToString(),
                    DateTime.Parse(dra["Birthday"].ToString()),
                    dra["Address"].ToString(),
                    dra["Sex"].ToString(),
                    dra["PhoneNumber"].ToString(),
                    dra["Note"].ToString(),
                    int.Parse(dra["ClassID"].ToString()),
                    dra["ClassName"].ToString()
                    );
            }
            dra.Dispose();
            return table;
        }
        /// <summary>
        /// Hàm chèn thông tin một sinh viên 
        /// </summary>
        public int Insert(Student student)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter(PARM_STUDENTNAME,SqlDbType.NVarChar,50),
                new SqlParameter(PARM_BIRTHDAY,SqlDbType.DateTime),
                new SqlParameter(PARM_ADDRESS,SqlDbType.NVarChar,100),
                new SqlParameter(PARM_SEX,SqlDbType.NVarChar,10),
                new SqlParameter(PARM_PHONENUMBER,SqlDbType.NVarChar,20),
                new SqlParameter(PARM_NOTE,SqlDbType.NVarChar,100),
                new SqlParameter(PARM_CLASSID,SqlDbType.Int)
            };
            if (string.IsNullOrEmpty(student.StudentName))
                parm[0].Value = DBNull.Value;
            else
                parm[0].Value = student.StudentName;

            if (student.Brithday == null)
                parm[1].Value = DBNull.Value;
            else
                parm[1].Value = student.Brithday;

            if (string.IsNullOrEmpty(student.Address))
                parm[2].Value = DBNull.Value;
            else
                parm[2].Value = student.Address;


            if (string.IsNullOrEmpty(student.Sex))
                parm[3].Value = DBNull.Value;
            else
                parm[3].Value = student.Sex;

            if (string.IsNullOrEmpty(student.PhoneNumber))
                parm[4].Value = DBNull.Value;
            else
                parm[4].Value = student.PhoneNumber;

            if (string.IsNullOrEmpty(student.Note))
                parm[5].Value = DBNull.Value;
            else
                parm[5].Value = student.Note;
            parm[6].Value = student.ClassID;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "tbl_Students_Ins", parm);
        }
    }
}
