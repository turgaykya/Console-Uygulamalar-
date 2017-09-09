using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_6__ŞifreGizleme
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            string sifre = "";
            ConsoleKeyInfo giris;
            Console.WriteLine("//////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
            Console.WriteLine("|| Lorem Ipsum CRM System ||");
            Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\//////////////");
            Console.WriteLine("Lütfen kullanıcı adınızı ve parolanızı giriniz.");
            Console.Write("Kullanıcı Adı: ");
            string ad = Console.ReadLine();
            Console.Write("Parola: ");
            while (sayac<20)
            {
                giris = Console.ReadKey(true);

                if (giris.Key != ConsoleKey.Backspace)
                {
                    sifre += giris.KeyChar;
                    Console.Write("*");

                    if (giris.Key == ConsoleKey.Enter)
                    {
                        Console.WriteLine("\n-------------------");
                        Console.WriteLine("PAROLA TEST: " + sifre);
                        break;
                        
                    } 
                }
            }
            Console.ReadLine();
        }
    }
}
