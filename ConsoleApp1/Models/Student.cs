using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Student
    {   
        // private field
        int id;
        

        //property
        public int Id
        {   
            get { return id; }
            set {
                if( value > 0)
                    id = value;
                else
                    id = 0;
                 }
        }


        // cách viết tắt
        public string Name { get; set; } // cho phép get set trên 1 field ngầm định
                                          // nếu ở trên có String name; thì 2 cái này không liên quan gì đến nhau cả


        // khi 1 class không viết bất cứ hàm tạo nào thì hàm tạo không tham số được mặc định tạo ra
        // nó cấp phát không gian bộ nhớ cho các thành phần dữ liệu đối tượng

        // Khi 1 class được viết bất cứ 1 hàm tạo nào đó, cho dù hàm tạo này có bao nhiêu tham số đi nữa
        //->hàm tạo mặc định không tham số sẽ không được tạo ra nữa
        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Student()
        {
        }

        public void Display()
        {
            Console.WriteLine("Student: ID: " + Id + ", Name: " + Name);
            Console.WriteLine($"Student: ID:{Id}, Name:{Name}");
            Console.WriteLine(String.Format("Student: ID:{0}, Name:{1}", Id, Name));
            
        }

        public void Input()
        {
            Console.WriteLine(" Nhập ID: ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập Name: ");
            Name = Console.ReadLine();
          
        }
    }

    class SEStudent: Student
    {
        public String Skill { get; set; }

        public SEStudent()
        {
        }

        public SEStudent (int id, String name, String skill): base(id, name) // lời gọi hàm tạo lớp cha
        {
            Skill = skill;
            
        }

        public void Display()
        {
            base.Display();
            Console.WriteLine($"Skill: {Skill}");    
        }

        public void Input()
        {
            base.Input();
            Console.WriteLine("Nhập Skill: ");
            Skill = Console.ReadLine();
        }
    }

}
