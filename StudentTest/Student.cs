using System;
using System.Collections.Generic;
using System.Text;

namespace StudentTest
{
    class Student
    {
        public string FirstName { get; set; } = "John";

        public string LastName { get; set; } = "Doe";

        public double Score { get; set; } = 100;

        public Student()
        {
            FirstName = "John";
            LastName = "Doe";
            Score = 100;
        }

        public Student(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public Student(string FirstName, string LastName, double Score) // information you obtained from user/database/etc
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Score = Score;
        }

        /*
         *  stirng name = Console.ReadLine();
         *  
         *  Student s = new Student(name,"Doe", 12);
         *  
         *  
         */

    }
}
