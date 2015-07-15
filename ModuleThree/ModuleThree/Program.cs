using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleThree
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            DateTime birthdate;

            GetStudentInformation(out firstName, out lastName, out birthdate);
            validatingBirthday(birthdate);
            PrintStudentDetails(firstName, lastName, birthdate);
        }

        static void GetStudentInformation(out string firstName, out string lastName, out DateTime birthdate)
        {
            Console.WriteLine("Enter the student's first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birthdate(mm/dd/yyyy): ");
            birthdate = Convert.ToDateTime(Console.ReadLine());
        }

        static void PrintStudentDetails(string firstName, string lastName, DateTime birthdate)
        {
            Console.WriteLine("{0} {1} was bron on: {2}/{3}/{4}", firstName, lastName, birthdate.Year, birthdate.Month, birthdate.Day);
        }

        static void validatingBirthday(DateTime birthdate)
        {
            throw new NotImplementedException();
        }
    }
}
