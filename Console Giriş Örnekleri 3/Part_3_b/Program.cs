﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3_b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ilk tam sayı değeri yazınız : ");
            int deger1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ikinci tam sayı değeri yazınız : ");
            int deger2 = int.Parse(Console.ReadLine());

            bool kıyasla;
            bool kıyasla2;
            bool kıyasla3;
            bool kıyasla4;
  
            kıyasla = deger1 == deger2;
            kıyasla2 = deger1 != deger2;
            kıyasla3 = deger1 > deger2;
            kıyasla4 = deger1 < deger2;

            Console.WriteLine("\n{0} ile {1} değerleri birbirine eşittir  -----> {2}", deger1, deger2, kıyasla);
            Console.WriteLine("{0} ile {1} değerleri birbirine değildir -----> {2}", deger1, deger2, kıyasla2);
            Console.WriteLine("{0} değeri {1} değerinden büyüktür       -----> {2}", deger1, deger2, kıyasla3);
            Console.WriteLine("{0} değeri {1} değerinden küçüktür       -----> {2}", deger1, deger2, kıyasla4);


            Console.ReadLine();
        }
    }
}
