using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
   public class Class
    {
        protected int classID;
        protected string className;
        protected string monitorName;
        protected string teacherName;
        public Class()
        {
        }
       public Class(Class cls)
        {
            this.classID = cls.classID;
            this.className = cls.className;
            this.monitorName = cls.monitorName;
            this.teacherName = cls.teacherName;
        }
        public Class(int classID, string className, string monitorName, string teacherName)
        {
            this.classID = classID;
            this.className = className;
            this.monitorName = monitorName;
            this.teacherName = teacherName;
        }
        public Class(string className, string monitorName, string teacherName)
        { 
            this.className = className;
            this.monitorName = monitorName;
            this.teacherName = teacherName;
        }
        public int ClassID
        {
            get { return classID; }
            set { classID = value; }
        }
        public string ClassName
        {
            get { return className; }
            set { className = value; }
        }
        public string MonitorName
        {
            get { return monitorName; }
            set { monitorName = value; }
        }
        public string TeacherName
        {
            get { return teacherName; }
            set { teacherName = value; }
        }
    }
}
