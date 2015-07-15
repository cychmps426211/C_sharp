using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace ModuleSeven
{
    public class Course
    {
        public Course(string courseName)
        {
            this.CourseName = courseName;
        }

        public ArrayList students = new ArrayList();
        public ArrayList teachers = new ArrayList();

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
