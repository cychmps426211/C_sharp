using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudoleOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Wei Chen";
            string lastName = "Chiang";
            DateTime birthdate = new DateTime(1992, 6, 23);
            string addressLine1 = "Taiwan";
            string addressLine2 = "Kaohsiung";
            string city = "Taiwan";
            string state = "Kaohsiung";
            int zip = 804;
            string country = "Kaohsiung";

            Console.WriteLine("Name : " + firstName + " " + lastName);
            Console.WriteLine("Birthdate : " + birthdate);
            Console.WriteLine("Address : " + zip + " " + city + " " + state + " " + country + " " + addressLine1 + " " + addressLine2);
        }
    }
}
