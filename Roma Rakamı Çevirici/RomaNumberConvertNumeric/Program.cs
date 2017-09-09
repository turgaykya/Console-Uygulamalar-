using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomaNumberConvertNumeric
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] romaNumber = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
            Console.WriteLine("Roma rakamını giriniz");
            string number = Console.ReadLine();
            int[] sayiKontrol = new int[number.Length+1];
            sayiKontrol[0] = 0;
            int sayac = 0;
            int sonuc = 0,toplam=0;
            while (sayac < number.Length)
            {
                        switch (number[sayac])
                        {
                            case 'I': sonuc = 1; break;
                            case 'V': sonuc = 5; break;
                            case 'X': sonuc = 10; break;
                            case 'L': sonuc = 50; break;
                            case 'C': sonuc = 100; break;
                            case 'D': sonuc = 500; break;
                            case 'M': sonuc = 1000; break;
                            default: sonuc=0;break;
                        }
                        sayiKontrol[sayac+1] = sonuc;
                        if(sonuc>sayiKontrol[sayac])
                        {
                            toplam = (toplam-sayiKontrol[sayac])+sonuc-sayiKontrol[sayac];
                        }
                        else
                            toplam = sonuc+toplam;
                if (sonuc == sayiKontrol[sayac] && sonuc == sayiKontrol[sayac - 1] && sonuc == sayiKontrol[sayac - 2])
                {
                    Console.WriteLine("Hatalı Giriş Yaptınız !!! ");
                    toplam = 0;
                }
                        sayac++;
                        
            }
            Console.WriteLine(toplam);
        }
    }
}
