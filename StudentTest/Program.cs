using System;

namespace StudentTest
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Student s = new Student("Josh","Carolin");
            Console.WriteLine(s.Score);

            Student defaultStudent = new Student();
            Console.WriteLine(defaultStudent.FirstName);

        }
    }
}
