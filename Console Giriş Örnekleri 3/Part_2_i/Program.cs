using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_i
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ilk sayıyı girin: ");
            int sayı1 = int.Parse(Console.ReadLine());
            Console.Write("ikinci sayıyı girin: ");
            float sayı2 = float.Parse(Console.ReadLine());
            float toplam = sayı1 + sayı2;
            Console.WriteLine("Girdiğiniz {0} ve {1} sayısının toplamı {2} yapar.", sayı1, sayı2, toplam);

            Console.Write("ilk sayıyı girin: ");
            long sayı3 = long.Parse(Console.ReadLine());
            Console.Write("ikinci sayıyı girin: ");
            decimal sayı4 = decimal.Parse(Console.ReadLine());
            decimal toplam2 = sayı3 + sayı4;
            Console.WriteLine("Girdiğiniz {0} ve {1} sayısının toplamı {2} yapar.", sayı3, sayı4, toplam2);




            Console.ReadLine();
        }
    }
}
