namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    
    public class CoursesExamples
    {
        public static void Main()
        {
            LocalCourse localCourse = new LocalCourse(
                "Databases",
                "Bill Gates",
                new List<string> { "Tyrion", "Jon Snow" },
                "Testov Lab");
            Console.WriteLine(localCourse);

            localCourse.Lab = "Enterprise";
            Console.WriteLine(localCourse);

            localCourse.Students = new List<string> { "Peter", "Maria" };
            Console.WriteLine(localCourse);

            localCourse.TeacherName = "Svetlin Nakov";
            localCourse.Students.Add("Milena");
            localCourse.Students.Add("Todor");
            Console.WriteLine(localCourse);

            OffsiteCourse offsiteCourse = new OffsiteCourse(
                "PHP and WordPress Development", 
                "Mario Peshev", 
                new List<string> { "Thomas", "Ani", "Steve" },
                "Varna");
            Console.WriteLine(offsiteCourse);
        }
    }
}