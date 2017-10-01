using System;

namespace Mod1
{
    class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public static int numberOfTeachers = 0; 

        public Teacher(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            Console.WriteLine("Creating Teacher " + this.FirstName + " " + this.LastName);
            numberOfTeachers += 1;
        }
    }
}
