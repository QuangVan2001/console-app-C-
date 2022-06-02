using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.testapp
{
    internal class CourseList
    {
        List<Course> courses ;

        public CourseList()
        {
            courses = new List<Course>();
        }

        public void InputListOfCourse()
        {
            while (true)
            {
                Console.WriteLine("Course (C)? OnlineCourse(O)? Stop(S)");  
                string type =Console.ReadLine();
                if (type.ToUpper().Equals("S")) break;               
                Course c;
                if (type.ToUpper().Equals("C")) c = new Course();
                else c = new OnlineCourse();
                c.input();
                courses.Add(c);              
            }
        }

        public void ReadListOfCourseFromFile(String filename)
        {   
            courses.Clear();
            StreamReader reader = new StreamReader(filename);
            string line;
            while(( line = reader.ReadLine()) != null)
            {
                // 1 dòng trên file
                Course course;
                if(line[0] == 'C')
                {
                    course = new Course();
                }
                else { course = new OnlineCourse(); }
                course.ReadDataFromLine(line);
                courses.Add(course);
            }
            reader.Close();
        }

        public void InitData()
        {
            courses.Add(new Course(1, "PRJ", new DateTime(2022,1,1)));
            courses.Add(new Course(2, "OSG", new DateTime(2022, 1, 1)));
            courses.Add(new Course(3, "CSD", new DateTime(2022, 1, 1)));
            courses.Add(new Course(4, "PRO", new DateTime(2022, 1, 1)));

        }

        public void DisplayListOfCourse()
        {
            Console.WriteLine("List of Course:");
            foreach (Course c in courses)
                Console.WriteLine(c);
        }

        public void Search(DateTime startDate, DateTime endDate)
        {   
            Console.WriteLine("Danh sách các course tim duoc:");
            foreach (Course c in courses)
          
                if (c.StartDate >= startDate && c.StartDate <= endDate)
                    Console.WriteLine(c);
            
        }

        public void SearchByStartDate()
        {
            
            DateTime startDate = Validation.GetDateTime(new DateTime(2022, 1, 1),
                                                        new DateTime(2022, 12, 31),
                                                        "dd-MM-yyyy", "Nhập ngày bắt đầu:");
            
            DateTime endDate = Validation.GetDateTime(new DateTime(2022, 1, 1), new DateTime(2022, 12, 31), "dd-MM-yyyy", "Nhập ngày kết thúc:");
            Search(startDate, endDate);
        }

        public void Sort()
        {
            courses.Sort();
        }

        public void SortById()
        {
            courses.Sort(new IdComparer());
        }

        public void SortByStartDate()
        {
            courses.Sort(new StartDateComparer());
        }


        
         public void ReadListOfCourseFromFile1(String filename)
        {   
            courses.Clear();
            // using này với using trên là khác nhau
            // using dưới này là : biến khai báo tên reader trong cái mở ngoặc using nó chỉ có ý nghĩa
            //trong tập ngoặc nhọn của using này mà thôi
            // Khi nào hết ngoặc nhọn thì hết  phạm vi của biến reader
            //--> vì thế đến lúc này nó sẽ được thu hồi bộ nhớ, thu hồi các tài nguyên để triển khai biến reader này

            // CẤU TRÚC  using này được sử dụng trong vài trường hợp như sau:
            // - biến tốn nhiều tài nguyên, vùng nhớ --> dùng xong giải phóng luôn
            // không cần reader.close();--> vì nó đã tự thu hồi vùng nhớ
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // 1 dòng trên file
                    Course course;
                    if (line[0] == 'C')
                    {
                        course = new Course();
                    }
                    else { course = new OnlineCourse(); }
                    course.ReadDataFromLine(line);
                    courses.Add(course);
                }
            }
                
            
            
        }
         
    }
}
