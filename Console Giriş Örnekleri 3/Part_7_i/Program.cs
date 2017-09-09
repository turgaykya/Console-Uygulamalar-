using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_7_i
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dizi Boyutubu gir: ");
            string gelenDeger = Console.ReadLine();
            int diziBoy;
            bool kontrol = int.TryParse(gelenDeger, out diziBoy);
            while (!kontrol || diziBoy == 0)
            {
                Console.WriteLine("Dizi Boyutubu gir: ");
                gelenDeger = Console.ReadLine();
                kontrol = int.TryParse(gelenDeger, out diziBoy);
            }

            string[] dizi = new string[diziBoy];

            int sayac = 0;
            string diziyeEkle;
            while (sayac < diziBoy)
            {
                Console.WriteLine("Dizinin {0}. elemanını gir: ",sayac);
                diziyeEkle = Console.ReadLine();
                dizi[sayac] = diziyeEkle;

                sayac++;
            }
            Console.WriteLine("Dizinin Elemanları: ");
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
