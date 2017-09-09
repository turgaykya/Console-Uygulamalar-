using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionControlStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int number = int.Parse(input);

            int result = number % 2;

            // if - else

            bool isEven = result == 0;

            #region Karar kontrol yapısı
            if (isEven)
            {
                Console.WriteLine("Girdiğiniz sayı çifttir");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı tektir");
            } 
            #endregion


        }
    }
}
