using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5_b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>>>> 3 sayıdan en büyüğünü bulan program <<<<<");

            Console.Write("\nilk sayıyı giriniz: ");
            int sayı1 = int.Parse(Console.ReadLine());
            Console.Write("\nikinci sayıyı giriniz: ");
            int sayı2 = int.Parse(Console.ReadLine());
            Console.Write("\nüçüncü sayıyı giriniz: ");
            int sayı3 = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (sayı1>sayı2 && sayı1>sayı3)
            {
                Console.WriteLine("birinci sayı en büyüktür: {0}", sayı1);
            }
            else if (sayı2>sayı1 && sayı2>sayı3)
            {
                Console.WriteLine("ikinci sayı en büyüktür: {0}", sayı2);
            }
            else if(sayı3>sayı1 && sayı3>sayı2)
            {
                Console.WriteLine("üçüncü sayı en büyüktür: {0}", sayı3);
            }
            else
            {
                Console.WriteLine("Biryerlerde bir eşitlik durumu var...");
            }
            Console.ReadLine();





        }
    }
}
