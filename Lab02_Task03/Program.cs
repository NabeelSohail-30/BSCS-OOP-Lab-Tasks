using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();

            Console.WriteLine("Circle Details");
            Console.WriteLine("--------------");

            Console.Write("Enter value of Radius: ");
            circle.Radius = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Diameter of Circle: {circle.GetDiameter()}");
            Console.WriteLine($"Circumference of Circle: {circle.GetCircumference()}");
            Console.WriteLine($"Area of Circle: {circle.GetArea()}");

            Console.Read();
        }
    }

    class Circle
    {
        public double Radius { get; set; }
        const double Pi = 3.142;

        public double GetDiameter()
        {
            return 2 * Radius;
        }

        public double GetCircumference()
        {
            return 2 * Pi * Radius;
        }

        public double GetArea()
        {
            return Pi*(Math.Pow(Radius,2));
        }
    }
}
