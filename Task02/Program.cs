using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            float RectangleWidth, RectangleLength, RectangleArea;

            Console.WriteLine("Enter Attributes of Rectangle");
            Console.WriteLine("-----------------------------");

            Console.Write("Width: ");
            RectangleWidth = float.Parse(Console.ReadLine());

            Console.Write("Length: ");
            RectangleLength = float.Parse(Console.ReadLine());

            RectangleArea = RectangleWidth * RectangleLength;

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Area of Rectangle is: " + RectangleArea);

            Console.ReadKey();
        }
    }
}
