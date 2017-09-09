using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            //RESİZE KULLANIMI : Dizinin boyutunu değiştirir.
            string[] gunler = new string[7];
            gunler[0] = "Pazartesi";
            gunler[1] = "Salı";
            gunler[2] = "Çarşamba";
            gunler[3] = "Perşembe";
            gunler[4] = "Cuma";
            gunler[5] = "Cumartesi";
            gunler[6] = "Pazar";
            Array.Resize(ref gunler, 10);
            Console.WriteLine ( gunler.Length.ToString());
            //ARRAY.BİNARYSEARCH:C# ile dizi içerisinde arama yapmak kullanılan metotudur.
            //Array.BinarySearch kullanabilmek için ilk olarak diziyi sıralamak gerekir ondan sonra arama yapılabilir. 
            //Komut bize sonuç olarak bulunan değerin indis numarasını verir , eğer bulunamazsa eksi değer gönderir.
            string[] gunler2 = new string[7];
            gunler2[0] = "Pazartesi";
            gunler2[1] = "Salı";
            gunler2[2] = "Çarşamba";
            gunler2[3] = "Perşembe";
            gunler2[4] = "Cuma";
            gunler2[5] = "Cumartesi";
            gunler2[6] = "Pazar";
            Array.Sort(gunler2);
            int sira = Array.BinarySearch(gunler2, "Pazar");
            Console.WriteLine(sira);
            //Array.CopyTo : Burada dizi1'in tüm elemanları dizi2'ye 3. indeksten itibaren kopyalanıyor.
            int[] dizi1 = { 1, 2, 3, 4 };
            int[] dizi2 = new int[10];
            dizi1.CopyTo(dizi2, 3);

            //Burada 3 tane eleman dizi1'den dizi2'ye kopyalanır. Kopyalama işlemi 0. indeksten başlar.
            //int[] dizi1 = { 1, 2, 3, 4 };
            //int[] dizi2 = new int[10];
            //Array.Copy(dizi1, dizi2, 3);

            //Burada dizi1'in 2. indeksinden itibaren 3 eleman, dizi2'ye 7. indeksten itibaren kopyalanıyor.
            //int[] dizi1={1,2,3,4,5,6,7};
            //int[] dizi2=new int[10];
            //Array.Copy(dizi1,2,dizi2,7,3);

            // Array.Clear:Bu kod dizi dizisinin 1. indeksinden itibaren 3 indeksini sıfırlar (varsayılan değere döndürür).
            Array.Clear(dizi1, 1, 3);

            //Array.Reverse:Bu kod dizi dizisinin 1. indeksten itibaren 3 elemanını ters çevirir.
            Array.Reverse(dizi1, 1, 3);

        }
    }
}
