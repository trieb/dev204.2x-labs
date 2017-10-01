using System;


namespace Mod1
{
    class Course
    {
        public string Name { get; set; }
        public Student[] students = new Student[3];
        public Teacher[] teachers = new Teacher[3];

        public Course(string name)
        {
            this.Name = name;
            Console.WriteLine("Creating Course " + this.Name);
        }

        public void PrintInfo()
        {
            Console.WriteLine("Course: " + this.Name);
            Console.WriteLine("  Teachers (" + Teacher.numberOfTeachers + " st)");
            for ( int i=0; i < Teacher.numberOfTeachers; i++){
                Console.WriteLine("    " + i + ": " + teachers[i].FirstName + " " + teachers[i].LastName);
            }
            Console.WriteLine("  Students (" + Student.numberOfStudents + " st)");
            for ( int i=0; i < Student.numberOfStudents; i++){
                Console.WriteLine("    " + i + ": " + students[i].FirstName + " " + students[i].LastName);
            }
        }
    }
}
