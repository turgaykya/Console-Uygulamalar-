using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5_f
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("girilen açı değerleri ile diküçgen oluşturulabilmesini hesaplayan program");

            Console.Write("\nA açısını giriniz: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("\nB açısını giriniz: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("\nC açısını giriniz: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            bool koşul;

            koşul = a > 0 && a < 180 && b > 0 && b < 180 && c > 0 && c < 180;
            if (koşul)
            {
                if (a == 90 || b == 90 || c == 90)
                {
                    if (a == 90)
                    {
                        if (a == (b + c))
                        {
                            Console.WriteLine("Diküçgen Çizilebilir.");
                        }
                        else
                        {
                            Console.WriteLine("Diküçgen ÇİZİLEMEZ...");
                        }
                    }
                    else if (b == 90)
                    {
                        if (b == (a + c))
                        {
                            Console.WriteLine("Diküçgen Çizilebilir.");
                        }
                        else
                        {
                            Console.WriteLine("Diküçgen ÇİZİLEMEZ...");
                        }
                    }
                    else if (c == 90)
                    {
                        if (c == (a + b))
                        {
                            Console.WriteLine("Diküçgen Çizilebilir.");
                        }
                        else
                        {
                            Console.WriteLine("Diküçgen ÇİZİLEMEZ...");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Diküçgen ÇİZİLEMEZ...");
                }
            }
            else
            {
                Console.WriteLine("Lütfen Düzgün Değer Girin...");
            }
            Console.ReadLine();
        }
    }
}
