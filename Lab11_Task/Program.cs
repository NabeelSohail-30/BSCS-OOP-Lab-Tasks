using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = new int[8];
            int temp;

            for(int a=0; a < myArr.Length; a++)
            {
                Console.Write("Enter value: ");
                myArr[a] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Original Array");
            foreach (int p in myArr)
                Console.Write(p + " ");

            for (int j = 0; j <= myArr.Length - 2; j++)
            {
                for (int i = 0; i <= myArr.Length - 2; i++)
                {
                    if (myArr[i] > myArr[i + 1])
                    {
                        temp = myArr[i + 1];
                        myArr[i + 1] = myArr[i];
                        myArr[i] = temp;
                    }
                }
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Bubble sort data:");
            foreach (int p in myArr)
                Console.Write(p + " ");
            Console.Read();
        }
    }
}
