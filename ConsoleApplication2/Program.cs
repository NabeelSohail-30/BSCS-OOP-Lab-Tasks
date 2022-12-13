using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER LENGHT AND WIDTH OF AREA OF RECTANGLE");
            int lenght = 2;
            int width = 2;
            int areaofrectangle;
            areaofrectangle = lenght * width;
            Console.WriteLine("YOUR AREA OF RECTANGLE IS : " + areaofrectangle);
            Console.ReadKey();

        }
    }
}