using System;

namespace Mod1
{
    class Teacher
    {
        public string Name { get; set; }

        public Teacher(string name)
        {
            this.Name = name;
            Console.WriteLine("Creating Teacher " + this.Name);
        }
    }
}
