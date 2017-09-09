using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5_c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("girilen kenar uzunlukları ile üçgen oluşturulabilmesini hesaplayan program");

            Console.Write("\nA kenarının uzunluğunu giriniz: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("\nB kenarının uzunluğunu giriniz: ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("\nC kenarının uzunluğunu giriniz: ");
            float c = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            float uzunKenar = 0;
            float diğerKenarlar = 0;
            if (a >= b && a >= c)
            {
                uzunKenar = a;
                diğerKenarlar = b + c;
                if (uzunKenar < diğerKenarlar)
                {
                    Console.WriteLine("Verilen kenar uzunlukları ile üçgen çizilebilir...");
                }
                else
                {
                    Console.WriteLine("Verilen kenar uzunlukları ile üçgen ÇİZİLEMEZ...");
                }
            }
            else if (b >= a && b >= c)
            {
                uzunKenar = b;
                diğerKenarlar = a + c;
                if (uzunKenar < diğerKenarlar)
                {
                    Console.WriteLine("Verilen kenar uzunlukları ile üçgen çizilebilir...");
                }
                else
                {
                    Console.WriteLine("Verilen kenar uzunlukları ile üçgen ÇİZİLEMEZ...");
                }
            }
            else if (c >= a && c >= b)
            {
                uzunKenar = c;
                diğerKenarlar = a + b;
                if (uzunKenar < diğerKenarlar)
                {
                    Console.WriteLine("Verilen kenar uzunlukları ile üçgen çizilebilir...");
                }
                else
                {
                    Console.WriteLine("Verilen kenar uzunlukları ile üçgen ÇİZİLEMEZ...");
                }
            }
            Console.ReadLine();
        }
    }
}
