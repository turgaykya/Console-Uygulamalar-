using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_3__Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
            int sayac = 0;
            string yaziylaSayi1="";
            Console.WriteLine("Bir tamsayı giriniz: ");
            string yaziylaSayi = Console.ReadLine();
            int sayi1 = 0;
            bool kontrol = int.TryParse(yaziylaSayi, out sayi1);
            if (yaziylaSayi == "exit")
            {
                break;
            }
            while (!kontrol)
            {
                Console.WriteLine("Adam gibi tamsayı giriniz: ");
                yaziylaSayi = Console.ReadLine();
                kontrol = int.TryParse(yaziylaSayi, out sayi1);
                if (yaziylaSayi == "exit")
                {
                    break;
                }
            }
            if (yaziylaSayi == "exit")
            {
                break;
            }
            char[] karakter = new char[yaziylaSayi.Length];
            while (sayac<=yaziylaSayi.Length-1)
            {
               karakter[sayac] = yaziylaSayi[yaziylaSayi.Length - sayac - 1];
               sayac++;
               
            }
            int sayac2 = 0;
            while (sayac2 < karakter.Length)
            {
                yaziylaSayi1 += karakter[sayac2].ToString();
                sayac2++;
            }
           
            if(yaziylaSayi == yaziylaSayi1)
            {
                Console.WriteLine("Girdiğiniz sayı bir palindromdur...!\n");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı bir palindrom değildir..!!!!!\n");
            }
            }
        }
    }
}
