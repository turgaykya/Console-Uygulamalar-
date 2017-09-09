using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_7_h
{
    class Program
    {
        static void Main(string[] args)
        {



            int[] dizi = new int[5];

            Console.WriteLine("dizinin 1. elemanını girin: ");
            string sayı1 = Console.ReadLine();
            int number1;
            bool durum = int.TryParse(sayı1, out number1);



            if (durum)
            {
                dizi[0] = number1;
            }
            else
            {
                while (!durum)
                {
                    Console.WriteLine("hatalı giriş...");

                    Console.WriteLine("dizinin 1. elemanını girin: ");
                    sayı1 = Console.ReadLine();
                    durum = int.TryParse(sayı1, out number1);
                }
                dizi[0] = number1;
            }




            Console.WriteLine("dizinin 2. elemanını girin: ");
            string sayı2 = Console.ReadLine();
            int number2;
            bool durum2 = int.TryParse(sayı2, out number2);
            if (durum2)
            {
                dizi[1] = number2;
            }
            else
            {
                Console.WriteLine("Hatalı Giriş...");
                while (!durum2)
                {
                    Console.WriteLine("dizinin 2. elemanını girin: ");
                    sayı2 = Console.ReadLine();
                    durum2 = int.TryParse(sayı2, out number2);
                }
                dizi[1] = number2;
            }




            Console.WriteLine("dizinin 3. elemanını girin: ");
            string sayı3 = Console.ReadLine();
            int number3;
            bool durum3 = int.TryParse(sayı3, out number3);
            if (durum3)
            {
                dizi[2] = number3;
            }
            else
            {
                Console.WriteLine("Hatalı Giriş...");
                while (!durum3)
                {
                    Console.WriteLine("dizinin 3. elemanını girin: ");
                    sayı3 = Console.ReadLine();
                    durum3 = int.TryParse(sayı3, out number3);
                }
            }




            Console.WriteLine("dizinin 4. elemanını girin: ");
            string sayı4 = Console.ReadLine();
            int number4;
            bool durum4 = int.TryParse(sayı4, out number4);
            if (durum4)
            {
                dizi[3] = number4;
            }
            else
            {
                Console.WriteLine("Hatalı Giriş...");
                while (!durum4)
                {
                    Console.WriteLine("dizinin 4. elemanını girin: ");
                    sayı4 = Console.ReadLine();
                    durum4 = int.TryParse(sayı4, out number4);
                }
            }







            Console.WriteLine("dizinin 5. elemanını girin: ");
            string sayı5 = Console.ReadLine();
            int number5;
            bool durum5 = int.TryParse(sayı5, out number5);
            if (durum5)
            {
                dizi[4] = number5;
            }
            else
            {
                Console.WriteLine("Hatalı Giriş...");
                while (!durum5)
                {
                    Console.WriteLine("dizinin 5. elemanını girin: ");
                    sayı5 = Console.ReadLine();
                    durum5 = int.TryParse(sayı5, out number5);
                }
            }

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
