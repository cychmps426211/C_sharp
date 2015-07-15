using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Course c = new Course("Programming with C#");
            c.students[0] = new Student("Steven", "Chiang", new DateTime(1992, 6, 23));
            c.students[1] = new Student("Wolf", "Wang", new DateTime(1990, 9, 11));
            c.students[2] = new Student("Mo", "Li", new DateTime(1991, 4, 15));
            c.teachers[0] = new Teacher("Yu Je", "Li", new DateTime(1992, 6, 23));

            Degree d = new Degree("Bachelor");
            d.C = c;

            UProgram up = new UProgram("Information Technology");
            up.D = d;

            Console.WriteLine("The {0} program contains the {1} of Science degree", up.ProgramName, up.D.DegreeName);
            Console.WriteLine("The {0} of Science degree contains the course {1}", d.DegreeName, d.C.CourseName);
            Console.WriteLine("The {0} course contains {1} student(s)", c.CourseName, Student.Count);
        }
    }
}
