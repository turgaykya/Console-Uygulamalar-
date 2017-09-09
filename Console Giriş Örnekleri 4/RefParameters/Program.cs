using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[0];

            while (true)
            {
                Console.Write("Lütfen yeni sayıyı yazınız: ");
                string input = Console.ReadLine();

                if (input == "end")
                    break;

                int number = int.Parse(input);
                int newSize = numbers.Length + 1;
                Array.Resize(ref numbers, newSize);
                numbers[numbers.Length - 1] = number;
            }

            Console.WriteLine("Dizideki elemanlar: ");
            int index = 0;
            while (index < numbers.Length)
            {
                Console.WriteLine(numbers[index]);
                index++;
            }
            Console.ReadLine();
        }


        static void ResizeArray(string[] names, int newSize)
        {
            string[] newArray = new string[newSize];

            int index = 0;
            while (index < newArray.Length && index < names.Length)
            {
                newArray[index] = names[index];
                index++;
            }
            names = newArray;
        }
    }
}
