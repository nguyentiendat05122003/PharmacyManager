using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Entities;

namespace DataAccessLayer
{
    public interface IStudentDAL
    {
        DataTable getAll(int ClassID);
        int Insert(Student student);
    }
}
