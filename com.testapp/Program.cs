using System;

namespace com.testapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CourseList courseList = new CourseList();
            //courseList.InputListOfCourse();
            //courseList.InitData();
            courseList.ReadListOfCourseFromFile(@"textfile1.txt");
            courseList.DisplayListOfCourse();
            //courseList.SearchByStartDate();
            courseList.Sort();
            courseList.DisplayListOfCourse();

        }
    }
}
