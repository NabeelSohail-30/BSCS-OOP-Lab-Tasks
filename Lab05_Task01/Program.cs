using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray1;
            string[] strArray2;

            Console.WriteLine("Program to check the equality of two arrays");
            Console.WriteLine("===========================================");

            Console.Write("Enter number of elements for array 01: ");
            int NumOfElement01 = int.Parse(Console.ReadLine());

            Console.Write("Enter number of elements for array 01: ");
            int NumOfElement02 = int.Parse(Console.ReadLine());

            strArray1 = new string[NumOfElement01];
            strArray2 = new string[NumOfElement02];

            Console.WriteLine();

            Console.WriteLine("Enter Elements of Array 01");
            for (int i = 0; i < NumOfElement01; i++)
            {
                Console.Write($"Enter Element {i + 1}: ");
                strArray1[i] = Console.ReadLine();
            }
            Console.WriteLine();

            Console.WriteLine("Enter Elements of Array 02");
            for (int i = 0; i < NumOfElement02; i++)
            {
                Console.Write($"Enter Element {i + 1}: ");
                strArray2[i] = Console.ReadLine();
            }
            Console.WriteLine();

            if (Enumerable.SequenceEqual(strArray1, strArray2))
            {
                Console.WriteLine("Array are Equal");
            }
            else
            {
                Console.WriteLine("Array are not Equal");
            }

            Console.Read();
        }
    }
}
