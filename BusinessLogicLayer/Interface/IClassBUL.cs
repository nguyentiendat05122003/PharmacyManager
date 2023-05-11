using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer
{
    public interface IClassBUL
    {
        int Insert(Class cls);
        int Delete(int classID);
        int Update(Class cls);
        IList<Class> getAll();
        Class getClass_ID(int classID);
        int getclassID_Last();
        int checkClass_ID(int classID);
        IList<Class> Search(Class cls);
        IList<Class> SearchLinq(Class cls);
        void KetXuatWord(int ClassID, string templatePath, string exportPath);
    }
}
