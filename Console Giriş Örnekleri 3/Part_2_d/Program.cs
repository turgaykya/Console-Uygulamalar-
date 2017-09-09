using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_d
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ilk sayıyı girin: ");
            int sayı1 = int.Parse(Console.ReadLine());
            Console.Write("ikinci sayıyı girin: ");
            int sayı2 = int.Parse(Console.ReadLine());
            int toplam = sayı1 / sayı2;
            Console.WriteLine("Girdiğiniz {0} ve {1} sayısının bölümü {2} yapar.", sayı1, sayı2, toplam);

            Console.Write("ilk sayıyı girin: ");
            short sayı3 = short.Parse(Console.ReadLine());
            Console.Write("ikinci sayıyı girin: ");
            short sayı4 = short.Parse(Console.ReadLine());
            short toplam2 = (short)(sayı3 / sayı4);
            Console.WriteLine("Girdiğiniz {0} ve {1} sayısının bölümü {2} yapar.", sayı3, sayı4, toplam2);

            Console.Write("ilk sayıyı girin: ");
            long sayı5 = long.Parse(Console.ReadLine());
            Console.Write("ikinci sayıyı girin: ");
            long sayı6 = long.Parse(Console.ReadLine());
            long toplam3 = sayı5 / sayı6;
            Console.WriteLine("Girdiğiniz {0} ve {1} sayısının bölümü {2} yapar.", sayı5, sayı6, toplam3);

            Console.Write("ilk sayıyı girin: ");
            byte sayı7 = byte.Parse(Console.ReadLine());
            Console.Write("ikinci sayıyı girin: ");
            byte sayı8 = byte.Parse(Console.ReadLine());
            byte toplam4 = (byte)(sayı7 / sayı8);
            Console.WriteLine("Girdiğiniz {0} ve {1} sayısının bölümü {2} yapar.", sayı7, sayı8, toplam4);

            Console.ReadLine();
        }
    }
}
