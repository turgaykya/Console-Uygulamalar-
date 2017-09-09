using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberConvertRomaNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı giriniz : ");
            string number = Console.ReadLine();
            int inputNumber=int.Parse(number);
            int kontrol=0;
            int basamakKontrol =0;

            string[] birler = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] onlar = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] yuzler = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] binler = { "", "M", "MM", "MMM" };
            Console.Write("Sayının Roma Sayısına dönüşmüş hali: ");
            while(basamakKontrol<number.Length)
            {
            if(inputNumber<10)
            {

                Console.WriteLine(birler[inputNumber]+" ");
            }
            else if(inputNumber>=10 && inputNumber<100)
            {
                kontrol = inputNumber / 10;
                inputNumber=inputNumber%10;
                Console.Write(onlar[kontrol]);
            }
            else if (inputNumber >= 100 && inputNumber < 1000)
            {
                kontrol = inputNumber / 100;
                inputNumber = inputNumber % 100;
                Console.Write(yuzler[kontrol]);
            }
            else if (inputNumber >= 1000 && inputNumber < 4000)
            {
                kontrol = inputNumber / 1000;
                inputNumber = inputNumber % 1000;
                Console.Write(binler[kontrol]);
            }
            basamakKontrol++;
            kontrol = 0;
            }
        }
    }
}
