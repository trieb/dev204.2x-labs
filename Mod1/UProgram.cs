using System;

namespace Mod1
{
    class UProgram
    {
        String Name = "";

        public UProgram(string name)
        {
            this.Name = name;
            Console.WriteLine("Creating UProgram " + this.Name);
        }
    }
}
