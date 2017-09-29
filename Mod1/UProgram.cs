using System;

namespace Mod1
{
    class UProgram
    {
        public string Name { get; set; }

        public UProgram(string name)
        {
            this.Name = name;
            Console.WriteLine("Creating UProgram " + this.Name);
        }
    }
}
