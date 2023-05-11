using System;
using System.Data;
using System.Collections.Generic;
using DataAccessLayer;
using Entities;
using System.Globalization;
using System.IO;

namespace BusinessLogicLayer
{
    public class StudentBUL : IStudentBUL
    {
        private readonly IStudentDAL dal = new StudentDAL();
        public IList<Student> getAll(int ClassID)
        {
            DataTable table = dal.getAll(ClassID);
            IList<Student> list = new List<Student>();
            foreach (DataRow row in table.Rows)
            {
                Student cls = new Student();
                cls.StudentID = row.Field<int>(0);
                cls.StudentName = row.Field<string>(1);
                cls.Brithday = row.Field<DateTime>(2);
                cls.Address = row.Field<string>(3);
                cls.Sex = row.Field<string>(4);
                cls.PhoneNumber = row.Field<string>(5);
                cls.Note = row.Field<string>(6);
                cls.ClassID = row.Field<int>(7);
                cls.ClassName = row.Field<string>(8);
                list.Add(cls);
            }
            return list;
        }
        public void ThemTuExcel(string filePath)
        {
            var messageError = "";
            var data = ExcelHelper.ReadFromExcelFile(filePath, 1, out messageError);
            if (string.IsNullOrEmpty(messageError))
            {
                foreach (DataRow row in data.Rows)
                {
                    Student student = new Student();
                    student.StudentName = row.Field<string>("StudentName");
                    student.Brithday = DateTime.ParseExact(row.Field<string>("Brithday"), "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    student.Address = row.Field<string>("Address");
                    student.Sex = row.Field<string>("Sex");
                    student.PhoneNumber = row.Field<string>("PhoneNumber");
                    student.Note = row.Field<string>("Note");
                    student.ClassID = int.Parse(row.Field<string>("ClassID"));
                    dal.Insert(student);
                }
            }
            else throw new Exception(messageError);

        }
        public void KetXuatExcel(int ClassID, string templatePath, string exportPath)
        {
            var list = getAll(ClassID);
            DataTable dataExport = new DataTable();
            dataExport.Columns.Add("StudentName");
            dataExport.Columns.Add("Brithday", typeof(DateTime));
            dataExport.Columns.Add("Address");
            dataExport.Columns.Add("Sex");
            dataExport.Columns.Add("PhoneNumber");
            dataExport.Columns.Add("Note");
            dataExport.Columns.Add("ClassID", typeof(int));
            dataExport.Columns.Add("ClassName");
            List<ExcelDataExtention> staticDataValue = new List<ExcelDataExtention>();
            staticDataValue.Add(new ExcelDataExtention
            {
                IsEnd = false,
                StartColumnName = "F",
                EndColumnName = "F",
                StartRowIndex = 4,
                EndRowIndex = 4,
                Value = "Hưng yên, ngày " + DateTime.Now.Day + " tháng " + DateTime.Now.Month + " năm " + DateTime.Now.Year
            }); ;
            int start_row = 6;
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    DataRow row = dataExport.NewRow();
                    if (string.IsNullOrEmpty(item.StudentName))
                        row["StudentName"] = DBNull.Value;
                    else
                        row["StudentName"] = item.StudentName;

                    if (item.Brithday == null)
                        row["Brithday"] = DBNull.Value;
                    else
                        row["Brithday"] = item.Brithday;

                    if (string.IsNullOrEmpty(item.Address))
                        row["Address"] = DBNull.Value;
                    else
                        row["Address"] = item.Address;

                    if (string.IsNullOrEmpty(item.Sex))
                        row["Sex"] = DBNull.Value;
                    else
                        row["Sex"] = item.Sex;

                    if (string.IsNullOrEmpty(item.PhoneNumber))
                        row["PhoneNumber"] = DBNull.Value;
                    else
                        row["PhoneNumber"] = item.PhoneNumber;

                    if (string.IsNullOrEmpty(item.Note))
                        row["Note"] = DBNull.Value;
                    else
                        row["Note"] = item.Note;

                    row["ClassID"] = item.ClassID;

                    if (string.IsNullOrEmpty(item.ClassName))
                        row["ClassName"] = DBNull.Value;
                    else
                        row["ClassName"] = item.ClassName;

                    dataExport.Rows.Add(row);
                    
                }
                ExcelHelper.ExportDataTableToExcel(exportPath, templatePath, dataExport, 1, start_row + 1, staticDataValue, true, "", "", false, "");
            }
        }
    }
}
