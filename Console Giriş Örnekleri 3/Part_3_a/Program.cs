using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3_a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ilk string değeri yazınız : ");
            string deger1 = Console.ReadLine();

            Console.WriteLine("ikinci string değeri yazınız : ");
            string deger2 = Console.ReadLine();

            bool kıyasla;
            bool kıyasla2;
            kıyasla = deger1 == deger2;
            kıyasla2 = deger1 != deger2;

            Console.WriteLine("{0} ile {1} değerleri birbirine eşittir: {2}",deger1, deger2, kıyasla);
            Console.WriteLine("{0} ile {1} değerleri birbirine değildir: {2}", deger1, deger2, kıyasla2);
   


            Console.ReadLine();










            Console.ReadLine();


        }
    }
}
