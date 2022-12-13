using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Enter a positive Number: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine($"Factorial of number {num} is {factorial(num)}");

            Console.Read();
        }

        static int factorial(int num)
        {
            int fact = 1;
            while(num > 0)
            {
                fact *= num;
                num--;
            }

            return fact;
        }
    }
}
