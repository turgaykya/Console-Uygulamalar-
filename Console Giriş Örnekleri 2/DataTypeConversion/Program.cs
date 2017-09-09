using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            string input = Console.ReadLine();


            Int16 shortNumber = short.Parse(input);
            int intNumber = Int32.Parse(input);

            double doubleNumber = Double.Parse(input);
            DateTime dateValue = DateTime.Parse(input);


            string numberAsString = intNumber.ToString();

            string boolAsString = true.ToString();

            string intAsString = 100.ToString();

            string dateAsString = DateTime.Today.ToString();

            object anything = "Tsubasa Ozora";

            string objectAsString = anything.ToString();








            int integer32Number = 100000000;

            // CAST etme işlemi
            // Nümerik tipleri birbirine CAST ederek dönüştürebilirim
            // (TYPE) ifadesi ile dönüşüme EXPLICIT CAST
            // açık dönüşüm denir
            short integer16Number = (short)integer32Number;


            decimal decimalNumber = 298743658365836583;


            // IMPICIT CAST
            // Kapalı dönüşüm
            decimalNumber = integer32Number;



            char aLetter = 'A';

            // char tipini doğrudan short veya int gibi
            // nümerik tipe KAPALI şekilde cast edebiliyoruz
            int aLetterCode = aLetter;

            // nümerik tipi char tipine AÇIK şekilde
            // cast edebiliyoruz
            aLetter = (char)aLetterCode;





            string value = "1000";

            int nameAsInteger = int.Parse(value);





            int integerNumber = 10000000;

            byte byteNumber = Convert.ToByte(integerNumber);






        }
    }
}
