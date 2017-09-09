using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calısma
{
    class Program
    {
        static void Main(string[] args)
        {
//1. Bir dizide istenen elemanın index değerini döndüren metodu yazın.IndexOf(array, item) (diziyi ve elemaın parametre olarak gondericez.)      
//2. Bir string içerisinde istenen karakterin ilk kez geçtiği yerin index değerini döndüren metodu yazın
//3. Bir string içerisinde istenen karakterin son kez geçtiği yerin değerini döndüren metodu yazın --LastIndexOf()
            int[] dizi = {5,6,7,8,5,34};
            int index = 0;

            while (index < dizi.Length)
            {
                Console.WriteLine(dizi[index]);
                index++;
            }
            int eleman = 0;
            Console.WriteLine("Lütfen diziden bir eleman seçin: ");
            eleman = int.Parse(Console.ReadLine());

            Console.WriteLine(IndexOf(dizi, eleman));

            Console.ReadLine();

        }
        static int IndexOf(int[] dizi, int eleman)
        { 
            int sonuc=0;
            int index = 0;
            while (index < dizi.Length)
            {
                if (eleman == dizi[index])
                {
                    Console.WriteLine("Dizideki index değeri = {0}",dizi.Length);
                }
                else
                {
                  
                }
                index++;
            }

            return sonuc;
        }
    }
}
