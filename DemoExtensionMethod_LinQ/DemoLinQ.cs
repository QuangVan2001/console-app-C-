using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExtensionMethod_LinQ
{
    internal class DemoLinQ
    {
        List<Course> courses;
        public DemoLinQ()
        {
            courses = new List<Course>
            {
                new Course(1, "PRN", new DateTime(2021, 1, 1)),
                new Course(2, "PRO", new DateTime(2021, 1, 10)),
                new Course(3, "PRJ", new DateTime(2021, 7, 1)),
                new Course(4, "CSD", new DateTime(2022, 1, 1)),
                new Course(5, "OSG", new DateTime(2022, 1, 10)),
                new Course(6, "ITE", new DateTime(2022, 7, 1)),
            };
        }

        public List<Course> GetAllCourses()
        {
            return courses;
        }

        public Course GetCoursebyIDUsingMethod(int ID)
        {
            return  courses.First(x => x.Id == ID);
        }

        public List<Course> GetCousreByTitleUsingMethod(string pattern)
        {
            return courses.Where(x => x.Title.Contains(pattern)).ToList();
        }

        public void GetCourseByDateUsingMethod(DateTime start, DateTime end)
        {
            var result = courses.Where(x => x.StartDate >= start && x.StartDate <= end)
                .Select(x => (x.Title, x.StartDate));
            foreach(var item in result)
                Console.WriteLine($"{item.Title} - {item.StartDate}");
        }


        // Viết từ From --> WHERe--> SELECT
        public Course GetCoursebyIDUsingQuery(int ID)
        {
            return (from c in courses
                    where c.Id == ID
                    select c).First();
        }

        public List<Course> GetCousreByTitleUsingQuery(string pattern)
        {
            return (from c in courses
                    where c.Title.Contains(pattern)
                    select c).ToList();
        }

        public void GetCourseByDateUsingQuery (DateTime start, DateTime end)
        {
            var result = (from c  in courses
                          where c.StartDate >=  start  && c.StartDate <= end
                          select c);
            foreach (var item in result)
                Console.WriteLine($"{item.Title}-{item.StartDate}");
        }
    }
}
