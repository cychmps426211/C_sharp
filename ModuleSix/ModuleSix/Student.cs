﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleSix
{
    public class Student : Person
    {
        public Student(string firstName, string lastName, DateTime birthday)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Birthday = birthday;
            count++;
        }

        private static int count = 0;
        public static int Count
        {
            get { return Student.count; }
        }

        public void TakeTest()
        {
            
        }
    }
}
