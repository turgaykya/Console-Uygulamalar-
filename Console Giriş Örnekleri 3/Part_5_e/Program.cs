using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5_e
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("girilen kenar uzunlukları ile diküçgen oluşturulabilmesini hesaplayan program");

            Console.Write("\nA kenarının uzunluğunu giriniz: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("\nB kenarının uzunluğunu giriniz: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("\nC kenarının uzunluğunu giriniz: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("");
         
            int pisagor = 0;
            bool koşul;

            koşul = a > 0 && a < 180 && b > 0 && b < 180 && c > 0 && c < 180;            
            if (koşul)
            {
                if (a >= b && a >= c)
            {
                pisagor = a*a;
                if (pisagor == (b*b)+(c*c))
                {
                    Console.WriteLine("Diküçgen çizilebilir.");
                }
                else
                {
                    Console.WriteLine("Diküçgen ÇİZİLEMEZ...");
                }
            }
            else if (b >= a && b >= c)
            {
                pisagor = b * b;
                if (pisagor == (a * a) + (c * c))
                {
                    Console.WriteLine("Diküçgen çizilebilir.");
                }
                else
                {
                    Console.WriteLine("Diküçgen ÇİZİLEMEZ...");
                }
            }
            else if (c >= a && c >= b)
            {
                pisagor = c * c;
                if (pisagor == (a * a) + (b * b))
                {
                    Console.WriteLine("Diküçgen çizilebilir.");
                }
                else
                {
                    Console.WriteLine("Diküçgen ÇİZİLEMEZ...");
                }
            }
            }
            else
            {
                Console.WriteLine("Lütfen Düzgün Uzunluk Girin...");
            }
            Console.ReadLine();
        }
    }
}
