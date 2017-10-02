using System;

namespace Mod1
{
    class Teacher : Person
    {
        public static int numberOfTeachers = 0; 

        public Teacher(string firstName, string lastName) : base(firstName, lastName)
        {
            numberOfTeachers += 1;
        }

        public void GradeTest()
        {
            Console.WriteLine("Teacher is grading test");
        }
    }
}
