using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Console_Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            //Switch - Case

            /*
              switch(değişken)
              {
                   case durum :
                       işlemler
                       break;
                   case durum2:
                       işlemler
                       break;
                       
                   ----
                   default:
                       işlemler
              }
              
            */
            #region
            // Kullanıcının girdiği 1 7 arasındaki değere göre haftanın gübü karşılıgını veren programı yazınız.

            //Console.WriteLine("1 ile 7 arasında bir sayı giriniz: ");
            //int gun = int.Parse(Console.ReadLine());

            //switch (gun)
            //{ 
            //    case 1:
            //        Console.WriteLine("Pazartesi");
            //        break;
            //    case 2:
            //        Console.WriteLine("Salı");
            //        break;
            //    case 3:
            //        Console.WriteLine("Çarşamba");
            //        break;
            //    case 4:
            //        Console.WriteLine("Perşembe");
            //        break;
            //    case 5:
            //        Console.WriteLine("Cuma");
            //        break;
            //    case 6:
            //        Console.WriteLine("Cumartesi");
            //        break;
            //    case 7:
            //        Console.WriteLine("Pazar");
            //        break;
            //    default :
            //        Console.WriteLine("hatalı değer");
            //        break;
            //}

            #endregion

            // Kullanıcıya kaçıncı ayda oldugunu sorarak hangi mevsimde bulundugunu gosteren kodu yazınız.

            Console.WriteLine("Kaçıncı aydasınız ? ");
            int ay = int.Parse(Console.ReadLine());

            switch (ay)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("kış");
                    break;
                case 3: 
                case 4:
                case 5:
                    Console.WriteLine("ilkbahar");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("yaz");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("sonbahar");
                    break;
            }

            Console.ReadKey();
        }
    }
}
