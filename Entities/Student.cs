using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
  public class Student
    {
        protected int studentID;
        protected string studentName;
        protected DateTime birthday;
        protected string address;
        protected string sex;
        protected string phoneNumber;
        protected string note;
        protected int classID;
        protected string className;
        public Student()
        {

        }
        public Student(string studentName, DateTime birthday, string address, string sex, string phoneNumber, string note, int classID)
        {
            this.studentName = studentName;
            this.birthday = birthday;
            this.address = address;
            this.sex = sex;
            this.phoneNumber = phoneNumber;
            this.note = note;
            this.classID = classID;
        }
        public int ClassID
        {
            get { return classID; }
            set { classID = value; }
        }
        public int StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }
        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }
        public DateTime Brithday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string Note
        {
            get { return note; }
            set { note = value; }
        }
        public string ClassName
        {
            set { className = value; }
            get { return className; }
        }
        
    }
}
