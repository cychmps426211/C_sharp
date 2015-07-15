using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleSix
{
    public class Course
    {
        public Course(string courseName)
        {
            this.CourseName = courseName;
        }

        public Student[] students = new Student[3];
        public Teacher[] teachers = new Teacher[3];

        private string courseName;
        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }
    }
}
