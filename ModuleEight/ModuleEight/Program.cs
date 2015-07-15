using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleEight
{
    class Program
    {
        static void Main(string[] args)
        {
            Course c = new Course("Programming with C#");
            Student one = new Student("Steven", "Chiang", new DateTime(1992, 6, 23));
            Student two = new Student("Wolf", "Wang", new DateTime(1990, 9, 11));
            Student three = new Student("Mo", "Li", new DateTime(1991, 4, 15));

            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i < 5; i++)
            {
                one.Grades.Push(rnd.Next(1, 100));
                two.Grades.Push(rnd.Next(1, 100));
                three.Grades.Push(rnd.Next(1, 100));
            }
            c.students.Add(one);
            c.students.Add(two);
            c.students.Add(three);
            c.teachers.Add(new Teacher("Yu Je", "Li", new DateTime(1992, 6, 23)));

            c.ListStudents();
        }
    }
}
