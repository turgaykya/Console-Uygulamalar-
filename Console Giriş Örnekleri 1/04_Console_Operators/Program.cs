using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Console_Operators
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Aritmetiksel işlemler
            /*
             
            // Aritmetiksel Operatörler
            // +, -, *, /, %

            //int a = 8;
            //int b = 20;
            //int c;

            //Console.WriteLine("a = " + a + ", b " + b);

            //c = a + b;
            //Console.WriteLine("a + b = " + c);

            //c = a - b;
            //Console.WriteLine("a - b = " + c);

            //c = a * b;
            //Console.WriteLine("a * b = " + c);

            //c = a / b;
            //Console.WriteLine("a / b = " + c);

            //a = a + 1;
            //a++;
            //Console.WriteLine("a = " + a);

            //c = a++ + b;
            //Console.WriteLine("a++ + b " + c);

            //c = ++a + b;
            //Console.WriteLine("++a + b " + c);

            ////a = 10, b = 20
            //c = --a + b++;
            ////c = ?

            //Console.WriteLine("--a + b++ = " + c);

            
             //aklından 1 ile 100 arasında bir sayi tut
             //2 ile carp
             //8 ekle
             //yarısını bul
             //aklınızdan tuttugunuz sayıyı bu sayıdan cıkartın
             //sonuc?
             //4 çıktı, tebrikler
            

            Console.WriteLine("Aklindan 1 ile 100 arasinda bir sayi tut");
            Console.WriteLine("Tuttugunuz sayiyi giriniz : ");
            string input = Console.ReadLine();
            int sayı = int.Parse(input);
            Console.WriteLine("Simdi sayiyi 2 ile carp (devam etmek ENTER'a basin)");
            // Ekrandan bir satır okumak icin kullanmıyoruz.
            // Enter tusunu algılamak icin kullanıyoruz.
            Console.ReadLine();
            int sonuc = sayı * 2;
            Console.WriteLine(sayı + " x 2 = " + sonuc);
            Console.WriteLine("Simdi sonuca 8 ekle ");
            Console.ReadLine();
            // Ekrandan bir satır okumak icin kullanmıyoruz.
            // Enter tusunu algılamak icin kullanıyoruz.           
            int sonuc2 = sonuc + 8;
            Console.WriteLine(sonuc + " + 8 = " + sonuc2);
            Console.WriteLine("Cikan sonucun yarisini bul (devam etmek icin ENTER'a basin)");
            // Ekrandan bir satır okumak icin kullanmıyoruz.
            // Enter tusunu algılamak icin kullanıyoruz.
            Console.ReadLine();
            int sonuc3 = sonuc2 / 2;
            Console.WriteLine(sonuc2 + " / 2 = " + sonuc3);
            Console.WriteLine("Son cikan sayidan tuttugunuz sayiyi cikartin (devam etmek icin ENTER'a basin)");
            // Ekrandan bir satır okumak icin kullanmıyoruz.
            // Enter tusunu algılamak icin kullanıyoruz.
            Console.ReadLine();
            int sonuc4 = sonuc3 - sayı;
            Console.WriteLine("Sonuc 4 mu cikti? Sasilacak hadise!! ");
            Console.WriteLine(sonuc3 + " - " + sayı + " = " + sonuc4);
            Console.ReadKey();

            */
            #endregion

            #region Mantıksal İşlemler

            // Mantıksal Operatörler
            // == , !=, >, <, >=, <=
            /*
            int a = 21;
            int b = 10;
            bool c;

            Console.WriteLine("a = {0}, b = {1}",a,b);

            Console.WriteLine("a ve b eşit midir?");
            Console.WriteLine(a==b);

            Console.WriteLine("a ve b eşit değil midir?");
            Console.WriteLine(a != b);

            Console.WriteLine("a, b'den küçükmüdür?");
            c = a < b;
            Console.WriteLine(c);

            Console.WriteLine("a, b'den büyük müdür?");
            c = a > b;
            Console.WriteLine(c);

            Console.WriteLine("a, b'den küçük eşit midir?");
            Console.WriteLine(a <= b);

            Console.WriteLine("a, b'den büyük eşit midir?");
            Console.WriteLine(a >= b);


            bool sonuc;
            // Veya (OR) Operatörü
            sonuc = false || false; //sonuc : false
            sonuc = false || true;  //sonuc : true
            sonuc = true || true;   //sonuc : true
            sonuc = true || true;   //sonuc : true

            // Ve (AND) Operatörü
            sonuc = false && false; //sonuc : false
            sonuc = false && true;  //sonuc : true
            sonuc = true && true;   //sonuc : true
            sonuc = true && true;   //sonuc : true

            sonuc = 5 > 4 && 3 > 4 || true && 6 < 2;                  // sonuc : false
            sonuc = (6 > 2 || 5 > 9) && 5 == 5;                       // sonuc : true
            sonuc = 3 < 5 || 4 != 4 && (2 >= 2 || 3 < 3) || false;    // sonuc : true
            sonuc = 3 < 5 || 4 != 4 && 2 >= 2 || 3 < 3 || false;      // sonuc : true
            */

            #endregion

            #region Atama İşlemleri (Operatörleri)
            // Atama İşlemleri (Operatörleri)
            // =, +=, -=, *=, /=, %=
            /*
            int a = 7;
            int c;

            Console.WriteLine("a = {0}", a);

            c = a;
            Console.WriteLine("c = a nın sonucunda c : {0}", c);

            c += a; // c = c + a
                Console.WriteLine("c += a nın sonucunda c : {0}",c);

            c -= a; // c = c + a
                Console.WriteLine("c -= a nın sonucunda c : {0}", c);

            c *= a; // c = c + a
                Console.WriteLine("c *= a nın sonucunda c : {0}", c);

            c /= a; // c = c + a
                Console.WriteLine("c /= a nın sonucunda c : {0}", c);

            c %= a; // c = c + a
                Console.WriteLine("c %= a nın sonucunda c : {0}", c);

            */

            #endregion


            Console.ReadKey();
        }
    }
}
