using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_4_a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ilk değeri yazınız : ");
            int deger1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ikinci değeri yazınız : ");
            int deger2 = int.Parse(Console.ReadLine());

            Console.WriteLine("üçüncü değeri yazınız : ");
            int deger3 = int.Parse(Console.ReadLine());

            bool kıyasla, kıyasla2, kıyasla3, kıyasla4, kıyasla5, kıyasla6,kıyasla7,
                 kıyasla8, kıyasla9, kıyasla10, kıyasla11, kıyasla12, kıyasla13, kıyasla14;






   //##      12. 100 sayısı 45 ve 3 sayılarından büyüktür veya sayılara eşittir: true
   //##      13. 100 sayısı 45 ve 3 sayılarından küçüktür: false
   //##      14. 100 sayısı 45 ve 3 sayılarından küçüktür veya sayılara eşittir: false

  kıyasla = deger1 == deger2 && deger1 == deger3 && deger2 == deger3;
  kıyasla2 = deger1 != deger2 && deger1 != deger3 && deger2 != deger3;
  kıyasla3 = deger1 > deger2 && deger1 > deger3;
  kıyasla4 = deger1 >= deger2 && deger1 >= deger3;
  kıyasla5 = deger1 < deger2 && deger1 < deger3;
  kıyasla6 = deger1 <= deger2 && deger1 <= deger3;
  kıyasla7 = deger2 > deger1 && deger2 > deger3;
  kıyasla8 = deger2 >= deger1 && deger2 >= deger3;
  kıyasla9 = deger2 < deger1 && deger2 < deger3;
  kıyasla10 = deger2 <= deger1 && deger2 <= deger3;
  kıyasla11 = deger3 > deger1 && deger3 > deger2;
  kıyasla12 = deger3 >= deger1 && deger3 >= deger2;
  kıyasla13 = deger3 < deger1 && deger3 < deger2;
  kıyasla14 = deger3 <= deger1 && deger3 <= deger2;

  Console.WriteLine("\nVE (&&) işlemi için");
  Console.WriteLine("01. {0}, {1} ve {2}sayıları birbirine eşittir: {3}", deger1, deger2, deger3, kıyasla);
  Console.WriteLine("02. {0}, {1} ve {2}sayıları birbirine eşit değildir: {3}", deger1, deger2, deger3, kıyasla2);
  Console.WriteLine("03. {0} sayısı {1} ve {2} sayılarından büyüktür: {3} ", deger1, deger2, deger3, kıyasla3);
  Console.WriteLine("04. {0} sayısı {1} ve {2} sayılarından büyüktür veya sayılara eşittir: {3} ", deger1, deger2, deger3, kıyasla4);
  Console.WriteLine("05. {0} sayısı {1} ve {2} sayılarından küçüktür: {3} ", deger1, deger2, deger3, kıyasla5);
  Console.WriteLine("06. {0} sayısı {1} ve {2} sayılarından küçük veya sayılara eşittir: {3} ", deger1, deger2, deger3, kıyasla6);
  Console.WriteLine("07. {0} sayısı {1} ve {2} sayılarından büyüktür: {3}", deger2, deger1, deger3, kıyasla7);
  Console.WriteLine("08. {0} sayısı {1} ve {2} sayılarından büyüktür veya sayılara eşittir: {3}", deger2, deger1, deger3, kıyasla8);
  Console.WriteLine("09. {0} sayısı {1} ve {2} sayılarından küçüktür: {3}", deger2, deger1, deger3, kıyasla9);
  Console.WriteLine("08. {0} sayısı {1} ve {2} sayılarından küçüktür veya sayılara eşittir: {3}", deger2, deger1, deger3, kıyasla10);
  Console.WriteLine("03. {0} sayısı {1} ve {2} sayılarından büyüktür: {3} ", deger3, deger1, deger2, kıyasla11);
  Console.WriteLine("04. {0} sayısı {1} ve {2} sayılarından büyüktür veya sayılara eşittir: {3} ", deger3, deger1, deger2, kıyasla12);
  Console.WriteLine("03. {0} sayısı {1} ve {2} sayılarından küçüktür: {3} ", deger3, deger1, deger2, kıyasla13);
  Console.WriteLine("04. {0} sayısı {1} ve {2} sayılarından küçüktür veya sayılara eşittir: {3} ", deger3, deger1, deger2, kıyasla14);


            Console.ReadLine();

        }
    }
}
