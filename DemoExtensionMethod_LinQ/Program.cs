using System;
using System.Collections.Generic;

namespace DemoExtensionMethod_LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DemoUsingListExtension();
            //DemoUsingCourseExtension();
            DemoUsingLinQ();
        }

        public static void DemoUsingListExtension()
        {
            List<Course> courses = new List<Course>
            {
                new Course(1, "PRN", new DateTime(2021, 1, 1)),
                new Course(2, "PRO", new DateTime(2021, 1, 10)),
                new Course(3, "PRJ", new DateTime(2021, 7, 1)),
            };

            courses.Display();
        }


        public static void DemoUsingCourseExtension()
        {
            Course course = new Course(1, "PRN", new DateTime(2022, 1, 1));
            course.Display(3);
        }


        public static void DemoUsingLinQ()
        {
            DemoLinQ demo = new DemoLinQ();
            Console.WriteLine("Get course by ID: ");
            demo.GetCoursebyIDUsingMethod(3).Display(4);
            Console.WriteLine();
            Console.WriteLine("Get course by Title:");
            demo.GetCousreByTitleUsingMethod("O").Display();
            Console.WriteLine();
            Console.WriteLine("Get course by StartDate:");
            demo.GetCourseByDateUsingMethod(new DateTime(2022, 01, 01), new DateTime(2022, 12, 31));



            Console.WriteLine("Get course by ID: ");
            demo.GetCoursebyIDUsingQuery(3).Display(4);
            Console.WriteLine();
            Console.WriteLine("Get course by Title:");
            demo.GetCousreByTitleUsingQuery("O").Display();
            Console.WriteLine();
            Console.WriteLine("Get course by StartDate:");
            demo.GetCourseByDateUsingQuery(new DateTime(2022, 01, 01), new DateTime(2022, 12, 31));
        }
    }
}
