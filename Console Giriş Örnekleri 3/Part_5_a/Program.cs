using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5_a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>> Bir sayının Diğerinin Tam Katı Olup Olmadığını Hesaplayan Program <<<");

            Console.Write("\nilk sayıyı giriniz: ");
            int sayı1 = int.Parse(Console.ReadLine());
            Console.Write("\nikinci sayıyı giriniz: ");
            int sayı2 = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            bool sonuc;



            if (sayı1>sayı2)
            {
                if (sayı1 % sayı2 == 0)
                {
                    Console.WriteLine("{0} sayısı {1} sayısının tam katıdır.", sayı1, sayı2);
                }
                else
                {
                    Console.WriteLine("{0} sayısı {1} sayısının tam katı DEĞİLDİR.", sayı1, sayı2);
                }
            }
            else
            {
                Console.WriteLine("Girdiğiniz ikinci sayı birinci sayıdan büyük olamaz...");
            }













            Console.ReadLine();

        }
    }
}
