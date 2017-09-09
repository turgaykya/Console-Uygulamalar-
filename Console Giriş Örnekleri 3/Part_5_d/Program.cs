using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5_d
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("girilen açı değerleri ile üçgen oluşturulabilmesini hesaplayan program");

            Console.Write("\nA açısını giriniz: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("\nB açısını giriniz: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("\nC açısını giriniz: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("");
         
            int toplamAçı = 0;
            bool koşul;
            koşul = a > 0 && b > 0 && c > 0 && a < 180 && b < 180 && c < 180;
            if (koşul)
            {
                toplamAçı = a + b + c;
                if (toplamAçı == 180)
                {
                    Console.WriteLine("Verilen açılar ile üçgen oluşturulabilir");
                }
                else
                {
                    Console.WriteLine("Verilen açılar ile üçgen OLUŞTURULAMAZ");
                }
            }
            else
            {
                Console.WriteLine("Lütfen 0 dan büyük 180 den küçük açılar giriniz...");
            }
            Console.ReadLine();
        }
    }
}
