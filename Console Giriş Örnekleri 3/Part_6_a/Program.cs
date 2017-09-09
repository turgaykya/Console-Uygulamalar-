using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_6_a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dışarıadn istenen 10 sayının içindeki enbüyük ve enküçük olanları bulan program");
            int sayac = 0;
            int enKüçük = int.MaxValue;
            int enBüyük = int.MinValue;

            while (sayac < 10)
            {
                Console.Write("\nsayı girin: ");
                string girilen = Console.ReadLine();
                int çıkış;
                bool başarılı = int.TryParse(girilen, out çıkış);

                if (başarılı)
                {
                    if (çıkış < enKüçük)
                    {
                        enKüçük = çıkış;
                    }
                    if (çıkış > enBüyük)
                    {
                        enBüyük = çıkış;
                    }
                    sayac++;
                }
                else
                {
                    Console.WriteLine("Lütfen sadece SAYI girin...");
                }                
            }
            Console.WriteLine("en küçük sayı: " + enKüçük);
            Console.WriteLine("en büyük sayı: " + enBüyük);

            Console.ReadLine();
        }
    }
}
        
    
