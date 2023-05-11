using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer
{
    public interface IStudentBUL
    {
        IList<Student> getAll(int ClassID);
        void ThemTuExcel(string filePath);
        void KetXuatExcel(int ClassID, string templatePath, string exportPath);
    }
}
