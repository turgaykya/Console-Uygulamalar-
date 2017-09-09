using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tam Sayı Giriniz : ");
            int sayı = int.Parse(Console.ReadLine());
            Console.WriteLine("int sayı: " + sayı);

            Console.WriteLine("Tam Sayı Giriniz : ");
            byte sayı2 = byte.Parse(Console.ReadLine());
            Console.WriteLine("byte sayı: " + sayı2);

            Console.WriteLine("Tam Sayı Giriniz : ");
            short sayı3 = short.Parse(Console.ReadLine());
            Console.WriteLine("short sayı: " + sayı3);

            Console.WriteLine("Tam Sayı Giriniz : ");
            long sayı4 = long.Parse(Console.ReadLine());
            Console.WriteLine("long sayı: " + sayı4);

            Console.ReadLine();


        }
    }
}
