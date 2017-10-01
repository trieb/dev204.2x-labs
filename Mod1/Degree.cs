using System;

namespace Mod1
{
    class Degree
    {
        public string Name { get; set; }
        public Course course { get; set; }

        public Degree(string name)
        {
            this.Name = name;
            Console.WriteLine("Creating Degree " + this.Name);
        }

        public void PrintInfo()
        {
            Console.WriteLine("Degree: " + this.Name);
            course.PrintInfo();
        }
    }
}
