using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExtensionMethod_LinQ
{
    // phải là static class
    internal static class ListExtension
    {
        //1- phải là static method
        //2- phải thêm 1 tham số nữa ,tham số đấy thể hiện kiểu dữ liệu của class mà ta đang muốn mở rộng
        //(ở đây là muốn mở rộng  class List<Course>
        // phải có this
        public static void Display(this List<Course> courses)
        {
            Console.WriteLine("list of course: ");
            foreach (Course c in courses)
                Console.WriteLine(c);
        }


    }
}
