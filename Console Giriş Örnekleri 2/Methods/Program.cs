using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            long result = Square(10);

            int day, month, year;

            GetDateParts(out day, out month, out year);

            Console.WriteLine("Bugün {0} yılının {1}. ayının {2}. günüdür", year, month, day);

            
        }

        static void SayHello()
        {
            Console.WriteLine("Hello World");
        }

        static DateTime GetDate()
        {
            return DateTime.Today;
        }

        static void GetDateParts(out int d, out int m, out int y)
        {
            d = DateTime.Today.Day;
            m = DateTime.Today.Month;
            y = DateTime.Today.Year;
        }

        static long Square(int number)
        {
            long result = number * number;

            return result;
        }



    }
}
