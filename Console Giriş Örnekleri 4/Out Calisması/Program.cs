using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_Calisması
{
    class Program
    {
        static void Main(string[] args)
        {
            string giriş = "5";
            int sayi;
            bool durum = int.TryParse(giriş, out sayi);
            string GirişBolunen = "50";
            string GirişBolen = "5";
            int BolunenSayi = int.Parse(GirişBolunen);
            int BolenSayi = int.Parse(GirişBolen);
            int Sonuc;
            int kontrol = Bolmeislemi(BolunenSayi, BolenSayi);

            Console.ReadLine();
        }

        static int Bolmeislemi(int Bolunen, int Bolen)
        {
            int GidenSonuc;
            if (Bolen == 0)
            {
                GidenSonuc = 0;

            }
            else
            {
                GidenSonuc = Bolunen / Bolen;
            }
            return GidenSonuc;

        //// tip uzerinde f12 yap. class ise referans tip struct ise deger tipli.
            ///// --------  metotlara her zaman değer gonderilir.(kopya) ---------- ///////// ref keyword u stack adresini yollar.
            // out kullanmayınca değer gondermek icin illa metodun değişkeni içerisinde tanımlamak gerekir.
        }
    }
}
