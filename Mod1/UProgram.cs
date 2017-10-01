using System;

namespace Mod1
{
    class UProgram
    {
        public string Name { get; set; }
        public Degree degree { get; set;}

        public UProgram(string name)
        {
            this.Name = name;
            Console.WriteLine("Creating UProgram " + this.Name);
        }

        public void PrintInfo()
        {
            Console.WriteLine("===START===");
            Console.WriteLine("UProgram: " + this.Name);
            degree.PrintInfo();
            Console.WriteLine("===END===");
        }
    }
}
