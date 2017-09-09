using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Mathislemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Math.ABS : Bu fonksiyon verilen herhangi bir sayının pozitif değerini döndürür. 
            int deger1 = -30;
            int pozitifDeger = Math.Abs(deger1);
            Console.WriteLine("Sonuç:" + pozitifDeger);
            //Ceiling: Kendisine parametre olarak verilen ondalıklı değeri, üsteki sayıya yuvarlayarak döndürür. 
            double deger2 = 9.3;
            double yuvarla = Math.Ceiling(deger2);
            Console.WriteLine("Sonuç:" + yuvarla);

            //Exp:Parametre olarak girilen sayıyı, e sayısının kuvveti olarak hesaplar. e sayısının yaklaşık değeri 2.71’dir ve logaritmik hesaplamalarda sıklıkla kullanılır.

            double sayi = Math.Exp(3);
            Console.WriteLine("Sonuç:" + sayi);// Yaklaşık 2.71'nin 3.kuvvetini hesaplar

            //E: Matematikteki e sayısını ifade eder, yaklaşık değeri 2.71’dir. Bu değer bir sabit olmakla birlikte, metot değildir.

            double sayi2 = Math.E;
            Console.WriteLine("Sonuç:" + sayi2);// 2.71828182845905

            //Floor: Kendisine parametre olarak girilen değeri kendisinden küçük olan tamsayıya yuvarlar.

            double sayi3 = 9.8;
            double yuvarla2 = Math.Floor(sayi3);
            Console.WriteLine("Sonuç:" + yuvarla2);

            //Log: Birinci parametrede girilen sayının, ikinci parametrede girilen sayıya göre logaritmasını alır.
            //Max: Kendisine parametre olarak girilen iki değerden büyük olanı döndürür.
            //Min: Kendisine parametre olarak girilen değerden küçük olanı döndürür.

            double buyuk = Math.Max(2, 3.45);
            Console.WriteLine("Maksimum:" + buyuk);
            double kucuk = Math.Min(-4.3, 3);
            Console.WriteLine("Minimum:" + kucuk);

            // PI: Matematikteki π (pi) sayısını döndürür. Buda e gibi bir sabit olmakla birlikte, metot değildir. PI sayısının yaklaşık değeri 3.14’tür.
            //Pow: Matematikteki üst hesaplama işlemini gerçekleştirir. Birinci parametre taban, ikinci parametre üs olacak şekilde üslü ifadeyi hesaplar.

            double yaricap = 4.6;
            double alan = Math.PI * Math.Pow(yaricap, 2);// Alan= pi*r2
            Console.WriteLine("Dairenin Alanı:" + alan);

            //Round: Kendisine verilen ondalıklı sayının ondalık hassasiyetini ayarlar. Birinci parametre asıl sayıyı, ikinci parametre kaç basamak ondalık gösterilecekse bunu belirler.

            double sayi4 = 4.698678;
            double ayarla = Math.Round(sayi4, 3);
            Console.WriteLine("Sonuç:" + ayarla);

            //Sign: Parametre olarak verilen sayının pozitif, negatif veya sıfır olma durumunu gösterir. Yani sayı pozitif ise “1”, negatif ise “-1”, sıfır ise “0” değerini döndürür.
            //Sqrt: En çok kullanılan matematiksel metotlardan biridir. Kendisine verilen sayının karekökünü hesaplar.

            double sayi5 = 625;
            double kok = Math.Sqrt(sayi5);
            Console.WriteLine("Sonuç:" + kok);

            //Sin-Cos-Tan-Sinh-Cosh-Tanh: Trigonometrik açıların değerlerini hesaplamak için kullanılır.
        }
    }
}
