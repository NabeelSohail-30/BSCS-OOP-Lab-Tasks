using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleClass obj = new SampleClass();
            SampleClass obj1 = new SampleClass("Nabeel, 211");
            SampleClass obj2 = new SampleClass(25,211);

            Console.Read();
        }
    }

    class SampleClass
    {
        public SampleClass()
        {
            Console.WriteLine("This is my Data of Class 'Sample Class' ");
        }

        public SampleClass(string name)
        {
            Console.WriteLine($"Name and Roll No.: {name}");
        }

        public SampleClass(int num1, int num2)
        {
            num1 += 2;
            Console.WriteLine($"Sum = {num1+num2}");
        }
    }
}
