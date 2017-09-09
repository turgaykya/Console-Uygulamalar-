using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ondalık Sayı Giriniz : ");
            float sayı = float.Parse(Console.ReadLine());
            Console.WriteLine("float sayı: " + sayı);

            Console.WriteLine("Ondalık Sayı Giriniz : ");
            double sayı2 = double.Parse(Console.ReadLine());
            Console.WriteLine("double sayı: " + sayı2);

            Console.WriteLine("Ondalık Sayı Giriniz : ");
            decimal sayı3 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("decimal sayı: " + sayı3);





            Console.ReadLine();
        }
    }
}
