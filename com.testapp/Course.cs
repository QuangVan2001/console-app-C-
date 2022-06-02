using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.testapp
{
    internal class Course : IComparable<Course>
    {   
        
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }

        public Course()
        {
        }

        public Course(int id, string title, DateTime startDate)
        {
            Id = id;
            Title = title;
            StartDate = startDate;
        }

        public override string ToString()
        {
            return $"{Id} - { Title} - {StartDate.ToString("dd-MM-yyyy")}";
        }

        public virtual void input()
        {
            Console.WriteLine("Nhập thông tin course:");
            Id = Validation.GetInteger(0, 20000, "Nhập Id:");
            Title = Validation.GetString(1, 100, "Nhập Title:");      
            StartDate = Validation.GetDateTime(new DateTime(2022, 1, 1), new DateTime(2022, 12, 31), "dd-MM-yyyy", "Nhập ngày bắt đầu:");
        }

        public virtual void ReadDataFromLine(string line)// line có format : C| Id| Tittle|StartDate
        {
            string[] items = line.Split("|");
            Id = Convert.ToInt32(items[1]);
            Title = items[2];
            StartDate = Convert.ToDateTime(items[3]);
        }

        public int CompareTo(Course other)
        {
            return this.Title.CompareTo(other.Title);
        } 
    }


    class OnlineCourse : Course
    {

        // cách viết tắt
        public string Meet { get; set; }// cho phép get set trên 1 field ngầm định
                                        // nếu ở trên có String name; thì 2 cái này không liên quan gì đến nhau cả

        // khi 1 class không viết bất cứ hàm tạo nào thì hàm tạo không tham số được mặc định tạo ra
        // nó cấp phát không gian bộ nhớ cho các thành phần dữ liệu đối tượng

        // Khi 1 class được viết bất cứ 1 hàm tạo nào đó, cho dù hàm tạo này có bao nhiêu tham số đi nữa
        //->hàm tạo mặc định không tham số sẽ không được tạo ra nữa
        public OnlineCourse()
        {
        }

        public OnlineCourse(int id, string title, DateTime StartDate, string meet): base(id, title, StartDate)
        {
            Meet = meet;
        }

        public override string ToString()
        {
            return base.ToString() + $"{Meet}";
        }

        public override void input()
        {
            base.input();
            Console.WriteLine("Link Meet:");
            Meet = Console.ReadLine();
        }

        /* public void Display()
         {
             Console.WriteLine("Student: ID: " + Id + ", Name: " + Name);
             Console.WriteLine($"Student: ID:{Id}, Name:{Name}");
             Console.WriteLine(String.Format("Student: ID:{0}, Name:{1}", Id, Name));

         }*/

        public override void ReadDataFromLine(string line)// line có format : Id| Tittle|StartDate | meet
        {
            int lastindex = line.LastIndexOf('|');
            base.ReadDataFromLine(line.Substring(0, lastindex));
            Meet = line.Substring(lastindex + 1);
        }

    }
}
