using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Console_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array (Diziler)

            int sayi = 6;
            string metin = "diziler";

            //Bir sınıfa ait kişilerin isimleri:
            //string adSoyad1, adSoyad2, adSoyad3 ... adSoyadN

            //Bir sınıftaki kişilerin not ortalamaları : 

            int[] sınıfNotları = new int[15];
            sınıfNotları[0] = 30;
            sınıfNotları[1] = 29;
            sınıfNotları[2] = 79;
            sınıfNotları[3] = 11;
            sınıfNotları[4] = 100;
            sınıfNotları[14] = 1;
            sınıfNotları[5] = 12;
            sınıfNotları[6] = 123;
            sınıfNotları[7] = 14;

            //Console.WriteLine(sınıfNotları[0]);
            //Console.WriteLine(sınıfNotları[2]);
            //Console.WriteLine(sınıfNotları[3]);
            //Console.WriteLine(sınıfNotları[4]);
            //Console.WriteLine(sınıfNotları[12]);
            //Console.WriteLine(sınıfNotları[9]);

            //int index = 0;
            //while (index < 15) {
            //    Console.WriteLine(sınıfNotları[index]);
            //    index++;
            //}

            //---------------------
            //int a = new int();
            //Console.WriteLine(a);
            //---------------------

            //int[] sınıfNotları = new int15[];

            //int[] sınıfNotları2 = new int[10] { 2, 5, 9, 0, 11 ,23, 44 ,53, 100 ,10 };
            //int[] sınıfNotları3 = new[] {2, 5, 9, 0, 11, 2, 3, 44, 53, 100, 10};
            //int[] sınıfNotları4 = { 2, 5, 9, 0, 11, 2, 3, 44, 53, 100, 10 };

            //string[] mevsimler = new string[4] { "ilkbahar", "yaz", "sonbahar", "kış" };

            //int index = 0;
            //while (index < mevsimler.Length)
            //{
            //    Console.WriteLine(mevsimler[index]);
            //    index++;
            //}

            //1//
            // 10 elemanlı bir sayı dizisinin ortalamasını hesaplayınız.
            //int[] OnElemanlıDizi = new int[10] { 2, 5, 9, 0, 11, 23, 44, 53, 100, 10 };
            //int index2 = 0;
            //int toplam = 0;
            //while (index2 < OnElemanlıDizi.Length)
            //{
            //    toplam = toplam + OnElemanlıDizi[index2];
            //    index2++;
            //}
            //Console.WriteLine("Ortalama : " + toplam/OnElemanlıDizi.Length);
            //Console.ReadKey();

            //2//
            // 5 elemanlı bir sayı dizisini büyükten küçüğe sıralayınız.


int[] dizi = {2, 7, 5, 2, 19};
int sayac = 0;
int kova;
bool durum = true;

//while(durum)
//{
//    durum = false;
//    while(sayac < dizi.Length - 1)
//    {
//        if(dizi[sayac] > dizi[sayac + 1])
//        {
//            kova = dizi[sayac];
//            dizi[sayac] = dizi[sayac + 1];
//            dizi[sayac + 1] = kova;
//            durum = true;
//        }
//        sayac++;
//    }
//    sayac = 0;
//}

Array.Sort(dizi);


int index = 0;
while(index < dizi.Length)
{
	Console.WriteLine(dizi[index]);
	index++;
}
            Console.ReadKey();
        }
    }
}
