using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_7_d
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 0, 4, 7, 4, 2, 12, 64 };
            int index = 0;
            while (index < dizi.Length)
            {
                if (index == 0)
                {
                    Console.Write(dizi[dizi.Length - 1 - index]);
                }
                else
                {
                    Console.Write(" - " + dizi[dizi.Length - 1 - index]);
                }
                index++;
            }


            Console.ReadLine();
        }
    }
}
