using System;

namespace DemoDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // DemoBasicDelegate();
            //DemoMulticast();
            DemoUsingComparison();
            //demodele();
        }

        public static int Add(int a, int b)
        {
            Console.WriteLine("Add function.");
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            Console.WriteLine("Sub function.");
            return a - b;
        }


        public static void Calculate(int x, int y, Calculation deobj)
        {// tính toán giữa int x, va y, nhưng người dùng không nói là tính toán gì
            // chỉ biết 1 công thức tính toán.
            // thì nó quyết định kiểm tra giá trị của x của y, logic bất kì gì đấy,
            //--> thỏa mãn điều kiện thì mới gọi deobj(x,y)
            // hàm nào được gọi thì không phải hàm Calculate quyết định mà  do người nào sử dụng hàm Calculate quyết định

            deobj(x, y);// đây là nơi quyết định gọi hàm


            // ý nghĩa của delegate là phân tách NƠI QUYẾT ĐỊNH GỌI HÀM  và NƠI QUYẾT ĐỊNH HÀM NÀO ĐƯỢC GỌI

        }

        
        public static void DemoBasicDelegate()
        {
            Calculation delegateobj; // khai báo 1 biến có kiểu Calculation
            delegateobj = new Calculation(Add);
            Console.WriteLine("Output: " + delegateobj(5, 4)); // lời gọi Add(5,4)

            delegateobj = Sub;// cách viết ngắn ngọn để thay cho new Calcultion(Sub)
            Console.WriteLine("Output: " + delegateobj(7, 3));// lời gọi Sub(7,3)

            Calculate(10, 20, Add);// nơi quyết định hàm  nào được gọi
        }

        public static void demodele()
        {
            Calculation deobj;
            deobj = Sub;
            Console.WriteLine("out put: " + deobj(7, 7));

            Calculate(6, 7, Add);
        }
        public static void DemoMulticast()
        {
            Console.WriteLine("DemoMutilcast: ");
            Calculation delegateobj = Add;
            delegateobj += Sub; // thêm hàm Sub  vào danh sách các hàm được gọi
            delegateobj += Add; // thêm hàm Add  vào danh sách các hàm được gọi
            Console.WriteLine("Output: " + delegateobj(5, 4));// lời gọi lần lượt các hàm: Add(5,4), Sub(5,4)

            Console.WriteLine("After remove:");
            delegateobj -= Add; // remove hàm add sau cùng trong danh sachs các hàm được gọi
            delegateobj -= Add;
            delegateobj -= Add;// remove thừa cũng chả sao

            delegateobj -= Sub; // Nó chả biết thực thi hàm nào---> xuất hiện exception (NULLREferenceEx..)
            Console.WriteLine("Output: " + delegateobj(5, 4));// phát sinh lỗi runtime vì delegateibj không chỉ vào hàm nào
        }


        public static void DemoUsingComparison()
        {
            CourseList courseList = new CourseList();
            courseList.InitData();
            Console.WriteLine("Sort by Id: ");
            courseList.SortById();
            courseList.DisplayListOfCourse();
            Console.WriteLine();
            Console.WriteLine("Sort by Title: ");
            courseList.SortByTitle();
            courseList.DisplayListOfCourse();
            Console.WriteLine();
            Console.WriteLine("Sort by StartDate: ");
            courseList.SortByStartDate();
            courseList.DisplayListOfCourse();

            Console.WriteLine();
            Console.WriteLine("Sort by StartDate: ");
            courseList.SortbyStartDate2();
            courseList.DisplayListOfCourse();
        }
    }
}

