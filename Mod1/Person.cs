using System;

namespace Mod1
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public Person(string fname, string lname)
        {
            this.FirstName = fname;
            this.LastName = lname;
            Console.WriteLine("Creating Person " + this.FirstName + " " + this.LastName);
        }
    }
}
