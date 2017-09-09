using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_6_c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kullanıcıdan alınacak iki sayı arasında kalan sayıların kare ve küp değerlerini bulan prog.");


            while (true)
            {
                int sayı1 = 0;
                bool başarılı = false;
                string girilen = "";

                while (başarılı == false)
                {
                    Console.Write("\n1.sayıyı girin: ");
                    girilen = Console.ReadLine();
                    başarılı = int.TryParse(girilen, out sayı1);
                    if (girilen == "exit")
                    {
                        break;
                    }
                }
                if (girilen == "exit")
                {
                    break;
                }

                int sayı2 = 0;
                bool başarılı2 = false;
                string girilen2 = "";
                while (başarılı2 == false)
                {
                    Console.Write("\n2.sayıyı girin: ");
                    girilen2 = Console.ReadLine();
                    başarılı2 = int.TryParse(girilen2, out sayı2);
                    if (girilen2 == "exit")
                    {
                        break;
                    }
                }
                if (girilen2 == "exit")
                {
                    break;
                }

                int kucuKsayı = 0;
                int buyuKsayı = 0;
                if (sayı1 < sayı2)
                {
                    kucuKsayı = sayı1;
                    buyuKsayı = sayı2;
                }
                else
                {
                    kucuKsayı = sayı2;
                    buyuKsayı = sayı1;
                }
                while (kucuKsayı < buyuKsayı - 1)
                {
                    kucuKsayı++;
                    Console.WriteLine("{0} {1} {2}", kucuKsayı, (kucuKsayı * kucuKsayı), (kucuKsayı * kucuKsayı * kucuKsayı));
                }
            }
        }
    }
}



