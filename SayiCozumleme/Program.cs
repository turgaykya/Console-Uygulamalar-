using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2__SayiCozumleme
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finish = true;
            while (finish)
            {
                string yazıylaSayı;
                Console.Write("Lütfen bir sayı giriniz: ");
                yazıylaSayı = Console.ReadLine();
                int sayi;
                bool kontrol = int.TryParse(yazıylaSayı, out sayi);
                if (yazıylaSayı == "exit")
                {
                    break;
                }

                while (!kontrol)
                {
                    Console.WriteLine("Doğru formatta bir sayı girmediniz!");
                    Console.Write("Lütfen bir sayı giriniz: ");
                    yazıylaSayı = Console.ReadLine();
                    kontrol = int.TryParse(yazıylaSayı, out sayi);
                    
                    if (yazıylaSayı == "exit")
                    {
                        break;
                    }
                }
                int basamakSayısı = 1;
                int rakam;
                int sayı = int.Parse(yazıylaSayı);

                while (sayı / Convert.ToInt32(Math.Pow(10, basamakSayısı - 1)) != 0)
                {
                    rakam = Convert.ToInt32(sayı % Math.Pow(10, basamakSayısı))
                        / Convert.ToInt32(Math.Pow(10, basamakSayısı - 1));
                    Console.WriteLine("{0} x {1} = {2}"
                        , rakam
                        , Math.Pow(10, basamakSayısı - 1)
                        , rakam * Math.Pow(10, basamakSayısı - 1)
                        );
                    basamakSayısı++;
                }
                Console.WriteLine("");
            }
       



        }
    }
}

