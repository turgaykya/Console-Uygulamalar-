using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_4__OtoparkUcretHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int deger = 0;
            bool kontrol=true;
            string girilenDeger = "";
            float saat = 0;
            int gun = 0;
            while (true)
            {
                Console.WriteLine("1. Otomobil için 1'e basın\n2. Motosiklet için 2'ye basın\n3. Minibüs için 3'e basın\n4. Kamyon (ve diğer ticari araçlar) için 4'e basın");
                  girilenDeger= Console.ReadLine();
                kontrol = int.TryParse(girilenDeger, out deger);
                int ucret = 0;
                if (deger == 1 || deger == 2 || deger == 3 || deger == 4)
                {
                    switch (deger)
                    {
                        case 1: Console.WriteLine("Araç kaç saat boyunca park alanın da kaldı ? ");
                            girilenDeger = Console.ReadLine();
                            kontrol = float.TryParse(girilenDeger, out saat);
                            while (!kontrol)
                            {
                                Console.WriteLine("Lütfen geçerli bir saat giriniz!\nAraç kaç saat boyunca park alanın da kaldı ?  ");
                                girilenDeger = Console.ReadLine();
                                kontrol = float.TryParse(girilenDeger, out saat);
                            }
                            

                            if (saat>0 && saat<=2)
                            {
                              ucret += 5;  
                            }
                            else if (saat > 2 && saat <= 6)
                            {
                                ucret += 10;
                            }
                            else if (saat > 6 && saat <= 12)
                            {
                                ucret += 20;
                            }
                            else if (saat > 12 && saat <= 24)
                            {
                                ucret += 35;
                            }
                            else if (saat > 24 )
                            {                               
                                gun = (int)saat / 24;
                                ucret = 35+(gun*20);

                            }
                            Console.WriteLine("Ödenmesi gereken tutar {0}TL",ucret);
                            break;

                        case 2: Console.WriteLine("Araç kaç saat boyunca park alanın da kaldı ? ");
                            girilenDeger = Console.ReadLine();
                            kontrol = float.TryParse(girilenDeger, out saat);
                            while (!kontrol)
                            {
                                Console.WriteLine("Lütfen geçerli bir saat giriniz!\nAraç kaç saat boyunca park alanın da kaldı ?  ");
                                girilenDeger = Console.ReadLine();
                                kontrol = float.TryParse(girilenDeger, out saat);
                            }
                            if (saat > 0 && saat <= 2)
                            {
                              ucret += 0;  
                            }
                            else if (saat > 2 && saat <= 6)
                            {
                                ucret += 3;
                            }
                            else if (saat > 6 && saat <= 12)
                            {
                                ucret += 6;
                            }
                            else if (saat > 12 && saat <= 24)
                            {
                                ucret += 12;
                            }
                            else if (saat > 24)
                            {
                                gun = (int)saat / 24;
                                ucret = 12 + (gun * 10);
                            }
                            Console.WriteLine("Ödenmesi gereken tutar {0}TL", ucret);
                            break;

                        case 3: Console.WriteLine("Araç kaç saat boyunca park alanın da kaldı ? ");
                            girilenDeger = Console.ReadLine();
                            kontrol = float.TryParse(girilenDeger, out saat);
                            while (!kontrol)
                            {
                                Console.WriteLine("Lütfen geçerli bir saat giriniz!\nAraç kaç saat boyunca park alanın da kaldı ?  ");
                                girilenDeger = Console.ReadLine();
                                kontrol = float.TryParse(girilenDeger, out saat);
                            }
                            if (saat > 0 && saat <= 2)
                            {
                                ucret += 8;
                            }
                            else if (saat > 2 && saat <= 6)
                            {
                                ucret += 16;
                            }
                            else if (saat > 6 && saat <= 12)
                            {
                                ucret += 32;
                            }
                            else if (saat > 12 && saat <= 24)
                            {
                                ucret += 45;
                            }
                            else if (saat > 24)
                            {
                                gun = (int)saat / 24;
                                ucret = 45 + (gun * 25);
                            }
                            Console.WriteLine("Ödenmesi gereken tutar {0}TL", ucret);
                            break;

                        case 4: Console.WriteLine("Araç kaç saat boyunca park alanın da kaldı ? ");
                            girilenDeger = Console.ReadLine();
                            kontrol = float.TryParse(girilenDeger, out saat);
                            while (!kontrol)
                            {
                                Console.WriteLine("Lütfen geçerli bir saat giriniz!\nAraç kaç saat boyunca park alanın da kaldı ?  ");
                                girilenDeger = Console.ReadLine();
                                kontrol = float.TryParse(girilenDeger, out saat);
                            }
                            if (saat > 0 && saat <= 2)
                            {
                                ucret += 15;
                            }
                            else if (saat > 2 && saat <= 6)
                            {
                                ucret += 30;
                            }
                            else if (saat > 6 && saat <= 12)
                            {
                                ucret += 60;
                            }
                            else if (saat > 12 && saat <= 24)
                            {
                                ucret += 100;
                            }
                            else if (saat > 24)
                            {
                                gun = (int)saat / 24;
                                ucret = 100 + (gun * 55);
                            }
                            Console.WriteLine("Ödenmesi gereken tutar {0}TL", ucret);
                            break;
                        default:
                            break;

                    }
                }
                else;
            }
        }
    }
}
