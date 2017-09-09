using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1__SayiTahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekrar = "E";
            while (tekrar == "E" || tekrar == "e")
            {
                Console.WriteLine("SAYI TAHMIN OYUNU\n");
                Console.WriteLine("Lütfen aşağıdaki zorluk seviyelerinden birini seçiniz: ");
                Console.WriteLine("1. Kolay seviye için 1'i  tuşlayın");
                Console.WriteLine("2. Orta seviye için 2'yi tuşlayın");
                Console.WriteLine("3. Zor seviye için 3'ü tuşlayın");

                string giris = Console.ReadLine();
                int zorluk;
                bool kontrol = int.TryParse(giris, out zorluk);
                while (!kontrol || zorluk < 1 || zorluk > 3)
                {
                    Console.WriteLine("Yanlış bir giriş yaptınız!\n");
                    Console.WriteLine("Lütfen aşağıdaki zorluk seviyelerinden birini seçiniz: ");
                    Console.WriteLine("1. Kolay seviye için 1'i  tuşlayın");
                    Console.WriteLine("2. Orta seviye için 2'yi tuşlayın");
                    Console.WriteLine("3. Zor seviye için 3'ü tuşlayın");
                    giris = Console.ReadLine();
                    kontrol = int.TryParse(giris, out zorluk);
                }

                int a = 0;
                int b = 0;
                int rand = 0;
                int tahmin = 0;
                int fark = 0;
                int tahminSayisi = 0;
                float puan = 1000;


                if (zorluk == 1)
                {
                    a = 1;
                    b = 10;
                    ZorlukSeviyesi(a, b, out rand);
                }
                else if (zorluk == 2)
                {
                    a = 1;
                    b = 100;
                    ZorlukSeviyesi(a, b, out rand);
                }
                else
                {
                    a = 1;
                    b = 1000;
                    ZorlukSeviyesi(a, b, out rand);
                }
                Console.WriteLine("random sayımız = " + rand);


                if (zorluk == 1)
                {
                    while (rand != tahmin)
                    {
                        Console.Write("Tahmininizi yazınız: ");
                        giris = Console.ReadLine();
                        kontrol = int.TryParse(giris, out tahmin);
                        while (!kontrol || tahmin < 0)
                        {
                            Console.Write("0'dan büyük sayısal bir tahmin yapınız: ");
                            giris = Console.ReadLine();
                            kontrol = int.TryParse(giris, out tahmin);
                        }

                        fark = rand - tahmin;

                        if (rand == tahmin)
                        {
                            Console.WriteLine("\nTebrikler!! {0} doğru tahmin!\nOyunu {1} tahminde bitirdiniz.", rand, tahminSayisi + 1);
                            Console.WriteLine("Puanınız: {0}",puan / tahminSayisi);
                        }
                        else if (fark <= 2 && fark >= -2)
                        {
                            Console.WriteLine("Tahmininiz: {0}\t sıcak", tahmin);
                            tahminSayisi++;
                        }
                        else if (fark <= 4 && fark >= -4)
                        {
                            Console.WriteLine("Tahmininiz: {0}\t ılık", tahmin);
                            tahminSayisi++;

                        }
                        else
                        {
                            Console.WriteLine("Tahmininiz: {0}\t soğuk", tahmin);
                            tahminSayisi++;
                        }
                    }
                }
                else if (zorluk == 2)
                {
                    while (rand != tahmin)
                    {
                        Console.Write("Tahmininizi yazınız: ");
                        giris = Console.ReadLine();
                        kontrol = int.TryParse(giris, out tahmin);
                        while (!kontrol || tahmin < 0)
                        {
                            Console.Write("0'dan büyük sayısal bir tahmin yapınız: ");
                            giris = Console.ReadLine();
                            kontrol = int.TryParse(giris, out tahmin);
                        }

                        fark = rand - tahmin;

                        if (rand == tahmin)
                        {
                            Console.WriteLine("\nTebrikler!! {0} doğru tahmin!\nOyunu {1} tahminde bitirdiniz.", rand, tahminSayisi + 1);
                            Console.WriteLine("Puanınız: {0}", puan / tahminSayisi);
                        }
                        else if (fark <= 20 && fark >= -20)
                        {
                            Console.WriteLine("Tahmininiz: {0}\t sıcak", tahmin);
                            tahminSayisi++;
                        }
                        else if (fark <= 40 && fark >= -40)
                        {
                            Console.WriteLine("Tahmininiz: {0}\t ılık", tahmin);
                            tahminSayisi++;

                        }
                        else
                        {
                            Console.WriteLine("Tahmininiz: {0}\t soğuk", tahmin);
                            tahminSayisi++;
                        }
                    }
                }
                else
                {
                    while (rand != tahmin)
                    {
                        Console.Write("Tahmininizi yazınız: ");
                        giris = Console.ReadLine();
                        kontrol = int.TryParse(giris, out tahmin);
                        while (!kontrol || tahmin < 0)
                        {
                            Console.Write("0'dan büyük sayısal bir tahmin yapınız: ");
                            giris = Console.ReadLine();
                            kontrol = int.TryParse(giris, out tahmin);
                        }

                        fark = rand - tahmin;

                        if (rand == tahmin)
                        {
                            Console.WriteLine("\nTebrikler!! {0} doğru tahmin!\nOyunu {1} tahminde bitirdiniz.", rand, tahminSayisi + 1);
                            Console.WriteLine("Puanınız: {0}", puan / tahminSayisi);
                        }
                        else if (fark <= 200 && fark >= -200)
                        {
                            Console.WriteLine("Tahmininiz: {0}\t sıcak", tahmin);
                            tahminSayisi++;
                        }
                        else if (fark <= 400 && fark >= -400)
                        {
                            Console.WriteLine("Tahmininiz: {0}\t ılık", tahmin);
                            tahminSayisi++;

                        }
                        else
                        {
                            Console.WriteLine("Tahmininiz: {0}\t soğuk", tahmin);
                            tahminSayisi++;
                        }
                    }
                }

                Console.WriteLine("Tekrar oynamak istermisiniz?   E / H");
                tekrar = Console.ReadLine();
                
            }

        }

        // random hesaplayan fonksiyon
        static int ZorlukSeviyesi(int a, int b, out int randomSayi)
        {
            Random r = new Random();
            randomSayi = r.Next(a, b);

            return randomSayi;
        }
    }
}
