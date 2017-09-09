using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Yorum Satırı
            /*
              Coklu
              Yorum
              Satırı   
            */

            //Değişken Tanımlama
            // [data_tipi] (değişken_adı)
            int sayi;
            int sayi1 = 5;
            int sayi2 = 4, sayi3 = 13, sayi4 = 123123;

            /////////////////////////////
            // ------ Değişken isimlendirme kuralları
            // Sayı ve özel karakterlerle başlayamaz. ('_' ve '@' hariç)
            // Değilken isimleri '!', '?', '(', ')', '{', '}', '[', ']' içeremez.
            // Değişken isimleri büyük/kücük harfe duyarlıdır.
            // Birden fazla kelimeli değişkenler için araya bosluk konulamaz. '_' ile ayrılabilir.
            // Genel kabul gormus bazı değişken isimlendirme standartları vardır.
                // Camel Case : dogumTarihi, adSoyad, degiskeninIlkDegeri
                // Pascal Case : DogunTarihi, AdSoyad, DegiskeninIlkDegeri
            // Değişken isimleri anlamlı ve tuttuğu değeri tarif eder.

            // Reserved Keywords : C# için anlamlı olan kelimelerdir. Değişken isimlendirmelerindereserver keyword' ler kullanılmaz.
            // NOT : Burak, illa da kullanmak istiyorsanız reserved keywordler başına '_' ve '@' ekleyebilirsiniz.
            
            
            
            /*
             * int       : tam sayı değer. Sınır 2 milyar, -2milyar (2 uzeri 32)
             * string    : metinsel iffade tutar. En fazla kaç karakter? (boyutsuz)
             * bool      : TRUE ve FALSE değerlerini alırlar. (1bit)
             * byte      : Tek bir karakter tutar.
             * byte      : Tam sayı değeri tutar. 0 - 255 (1byte)
             * Double, float, decimal : Ondalıklı sayı tutar.
             * long      : Tamsayı tutar. (2 uzeri 64)  --------ARAŞTIR
             * object    : her türden veri tutabilir.
             * short, uint, ulong, sbyte ... -------------------ARAŞTIR
             */

            int deger = 540;
            string metin = "Serkan Soydam";
            char harf = 'A';
            bool durum = true;
            double ondalıklı = 5.01;
            byte kucukSayı = 125;
            decimal ondalıklı2 = 0.16M;
            float ondalıklı3 = 3.14F;
            long cokBuyukSayi = 2345678908745;
            
            object herHangiBirSey = "test";
            object baskaBirSey = 324;
            object digerBirSey = true;
            object farklıBirSey = 'x';
            object Bisey = 5.19;
            

            var x = 4;
            var y = "Ahmet";
            var z = 'c';

            int boyut = sizeof(int);
            Console.WriteLine("Int veri tipinin boyutu : " + boyut + "Byte");

            Console.WriteLine("Int veri tipinin Max Değeri : " + int.MaxValue);
            Console.WriteLine("Int veri tipinin Min Değeri : " + int.MinValue);

            Console.WriteLine
                ("Size of long : " + sizeof(long) + 
                " byte yer kaplar. Max : " + long.MaxValue + 
                " Min : " + long.MinValue);

            Console.WriteLine
                ("Size of long : " + sizeof(short) +
                " byte yer kaplar. Max : " + short.MaxValue +
                " Min : " + short.MinValue);

            Console.WriteLine
                ("Size of long : " + sizeof(uint) +
                " byte yer kaplar. Max : " + uint.MaxValue +
                " Min : " + uint.MinValue);

            Console.Beep(660, 125);

        }
    }
}
