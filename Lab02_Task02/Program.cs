using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicCalculation calc = new BasicCalculation();

            Console.WriteLine("Basic Calculator");
            Console.WriteLine("----------------");
            Console.Write("Enter Number 01: ");
            calc.Number01 = float.Parse(Console.ReadLine());
            Console.Write("Enter Number 02: ");
            calc.Number02 = float.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Sum = {calc.Sum()}");
            Console.WriteLine($"Product = {calc.Product()}");
            Console.WriteLine($"Difference = {calc.Difference()}");
            Console.WriteLine($"Quotient = {calc.Quotient()}");

            Console.Read();
        }
    }

    class BasicCalculation
    {
        public float Number01 { get; set; }
        public float Number02 { get; set; }

        public float Sum()
        {
            return Number01 + Number02;
        }

        public float Product()
        {
            return Number01 * Number02;
        }

        public float Difference()
        {
            return Number02 - Number01;
        }

        public float Quotient()
        {
            return Number01 / Number02;
        }
    }
}
