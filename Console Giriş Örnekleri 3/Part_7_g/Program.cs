using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_7_g
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dizi = new string[5];

            Console.WriteLine("dizinin 1. elemanını girin: ");
            dizi[0] = Console.ReadLine();
            Console.WriteLine("dizinin 2. elemanını girin: ");
            dizi[1] = Console.ReadLine();
            Console.WriteLine("dizinin 3. elemanını girin: ");
            dizi[2] = Console.ReadLine();
            Console.WriteLine("dizinin 4. elemanını girin: ");
            dizi[3] = Console.ReadLine();
            Console.WriteLine("dizinin 5. elemanını girin: ");
            dizi[4] = Console.ReadLine();

            int sayac = 0;
            while (sayac < dizi.Length)
            {
                Console.WriteLine(dizi[sayac]);
                sayac++;      
            }
            Console.ReadLine();
        }
    }
}
