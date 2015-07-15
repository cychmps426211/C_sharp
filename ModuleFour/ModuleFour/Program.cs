using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFour
{
    class Program
    {
        public struct Student
        {
            public Student(string firstName, string lastName, DateTime birthdate, string addressLine1, string addressLine2, string city, string state, string zip, string country)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.birthdate = birthdate;
                this.addressLine1 = addressLine1;
                this.addressLine2 = addressLine2;
                this.city = city;
                this.state = state;
                this.zip = zip;
                this.country = country;
            }

            public string firstName;
            public string lastName;
            public DateTime birthdate;
            public string addressLine1;
            public string addressLine2;
            public string city;
            public string state;
            public string zip;
            public string country;
        }

        struct Teacher
        {
            public Teacher(string firstName, string lastName, DateTime birthdate, string addressLine1, string addressLine2, string city, string state, string zip, string country)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.birthdate = birthdate;
                this.addressLine1 = addressLine1;
                this.addressLine2 = addressLine2;
                this.city = city;
                this.state = state;
                this.zip = zip;
                this.country = country;
            }

            public string firstName;
            public string lastName;
            public DateTime birthdate;
            public string addressLine1;
            public string addressLine2;
            public string city;
            public string state;
            public string zip;
            public string country;
        }

        struct UProgram
        {
            public UProgram(string pName, string department, string degrees)
            {
                this.pName = pName;
                this.department = department;
                this.degrees = degrees;
            }

            public string pName;
            public string department;
            public string degrees;
        }

        struct Course
        {
            public Course(string cName, string credits, string weeks, string teacher)
            {
                this.cName = cName;
                this.credits = credits;
                this.weeks = weeks;
                this.teacher = teacher;
            }

            public string cName;
            public string credits;
            public string weeks;
            public string teacher;
        }

        static void Main(string[] args)
        {
            Student[] arrayStudent = new Student[5];

            arrayStudent[0] = new Student("Wei Chen", "Chiang", new DateTime(1992, 6, 23), "Linhai 2nd Rd.", "No.4, Ln. 60", "Gushan Dist.", "Kaohsiung City", "804", "Taiwan");

            Console.WriteLine("{0} {1} was bron on: {2}/{3}/{4}", arrayStudent[0].firstName, arrayStudent[0].lastName, arrayStudent[0].birthdate.Year, arrayStudent[0].birthdate.Month, arrayStudent[0].birthdate.Day);
            Console.WriteLine("Adderss is: {0} {1} {2} {3} {4}", arrayStudent[0].addressLine2, arrayStudent[0].addressLine1, arrayStudent[0].city, arrayStudent[0].state, arrayStudent[0].country);
        }
    }
}
