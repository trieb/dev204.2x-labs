using System;

namespace Mod1
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public static int numberOfStudents = 0; 

        public Student(string fname, string lname)
        {
            this.FirstName = fname;
            this.LastName = lname;
            Console.WriteLine("Creating Student " + this.FirstName + " " + this.LastName);
            numberOfStudents += 1; 
        }
    }
}
