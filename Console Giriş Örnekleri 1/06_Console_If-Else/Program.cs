using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Console_If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            //Karar Yapıları
            /*
             if(-koşul-)
              {
                   //Yapılacak işlemler
              }
              else
              {
                   //Yapılacak işlemler
              }
                
            */

            //Girilen sayının 10dan buyuk olup olmadıgını kontrol eden kodu yazınız.
            //int sayı;
            //Console.WriteLine("Bir sayı giriniz: ");
            //string girilenDeger = Console.ReadLine();
            //sayı = int.Parse(girilenDeger);
            //if (sayı > 10)
            //{
            //    Console.WriteLine("Sayı 10 dan büyük");
            //}
            //else
            //{
            //    if (sayı == 10)
            //    {
            //        Console.WriteLine("Sayı 10'a eşittir");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sayı 10 dan küçük");
            //    }
            //}
            #region
            // iki sınav notunun girilip ortalama nota gore 5 lik sistemden karne notunu belirleyen kodu yazınız.
            //----
            //int sayı, sayı2;
            //Console.WriteLine("ilk sınav notunu gir. ");
            //string not1 = Console.ReadLine();
            //sayı = int.Parse(not1);

            //Console.WriteLine("ilk sınav notunu gir. ");
            //string not2 = Console.ReadLine();
            //sayı2 = int.Parse(not2);

            //if ((sayı + sayı2) / 2 > 85)
            //{
            //    Console.WriteLine(((sayı + sayı2) / 2) + " ortalama ile geçti");
            //}
            //else
            //{
            //    if ((sayı + sayı2) / 2 > 70)
            //    {
            //        Console.WriteLine(((sayı + sayı2) / 2) + " ortalama ile geçti");
            //    }
            //    else
            //    {
            //        if ((sayı + sayı2) / 2 > 55)
            //        {
            //            Console.WriteLine(((sayı + sayı2) / 2) + " ortalama ile geçti");
            //        }
            //        else
            //        {
            //            if ((sayı + sayı2) / 2 > 45)
            //            {
            //                Console.WriteLine(((sayı + sayı2) / 2) + " ortalama ile geçti");
            //            }
            //            else
            //            {

            //                Console.WriteLine(((sayı + sayı2) / 2) + " ortalama ile KALDI");

            //            }
            //        }
            //    }
            //}
            #endregion

            int not1, not2, ortalama;
            Console.WriteLine("Bilal Soft size karne notu hesalpalada kolaylık sağlıyor!");
            Console.WriteLine("Ayrıca sistem oldukça basit! o_0");
            Console.WriteLine("_______________________________________");

            Console.WriteLine("ilk notu giriniz: ");
            not1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ilk notu giriniz: ");
            not2 = int.Parse(Console.ReadLine());

            ortalama = ((not1 + not2) / 2);

            if (ortalama > 0 && ortalama < 45)
            {
                Console.WriteLine("Karne notunuz : 1");
            }
            else if (ortalama > 0 && ortalama < 55)
            {
                Console.WriteLine("Karne notunuz : 2");
            }
            else if (ortalama > 0 && ortalama < 70)
            {
                Console.WriteLine("Karne notunuz : 3");
            }
            else if (ortalama > 0 && ortalama < 85)
            {
                Console.WriteLine("Karne notunuz : 4");
            }
            else if (ortalama > 0 && ortalama <= 100)
            {
                Console.WriteLine("Karne notunuz : 5");
            }
            else
            {
                Console.WriteLine("HATALI GIRIS");
            }






            Console.ReadKey();

        }
    }
}
