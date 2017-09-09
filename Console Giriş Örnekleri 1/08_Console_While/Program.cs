using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Console_While
{
    class Program
    {
        static void Main(string[] args)
        {
            //Döngüler

            /*
              while (-koşul-)
              {
                   işlemler;
              }
             
            */

            // 1'den 20 ye kadarki sayıları alt alta yazdıran programı yazınız.
            /*

            int sayı = 1;
            while(sayı <= 20)
            {
            Console.WriteLine(sayı);
            sayı++;
            }
              
             */

            // 100 e kadar olan çift sayıların toplamı kaçtır?
            // PART 1
            //int toplam = 1;
            //int sayı = 0;
            //while (sayı <= 100)
            //{
            //    if (sayı % 2 == 0)
            //    {
            //        toplam = sayı + toplam;
            //    }
            //    sayı++;
            //}
            //    // PART 2
            ////while (sayı < 100)
            ////{
            ////    toplam = toplam + sayı;
            ////    sayı = sayı + 2;
            ////}

            //    // PART 3
            ////while (true)
            ////{
            ////    if (sayı % 2 == 0)
            ////    {
            ////        toplam = toplam + sayı;                 // Kullanışlı değil.
            ////    }
            ////    sayı++;
            ////    if (sayı > 99)
            ////    {
            ////        break;
            ////    }
            ////}

            //Console.WriteLine("Toplam: {0}",toplam);



            ////////// Do-While

            /*
             * do{
             *         Yapılacak işlemler
             *   }while(-koşul-)
            */

            // Girilen şifrenin doğru olup olmadıgını kontrol eden kodu yazınız.Doğru değilse yeniden girilmesini isteyiniz.

            //string sifre = "Burak123";
            //string kullanıcınınGirdiğiŞifre = null;
            //Console.WriteLine("Selam Kullanıcı. Lütfen şifreyi giriniz: ");
            // PART 1
            //do      
            //{
            //    kullanıcınınGirdiğiŞifre = Console.ReadLine();
            //} while (sifre != kullanıcınınGirdiğiŞifre);


            // PART 2
            //do
            //{
            //    if (kullanıcınınGirdiğiŞifre != null)
            //        Console.WriteLine("Tekrar giriniz : ");
            //    kullanıcınınGirdiğiŞifre = Console.ReadLine();
            //} while (sifre != kullanıcınınGirdiğiŞifre);


            //Console.WriteLine("Kullanıcı girişi başarılı ! ");
            //Console.ReadKey();



            // Kullanıcıdan sınıf mevcudu alıp, sınıftakilerin isimlerini tek tek isteyip, isim girişi bittikten sonra sınıftakilerin adını aralarına virgül koyarak yazdırınız.



            //Console.Write("Sınıf mevcudunu giriniz: ");
            //int sınıfMevcudu = int.Parse(Console.ReadLine());
            //int GirilenOgrenci = 0;
            //string ogrenciler = "";
           
                    //PART 1
            //do
            //{
            //    ogrenciler = ogrenciler + Console.ReadLine() + ", ";
            //    GirilenOgrenci++; 
            //} while (GirilenOgrenci < sınıfMevcudu);

                    //PART 2
            //while (GirilenOgrenci < sınıfMevcudu)
            //{
            //    ogrenciler = ogrenciler + Console.ReadLine() + ", ";
            //    GirilenOgrenci++; 
            //}
            
            // Kullanıcı sınıf mevcudu girmeden yapın

           /*
            
            string hepsi = "";
            string deger = "";
            Console.WriteLine("isim gir.");
            while(true)
            {
                deger = Console.ReadLine();
                
                if (deger == "SON")
                {
                    break;
                }
                hepsi = hepsi + deger + ", ";
           
             Console.WriteLine(hepsi);

           */

            // PART 2

            //string adSoyad = "";
            //string sınıftakiler = "";

            //Console.WriteLine("Çıkış için 0");

            //while(adSoyad != "0")
            //{
            //    Console.Write("Ad Soyad: ");
            //    adSoyad = Console.ReadLine();

            //if(adSoyad != "0")
            //{
            //    sınıftakiler = sınıftakiler + adSoyad + ", ";
            //}
            //}


            //Console.WriteLine(sınıftakiler);
            //Console.ReadKey();
            

   //-------------------------------------------------------------------------------------000

            // 1

           // int s1 = 0;
           // int s2 = 0;
           
           //while(s1 < 5)
           //{
           //    s2 = 0;
           // while(s2 < 5)
           // {
           //     Console.Write("*");
           //     s2 = s2 + 1;
           // }
           // Console.Write("\n");
           // s1 = s1 + 1;

           //}
           //Console.ReadLine();


                    // 2           

            // int satir = 0;
            // int sutun = 0;

            //while(satir < 5)
            //{
            //while(sutun < 5)
            //{
            //if(satir == 0 || satir == 4 || sutun == 0 || sutun == 4)
            //{
            //Console.Write("*");
            //}
            //else{
            //Console.Write(" ");
            //}
            //    sutun ++;
            //}
            //    Console.Write("\n");
            //    satir++;
            //    sutun =0;
            //}
            //Console.ReadLine();



                // 3

            //int satir = 0;
            //int sutun = 0;

            //while(satir < 5)
            //{
            //    while(sutun < satir + 1)
            //    {
            //        Console.Write("*");
            //        sutun = sutun + 1;
            //    }
            //    Console.Write("\n");
            //    sutun = 0;
            //    satir++;
            //}
            //Console.ReadLine();

            #region

            // 1 - 4 basamaklı bir sayıyı basamaklarına aşağıdaki gibi ayırınız.
                // 345
                // 5 x 1 = 5
                // 4 x 10 = 40
                // 3 x 100 = 300

            //string yazıylaSayı = Console.ReadLine();

            //int sayıUzunluğu = yazıylaSayı.Length;
            //int basamakSayısı = 1;
            //int rakam;
            //int sayı = int.Parse(yazıylaSayı);

            //while(sayıUzunluğu >= basamakSayısı)
            //{
            //    rakam = Convert.ToInt32(sayı % Math.Pow(10, basamakSayısı))
            //        / Convert.ToInt32(Math.Pow(10, basamakSayısı - 1));
            //    Console.WriteLine("{0} x {1} = {2}"
            //        , rakam
            //        , Math.Pow(10, basamakSayısı - 1)
            //        , rakam * Math.Pow(10, basamakSayısı - 1)
            //        );

            //    basamakSayısı++;

            //}

            #endregion

            string yazıylaSayı = Console.ReadLine();

            //int sayıUzunluğu = yazıylaSayı.Length;
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




            Console.ReadLine();
        }
    }
}
