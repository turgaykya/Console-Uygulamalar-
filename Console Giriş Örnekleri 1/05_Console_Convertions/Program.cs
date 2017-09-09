//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _05_Console_Convertions
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            // Convertions (Dönüşümler)

//            // Implicit Convertion (Kapalı)
         
//           /*
//            int toplam;
//            byte sayi = 25;
//            toplam = sayi;

//            int num = int.MaxValue;
//            long bigNum = num;

//            // Explicit Convertion (Açık)
//            byte toplam2;
//            int sayi2 = 300;
//            toplam2 = (byte)sayi2;

//            // tip dönüşümlerinde tip uyumsuzlugu durumunda atama işlemi yapabilmek için "cast" işlemini kullanırız.

//            long bigNum2 = 3000000000;
//            int num2;
//            num2 = (int)bigNum2;

//            Console.WriteLine(num2);
//            */

//            //--------------------------------------------

//            /*
//            Console.Write("Lütfen bir sayı yazınız : ");
            
//            //Boxing / Kutulama
//            object input = Console.ReadLine();

//            object number = 100;
//            */
//            //int bigNum = (int)number/*Unboxing*/ * 10;

//            //Unboxing
//            //  string yazıylaSayı = (string)number;

//            //----------------------------------------
            
//            // String ifadeleri nümerik tiplere dönüştürürken Parse metotlarını kullanırız.
//            int a = int.Parse("49");
//            byte b = byte.Parse("95");
//            double c = double.Parse("123.5");
//            // Nümerik tipleri(hatta herhangi bir veri tipi için) string tiplere donustururken ise;
//            string sonuc = a.ToString();
//            string sonuc2 = b.ToString();
//            string sonuc3 = c.ToString();

//            //----------------------------------------------

//            //Convert

//            int x = Convert.ToInt32("290348290");

//            //----------------------------------------------

//            // string result = "45" + 5;                        //455
//            //string result = "45" + 5 + 9;                     //4559
//            //string result = "45" + (5 + 9);                   //4514
//            //string result = 5 + 9 + "45";                     //1445
//            //string result = 5 + "45" + 9;                     //5459
//            //string result = 5 + 9 + "23" + 5 + 4 + "3";       //1423543
//            //string result = 5 + (9 + "23") + 5 + 4 + "3";     //5923543










//            Console.ReadLine();
//        }
//    }
//}
