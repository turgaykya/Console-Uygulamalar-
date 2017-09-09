using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_8_a
{
    class Program
    {
        static void Main(string[] args)
        {

            // Metotlar Aşağıdadır. Devamına sürem yetmedi hocam.

        }

        static void PrintDateTime()
        {
            Console.WriteLine(DateTime.Now);
        }
        static void PrintStar()
        {
            Console.WriteLine("*");
        }
        static void PrintStar(int StarCount)
        {
            int sayac = 0;
            while (sayac < StarCount)
            {
                Console.Write("*");
                sayac++;
            }
        }
        static void NewLine()
        {
            Console.WriteLine("");
        }
        static void NewLine(int LineCount)
        {
            int sayac = 0;
            while (sayac < LineCount)
            {
                Console.WriteLine("");
                sayac++;
            }
        }
        static void PrintArray(int[] numbers)
        {
            int sayac = 0;
            while (sayac < numbers.Length)
            {
                Console.WriteLine(numbers[sayac]);
                sayac++;
            }
        }
        static void PrintArray(int[] numbers, char direction)
        {

            int sayac = 0;

            if ('v' == direction)
            {
                while (sayac < numbers.Length)
                {
                    Console.WriteLine(numbers[sayac]);
                    sayac++;
                }
            }
            else if ('h' == direction)
            {
                while (sayac < numbers.Length)
                {
                    Console.Write(numbers[sayac] + "\t");
                    sayac++;
                }
            }
        }
    }
}