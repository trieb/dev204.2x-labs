using System;

namespace Mod1
{
    class Student : Person
    {
        public int year = 0; 
        private static int numberOfStudents = 0; 
        
        public static int GetNumberOfStudents 
        {
            get 
            {
                return numberOfStudents;
            }
        }

        public Student(string fname, string lname, int year) : base(fname, lname)
        {
            this.year = year; 
            numberOfStudents += 1; 
        }

        public void TakeTest()
        {
            Console.WriteLine("Student is taking test");
        }
    }
}
