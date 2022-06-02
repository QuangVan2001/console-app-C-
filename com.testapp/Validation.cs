using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.testapp
{
    internal class Validation
    {
        public static int GetInteger(int min, int max, string mess)
        {
            int value;
            while (true)
            {
                try
                {
                    Console.WriteLine(mess);
                    value = Convert.ToInt32(Console.ReadLine());
                    if (value < min || value > max) throw new OverflowException("Vượt quá số lượng.");
                    return value;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nhập sai format.Nhập lại.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Số nhập vào  vượt quá phạm vi.Nhập lại");
                }
            }
        }


        public static string GetString(int minLength, int maxLength, string mess)
        {
            string value;
            while (true)
            {
                Console.WriteLine(mess);
                value = Console.ReadLine().Trim();
                if (value.Length <= maxLength && value.Length >= minLength) return value;
                Console.WriteLine("Độ dài chuỗi chưa hợp lệ. Nhập lại");
            }
        }

        public  static DateTime GetDateTime(DateTime minDate, DateTime maxDate, string pattern, string mess)
        {   
            DateTime value;
            while (true)
            {
                try
                {
                    Console.WriteLine(mess);
                    value = DateTime.ParseExact(Console.ReadLine(), pattern, null);
                    if (value < minDate || value > maxDate) throw new OverflowException(" Vượt quá phạm vi cho phép.");
                    return value;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nhập sai định dạng.Nhập lại");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Số nhập vào vượt qua phạm vi.Nhập lại.");
                }
            }
        }

        
    }
}
