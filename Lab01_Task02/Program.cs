using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

            Console.WriteLine("Area of Rectangle");
            Console.WriteLine("-----------------");

            Console.Write("Enter Length: ");
            rectangle.Length = double.Parse(Console.ReadLine());

            Console.Write("Enter Width: ");
            rectangle.Width = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Area: {rectangle.GetArea()}");

            Console.Read();
        }
    }

    class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double GetArea()
        {
            return Length * Width;
        }
    }
}
