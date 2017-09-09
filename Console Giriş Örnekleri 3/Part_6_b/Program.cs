using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_6_b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kullanıcıdan istenecek belirsiz miktardaki sayı içerisinden en büyük ve en küçük olanları tespit eden prog.");

            int enKüçük = int.MaxValue;
            int enBüyük = int.MinValue;
            int dogruSayi = 0;
            bool durum = true;
            bool durum2 = true;
            while (durum2)
            {
                while (durum)
                {
                    Console.Write("\nsayı girin: ");
                    string girilen = Console.ReadLine();
                    int çıkış;
                    bool başarılı = int.TryParse(girilen, out çıkış);
                    if (başarılı)
                    {
                        if (çıkış < enKüçük)
                        {
                            enKüçük = çıkış;
                        }
                        if (çıkış > enBüyük)
                        {
                            enBüyük = çıkış;
                        }
                        dogruSayi++;
                    }
                    else
                    {
                        if (girilen == "end")
                        {
                            if (dogruSayi >= 2)
                            {
                                durum = false;
                            }
                            else
                            {
                                Console.WriteLine("End için en az 2 sayı gerekir.");
                            }
                        }
                        else if (girilen == "exit")
                        {
                            durum = false;
                            durum2 = false;
                        }
                        else
                        {
                            Console.WriteLine("Lütfen sadece SAYI girin...");
                        }
                    }
                }
                Console.WriteLine("en küçük sayı: " + enKüçük);
                Console.WriteLine("en büyük sayı: " + enBüyük);
                dogruSayi = 0;
                durum = true;
                enKüçük = int.MaxValue;
                enBüyük = int.MinValue;
            }
            Console.ReadLine();
        }
    }
}
