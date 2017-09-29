using System;

namespace Mod1
{
    class Student
    {
        public string Name { get; set; }

        public Student(string name)
        {
            this.Name = name;
            Console.WriteLine("Creating Student " + this.Name);
        }
    }
}
