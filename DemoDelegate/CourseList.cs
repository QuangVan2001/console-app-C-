using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate
{
    internal class CourseList
    {
        List<Course> courses;

        public CourseList()
        {
            courses = new List<Course>();
        }


        public void InitData()
        {
            courses.Add(new Course(4, "PRJ", new DateTime(2022, 1, 7)));
            courses.Add(new Course(1, "OSG", new DateTime(2022, 1, 1)));
            courses.Add(new Course(3, "CSD", new DateTime(2022, 1, 5)));
            courses.Add(new Course(2, "PRO", new DateTime(2022, 1, 10)));

        }

        public void DisplayListOfCourse()
        {
            Console.WriteLine("List of Course:");
            foreach (Course c in courses)
                Console.WriteLine(c);

        }


        public int CompareByID(Course x, Course y)
        {
            return y.Id.CompareTo(x.Id);
        }

        public int CompareByTitle(Course x, Course y)
        {
            return x.Title.CompareTo(y.Title);  
        }
        public void SortByTitle()
        {
            courses.Sort(CompareByTitle);
        }

        public void SortById()
        {
            courses.Sort(CompareByID);
        }

        public int CompareByStartDate(Course x, Course y)
        {
            return (x.StartDate.CompareTo(y.StartDate));
        }
        public void SortByStartDate()
        {
            courses.Sort(CompareByStartDate);
        }

        public void SortbyStartDate2()
        {
            // anonymous function, không quan tâm tên hàm là gì, chỉ quan tâm nội dung công việc
            courses.Sort(
                delegate(Course x, Course y)
                {
                    return x.StartDate.CompareTo((y.StartDate));
                }
                );
        }

        public void SortByIdAno()
        {
            courses.Sort(
                delegate(Course x, Course y)
                {
                    return x.Id.CompareTo((y.Id));
                });

        }
        
        public void SortIdLamda()
        {
            courses.Sort((x,y) => x.Id.CompareTo(y.Id));
        }
        public void SortTitleAno()
        {
            courses.Sort(
                delegate(Course x, Course y)
                {
                    return x.Id.CompareTo(y.Id);
                });
        }
            
        public void SortTitleLamda()
        {
            courses.Sort((x, y) => x.Title.CompareTo(y.Title));
        }

        public void SortbyStartDatebyLamdaExpression()
        {
            //1- kiểu dữ liệu truyền vào thì không cần phải viết nữa
            //2- Nếu như hàm  không có đối số nào hoặc chỉ có 1 đối số  thì CÓ THỂ BỎ DẤU NGOẶC TRONF
            //3- Nếu như hàm có 1 câu lệnh thì không cần đóng mở ngoặc nhọn thay thế bằng dấu ( => ) và bỏ luôn dấu chấm phẩy (;)
            //  ( => ) dùng để phân tách tham số truyền vào và công việc cần thực hiện
            // bỏ luôn RETURN, VÀ delegate

            // dùng lamda expression để viết ngắn ngọn lại anonymous function ở trên
            courses.Sort(( x, y) =>  x.StartDate.CompareTo((y.StartDate)));
        }
    }
}
