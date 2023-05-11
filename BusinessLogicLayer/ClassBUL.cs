using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataAccessLayer;
using Utility;
using Entities;
using DocumentFormat.OpenXml.Drawing.Charts;

namespace BusinessLogicLayer
{
    public class ClassBUL : IClassBUL
    {
        private readonly IClassDAL dal = new ClassDAL();
        /// <summary>
        /// Hàm dùng để chèn thông tin một lớp học vào CSDL với việc dữ liệu lấy từ tầng Presentation
        /// Nếu việc chèn không thành công do mã lớp đã tồn tại hàm trả về giá trị -1
        /// </summary>
        /// <param name="cls">Thông tin lớp học được lấy từ tầng Presentation </param>

        public int Insert(Class cls)
        {
            if (checkClass_ID(cls.ClassID) == 0)
                return dal.Insert(cls.ClassName, Tools.ChuanHoaXau(cls.MonitorName), Tools.ChuanHoaXau(cls.TeacherName));
            else return -1;

        }
        /// <summary>
        /// Hàm xóa thông tin lớp học khỏi CSDL với mã lớp được chỉ định từ tầng Presentation
        /// Nếu không xóa được lớp do lớp này không tồn tại hàm trả về giá trị -1
        /// </summary>
        /// <param name="classID">Mã lớp</param>

        public int Delete(int classID)
        {
            if (checkClass_ID(classID) != 0)
                return dal.Delete(classID);
            else return -1;
        }
        /// <summary>
        /// Hàm cập nhật lại thông tin một lớp học vào CSDL với thông tin mới được lấy từ tầng Presentation
        /// Nếu việc cập nhật thất bại do mã lớp không tồn tại thì hàm trả về -1
        /// </summary>
        /// <param name="cls">Thông tin lớp mới cần được cập nhật lại vào CSDL</param>

        public int Update(Class cls)
        {
            if (checkClass_ID(cls.ClassID) != 0)
                return dal.Update(cls.ClassID, cls.ClassName, Tools.ChuanHoaXau(cls.MonitorName), Tools.ChuanHoaXau(cls.TeacherName));
            else return -1;
        }
        /// <summary>
        /// Hàm trả về danh sách các lớp cóp trong CSDL
        /// </summary>

        public IList<Class> getAll()
        {
            System.Data.DataTable table = dal.getAll();
            IList<Class> list = new List<Class>();
            foreach (DataRow row in table.Rows)
            {
                Class cls = new Class();
                cls.ClassID = row.Field<int>(0);
                cls.ClassName = row.Field<string>(1);
                cls.MonitorName = row.Field<string>(2);
                cls.TeacherName = row.Field<string>(3);
                list.Add(cls);
            }
            return list;
        }
        /// <summary>
        /// Hàm trả về thông tin cụ thể một lớp đã được chỉ định
        /// Nếu mã lớp không tồn tại hàm trả về giá trị null
        /// </summary>
        /// <param name="classID">Mã lớp</param>

        public Class getClass_ID(int classID)
        {
            System.Data.DataTable table = dal.getClass_ID(classID);
            if (checkClass_ID(classID) != 0)
            {
                Class cls = new Class();
                cls.ClassID = table.Rows[0].Field<int>(0);
                cls.ClassName = table.Rows[0].Field<string>(1);
                cls.MonitorName = table.Rows[0].Field<string>(2);
                cls.TeacherName = table.Rows[0].Field<string>(3);
                return cls;
            }
            else return null;
        }
        /// <summary>
        /// Hàm lấy về mã của bản ghi mới nhất trong bảng tbl_Classes
        /// </summary> 
        public int getclassID_Last()
        {
            if (dal.getAll().Rows.Count == 0)
                return 1;
            else return dal.getclassID_Last();
        }
        /// <summary>
        /// Kiểm tra xem một lớp cho bởi mã lớp có trong CSDL không?
        /// Nếu có hàm trả về giá trị khác 0 còn không có trả về giá trị bằng 0
        /// </summary>
        /// <param name="classID">Mã lớp</param>

        public int checkClass_ID(int classID)
        {
            return dal.checkClass_ID(classID);
        }
        /// <summary>
        /// Tìm kiếm thông tin lớp học 
        /// </summary>
        /// <param name="cls">Thông tin lớp</param> 
        public IList<Class> Search(Class cls)
        {
            IList<Class> list = getAll();
            IList<Class> kq = new List<Class>();
            //Voi gai tri ngam dinh ban dau
            if (cls.ClassName == null && cls.MonitorName == null && cls.TeacherName == null)
            {
                kq = list;
            }
            //Tim theo ten lop
            if (cls.ClassName != null && cls.MonitorName == null && cls.TeacherName == null)
            {
                foreach (Class cl in list)
                    if (cl.ClassName.IndexOf(cls.ClassName) >= 0)
                    {
                        kq.Add(new Class(cl));
                    }
            }
            // Tim theo ten lop truong
            else if (cls.ClassName == null && cls.MonitorName != null && cls.TeacherName == null)
            {
                foreach (Class cl in list)
                    if (cl.MonitorName.IndexOf(cls.MonitorName) >= 0)
                    {
                        kq.Add(new Class(cl));
                    }
            }
            //Tim theo giao vien chu nhiem
            else if (cls.ClassName == null && cls.MonitorName == null && cls.TeacherName != null)
            {
                foreach (Class cl in list)
                    if (cl.TeacherName.IndexOf(cls.TeacherName) >= 0)
                    {
                        kq.Add(new Class(cl));
                    }
            }
            //Tim ket hop giua ten lop va ten giao vien,ten lop truong
            else if (cls.ClassName != null && cls.MonitorName != null && cls.TeacherName != null)
            {
                foreach (Class cl in list)
                    if (cl.TeacherName.IndexOf(cls.TeacherName) >= 0 && cl.ClassName.IndexOf(cls.ClassName) >= 0 && cl.MonitorName.IndexOf(cls.MonitorName) >= 0)
                    {
                        kq.Add(new Class(cl));
                    }
            }
            //Cac truong hop khac cac ban tu lam
            else kq = null;
            return kq;
        }
        /// <summary>
        /// Tìm kiếm thông tin lớp học dùng Linq
        /// </summary>
        /// <param name="cls">Thông tin lớp</param> 
        public IList<Class> SearchLinq(Class cls)
        {
            return getAll().Where(x => (string.IsNullOrEmpty(cls.ClassName) || x.ClassName.Contains(cls.ClassName))
            && (string.IsNullOrEmpty(x.MonitorName) || x.MonitorName.Contains(cls.MonitorName))
            && (string.IsNullOrEmpty(x.TeacherName) || x.TeacherName.Contains(cls.TeacherName))).ToList();
        }

        public void KetXuatWord(int ClassID, string templatePath, string exportPath)
        {
            Class lop = getClass_ID(ClassID);
            IStudentBUL std = new StudentBUL();
            IList<Student> list = std.getAll(ClassID);
            Dictionary<string, string> dictionaryData = new Dictionary<string, string>();
            dictionaryData.Add("tenlop", lop.ClassName.ToString());
            dictionaryData.Add("loptruong", lop.MonitorName.ToString());
            dictionaryData.Add("giaovien", lop.TeacherName.ToString());
            System.IO.File.Copy(templatePath, exportPath, true);
            ExportDocx.CreateClassTemplate(exportPath, dictionaryData, list);
        }
    }
}
