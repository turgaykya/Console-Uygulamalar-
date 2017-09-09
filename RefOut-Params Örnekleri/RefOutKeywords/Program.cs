using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutKeywords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bölünen sayıyı yazın: ");
            string input1 = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Lütfen bölen sayıyı yazın: ");
            string input2 = Console.ReadLine();
            Console.WriteLine();

            int number = int.Parse(input1);
            int divisor = int.Parse(input2);
            int division;
            bool isSafe = SafeDivide(number, divisor, out division);
            if (isSafe == true)
            {
                Console.Write("{0} sayısının {1} sayısına bölümü: {2}", number, divisor, division);
            }
            else
            {
                Console.Write("Bu bölme işlemi güvenli değil");
            }
            Console.ReadLine();
        }
        static int Divide(int number, int divisor)
        {
            int result = number / divisor;
            return result;
        }

        static bool SafeDivide(int number, int divisor, out int result)
        {
            if (divisor == 0)
            {
                result = 0;
                return false;
            }
            else
            {
                result = number / divisor;
                return true;
            }
        }
    }
}
