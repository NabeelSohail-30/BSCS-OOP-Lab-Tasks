using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Task01b
{
    class Program
    {
        static void Main(string[] args)
        {

            int number1;
            Console.Write("Please enter the first integer: ");
            number1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nThe sum is {0}.", number1);

            Console.Write("\nPlease enter the second integer: ");
            string secondNumber = Console.ReadLine();
            number1 = Int32.Parse(secondNumber);
            Console.WriteLine("\nThe sum is {0}.", number1);

            Console.Read();
        }
    }
}
