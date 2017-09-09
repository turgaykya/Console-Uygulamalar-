using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_4_b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("birinci kişinin adını ve yaşını yazınız : ");
            string isimKişi1 = Console.ReadLine();
            int yaşKişi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ikinci kişinin adını ve yaşını yazınız : ");
            string isimKişi2 = Console.ReadLine();
            int yaşKişi2 = int.Parse(Console.ReadLine());

            Console.WriteLine("üçüncü kişinin adını ve yaşını yazınız : ");
            string isimKişi3 = Console.ReadLine();
            int yaşKişi3 = int.Parse(Console.ReadLine());

      bool kıyasla;

 kıyasla = yaşKişi1 == yaşKişi2 && yaşKişi1 == yaşKişi3 && yaşKişi2 == yaşKişi3;
 Console.WriteLine
 ("01. {0}, {1} ve {2} isimli kişilerin yaşları birbirine eşittir: {3}",
 isimKişi1,isimKişi2,isimKişi3,kıyasla);

 kıyasla = yaşKişi1 != yaşKişi2 && yaşKişi1 != yaşKişi3 && yaşKişi2 != yaşKişi3;
 Console.WriteLine
 ("01. {0}, {1} ve {2} isimli kişilerin yaşları birbirine eşit değildir: {3}",
 isimKişi1, isimKişi2, isimKişi3, kıyasla);

 kıyasla = yaşKişi1 > yaşKişi2 && yaşKişi1 > yaşKişi3;
 Console.WriteLine
 ("03. {0} isimli kişinin yaşı {1} ve {2} isimli kişilerin yaşlarından büyüktür: {3}",
 isimKişi1, isimKişi2, isimKişi3, kıyasla);

 kıyasla = yaşKişi1 >= yaşKişi2 && yaşKişi1 >= yaşKişi3;
 Console.WriteLine
("04. Tsubasa isimli kişinin yaşı Misaki ve Hyuga isimli kişilerin yaşlarından büyüktür veya yaşlarına eşittir: false",
isimKişi1, isimKişi2, isimKişi3, kıyasla);

 kıyasla = yaşKişi1 < yaşKişi2 && yaşKişi1 < yaşKişi3;
 Console.WriteLine
 ("05. {0} isimli kişinin yaşı {1} ve {2} isimli kişilerin yaşlarından küçüktür: {3}",
 isimKişi1, isimKişi2, isimKişi3, kıyasla);

 kıyasla = yaşKişi1 <= yaşKişi2 && yaşKişi1 <= yaşKişi3;
 Console.WriteLine
("06. Tsubasa isimli kişinin yaşı Misaki ve Hyuga isimli kişilerin yaşlarından küçüktür veya yaşlarına eşittir: false",
isimKişi1, isimKişi2, isimKişi3, kıyasla);

 kıyasla = yaşKişi2 > yaşKişi1 && yaşKişi2 > yaşKişi3;
 Console.WriteLine
 ("07. {0} isimli kişinin yaşı {1} ve {2} isimli kişilerin yaşlarından büyüktür: {3}",
 isimKişi2, isimKişi1, isimKişi3, kıyasla);

 kıyasla = yaşKişi2 >= yaşKişi1 && yaşKişi2 >= yaşKişi3;
 Console.WriteLine
 ("08. {0} isimli kişinin yaşı {1} ve {2} isimli kişilerin yaşlarından büyüktür veya yaşlarına eşittir: {3}",
 isimKişi2, isimKişi1, isimKişi3, kıyasla);

 kıyasla = yaşKişi2 < yaşKişi1 && yaşKişi2 < yaşKişi3;
 Console.WriteLine
 ("09. {0} isimli kişinin yaşı {1} ve {2} isimli kişilerin yaşlarından küçüktür: {3}",
 isimKişi2, isimKişi1, isimKişi3, kıyasla);

 kıyasla = yaşKişi2 <= yaşKişi1 && yaşKişi2 <= yaşKişi3;
 Console.WriteLine
 ("10. {0} isimli kişinin yaşı {1} ve {2} isimli kişilerin yaşlarından küçüktür veya yaşlarına eşittir: {3}",
 isimKişi2, isimKişi1, isimKişi3, kıyasla);

 kıyasla = yaşKişi3 > yaşKişi1 && yaşKişi3 > yaşKişi2;
 Console.WriteLine
 ("11. {0} isimli kişinin yaşı {1} ve {2} isimli kişilerin yaşlarından büyüktür: {3}",
 isimKişi3, isimKişi1, isimKişi2, kıyasla);

 kıyasla = yaşKişi3 >= yaşKişi1 && yaşKişi3 >= yaşKişi2;
 Console.WriteLine
 ("12. {0} isimli kişinin yaşı {1} ve {2} isimli kişilerin yaşlarından büyüktür veya yaşlarına eşittir: {3}",
 isimKişi3, isimKişi1, isimKişi2, kıyasla);

 kıyasla = yaşKişi3 < yaşKişi1 && yaşKişi3 < yaşKişi2;
 Console.WriteLine
 ("13. {0} isimli kişinin yaşı {1} ve {2} isimli kişilerin yaşlarından küçüktür: {3}",
 isimKişi3, isimKişi1, isimKişi2, kıyasla);

 kıyasla = yaşKişi3 <= yaşKişi1 && yaşKişi3 <= yaşKişi2;
 Console.WriteLine
 ("14. {0} isimli kişinin yaşı {1} ve {2} isimli kişilerin yaşlarından küçüktür veya yaşlarına eşittir: {3}",
 isimKişi3, isimKişi1, isimKişi2, kıyasla);


            Console.ReadLine();
        }
    }
}
