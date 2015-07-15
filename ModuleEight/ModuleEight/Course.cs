using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace ModuleEight
{
    public class Course
    {
        public Course(string courseName)
        {
            this.CourseName = courseName;
        }

        public List<Student> students = new List<Student>();
        public List<Teacher> teachers = new List<Teacher>();

        private string courseName;
        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }

        public void ListStudents()
        {
            foreach (Student s in students)
            {
                Console.WriteLine("{0} {1}", s.FirstName, s.LastName);
            }
        }
    }
}
