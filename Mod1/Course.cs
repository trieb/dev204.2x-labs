using System;

namespace Mod1
{
    class Course
    {
        public string Name { get; set; }

        public Course(string name)
        {
            this.Name = name;
            Console.WriteLine("Creating Course " + this.Name);
        }
    }
}
