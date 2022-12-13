using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, divide;

            try
            {
                Console.WriteLine("Enter Number a: ");
                num1 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter Number b: ");
                num2 = Convert.ToInt16(Console.ReadLine());
                divide = num1 / num2;
                Console.WriteLine("Value of a / b is : " + divide);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error: " + e.Message);

            }
            finally
            {
                Console.WriteLine("\nCodeboks.com");
            }
            Console.Read();
        }
    }
}
