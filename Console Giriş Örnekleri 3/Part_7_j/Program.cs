using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_7_j
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dizi boyutunu gir: ");
            string donus = Console.ReadLine();
            int diziBoy;
            bool kontrol = int.TryParse(donus, out diziBoy);

            while (!kontrol)
            {
                Console.WriteLine("Dizi boyutunu gir: ");
            donus = Console.ReadLine();
            kontrol = int.TryParse(donus, out diziBoy);
            }

            int[] dizi = new int[diziBoy];
            int sayac = 0;

            while (sayac < diziBoy)
            {
                Console.WriteLine("dizinin {0}. elemanını gir: ",sayac);
            donus = Console.ReadLine();
            int diziEleman;
            kontrol = int.TryParse(donus, out diziEleman);
            dizi[sayac] = diziEleman;
            while (!kontrol)
            {
                Console.WriteLine("dizinin {0}. elemanını gir: ",sayac);
                donus = Console.ReadLine();
                kontrol = int.TryParse(donus, out diziEleman);
                dizi[sayac] = diziEleman;
            }
            sayac++;
            }
            Console.WriteLine("Dizi Elemanları: ");
            sayac = 0;
            while (sayac < diziBoy)
            {
                Console.WriteLine(dizi[sayac]);
                sayac++;
            }

            Console.ReadLine();



        }
    }
}
