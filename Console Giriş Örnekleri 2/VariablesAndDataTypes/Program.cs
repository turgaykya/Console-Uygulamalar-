using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Değişken:
             * Bilgisayarın RAM'ınde tutulan, içerisine nümerik veya metinsel
             * değerleri alabilen, programlamanın en temel yapı taşıdır
             * Adı üzerinde, değişkenin değeri sonradan değiştirilebilir
             * ANCAK
             * Değişkenin tipi sonradan değiştirilemez
             * ÇÜNKÜ
             * C# programlama dili STRONGLY TYPED (kesin tipli, tip güvenli)
             * bir programlama dilidir
             */

            // 1. NÜMERİK TİPLER
            // 1.0 Bit tipi


            // 1 bitlik değer
            // 0 / 1
            // SQL'deki adı => bit
            bool boolValue = false;
            Boolean boolValueDotNet = true;



            // 1.1 Tamsayı Tipler

            // 0 - 255
            // 8 Bitlik tam sayı
            // SQL'deki adı => tinyint
            byte byteNumber = 10;
            Byte byteNumberDotNet = 10;


            // Eksi 30bin küsür - Artı 30bin küsür
            // 16bitlik tam sayı
            // SQL'deki adı => smallint
            short shortNumber = 100;
            Int16 shortNumberDotNet = 100;


            // Eksi 2 milyar küsür - Artı 2 milyar küsür
            // 32 bitlik tam sayı
            // SQL'deki adı => int
            int intNumber = 10000;
            Int32 intNumberDotNet = 10000;

            // Eksi çoktan Artı çoka kadar
            // 64 bitlik tam sayı
            // SQL'deki adı bigint
            long longNumber = 100000000;
            Int64 longNumberDotNet = 10000000000000000;


            char letter = 'A';
            Char letterDotNet = 'A';

            int letterCode = (int)letter; 



            // 1.2 Ondalıklı sayılar

            // 32 bitlik ondalıklı sayıdır
            // SQL'deki adı float
            float floatNumber = 1.34893f;
            Single floatNumberDotNet = 1.24334f;

            // 64 bitlik ondalıklı sayı
            // SQL'deki adı float
            double doubleNumber = 1.348534d;
            Double doubleNumberDotNet = 1.3485743;


            // SQL'deki adı decimal, money, smallmoney
            // 128 bitlik ondalıklı sayı
            decimal decimalNumber = 1.3458739485m;
            Decimal decimalNumberDotNet = 3294753945.345976345m;



            // 1.3 metin veri tipleri

            // string dediğimiz tip özünde char[] dizisidir
            string name = "Tsubasa";

            

            // 1.4 Tarih veri tipi

            // SQL'deki adı datetime, datetime2, smalldatetime
            DateTime dateTimeValue = DateTime.Parse("1.1.1980");
            DateTime today = DateTime.Today;
            DateTime now = DateTime.Now;


            // 1.5 Object
            object object1 = 29347;
            object object2 = "Tsubasa Ozora";
            object object3 = DateTime.Today;


            int total = 5 * (int)object1;





            var number1 = 100000;

            var name1 = "Tsubasa";

            
        }
    }
}
