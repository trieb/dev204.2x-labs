using System;

namespace Mod1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mod1 - Lab");

            // 1) Add 3 students 
            Student student1 = new Student("Mikael", "Trieb", 7);
            Student student2 = new Student("Adam", "Smith", 8);
            Student student3 = new Student("Napoleon", "Hill", 9);
            
            // 2) Instantiate a course called Programming with C#
            Course course = new Course("Programming with C#");

            // 3) Add the students to this course 
            course.students[0] = student1;
            course.students[1] = student2;
            course.students[2] = student3;

            // 4) Instatiate one teacher
            Teacher teacher = new Teacher("Benny", "Hill");

            // 5) Add the teacher to the course
            course.teachers[0] = teacher;

            // 6) Add a degree, such as a Backelor
            Degree degree = new Degree("Bachelor");

            // 7) Add the course to the degree 
            degree.course = course;

            // 8) Instantiate a UProgram 
            UProgram uprogram = new UProgram("Information Technology");

            // 9) Add the degree to the UProgram
            uprogram.degree = degree;

            // 10) Print information about the UProgram
            uprogram.PrintInfo();


            // Module 3 
            student1.WriteDetails("details1.txt");
            student2.WriteDetails("details2.txt");
            student3.WriteDetails("details3.txt");

            student1.Dispose();
            student2.Dispose();
            student3.Dispose();
        }

    }
}
