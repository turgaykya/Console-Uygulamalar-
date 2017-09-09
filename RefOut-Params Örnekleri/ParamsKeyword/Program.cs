using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Sum(5,6,7,7,5,2,23,6,76,5);
            Console.WriteLine("sayıların toplamı : " + result);
            Console.ReadLine();
        }
        // Params ile birlikte başka tipte parametrelerde fonksiyona alınabilir.
        // params ifadesi parametre tanımlarının mutlaka sonuncusu olmalıdır.
        // Bir fonksiyonda en fazla 1 adet params kullanılabilir.
        // Params argüman(günderilen değer) almak zorunda değildir.
        static int Sum(params int[] numbers)
        {
            int total = 0;
            int index = 0;
            while (index < numbers.Length)
            {
                total = total + numbers[index];
                index += 1;
            }
            return total;
        }
    }
}
