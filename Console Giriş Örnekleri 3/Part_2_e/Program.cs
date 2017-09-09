using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_e
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ilk sayıyı girin: ");
            float sayı1 = float.Parse(Console.ReadLine());
            Console.Write("ikinci sayıyı girin: ");
            float sayı2 = float.Parse(Console.ReadLine());
            float toplam = sayı1 + sayı2;
            Console.WriteLine("Girdiğiniz {0} ve {1} sayısının toplamı {2} yapar.", sayı1, sayı2, toplam);

            Console.Write("ilk sayıyı girin: ");
            decimal sayı3 = decimal.Parse(Console.ReadLine());
            Console.Write("ikinci sayıyı girin: ");
            decimal sayı4 = decimal.Parse(Console.ReadLine());
            decimal toplam2 = sayı3 + sayı4;
            Console.WriteLine("Girdiğiniz {0} ve {1} sayısının toplamı {2} yapar.", sayı3, sayı4, toplam2);

            Console.Write("ilk sayıyı girin: ");
            double sayı5 = double.Parse(Console.ReadLine());
            Console.Write("ikinci sayıyı girin: ");
            double sayı6 = double.Parse(Console.ReadLine());
            double toplam3 = sayı5 + sayı6;
            Console.WriteLine("Girdiğiniz {0} ve {1} sayısının toplamı {2} yapar.", sayı5, sayı6, toplam3);



            Console.ReadLine();
        }

    }
}
