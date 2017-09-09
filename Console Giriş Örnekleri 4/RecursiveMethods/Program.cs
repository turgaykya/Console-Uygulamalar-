using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Recursive Methods
            // özyinelemeli metotlar
            string input = Console.ReadLine();
            int number = int.Parse(input);
            int fibo = Fibonacci(number);
            Console.WriteLine(fibo);


            Console.ReadLine();
        }

        static int Fibonacci(int step)
        {
            //if (step == 0)
            //    return 0;
            //if (step == 1)
            //    return 1;

            if (step == 0 || step == 1)
                return step;
        
            return Fibonacci(step - 2) + Fibonacci(step - 1);

        }

        static int Factorial(int number)
        {
            return number * Factorial(number - 1);
        }

        //static int Factorial(int number)
        //{
        //    int result = 1;
        //    while (number > 1)
        //    {
        //        result = result * number;
        //        number--;
        //    }
            
        //    return result;
        //}
    }
}
