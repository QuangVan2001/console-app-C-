using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExtensionMethod_LinQ
{
    internal static class CourseExtension
    {
        public static void Display(this Course course, int Count =1)
        {
            Console.WriteLine($"Course's info ({Count} times): ");
            for (int i = 0; i < Count; i++)
                Console.WriteLine(course);
        }
    }
}
