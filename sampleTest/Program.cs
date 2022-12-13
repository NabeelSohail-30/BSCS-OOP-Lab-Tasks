using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter c1 = new Counter();
            Console.WriteLine($"Value of static Counter = {Counter.counter} and non static = {c1.counter1}");
            Counter c2 = new Counter();
            Console.WriteLine($"Value of static Counter = {Counter.counter} and non static = {c2.counter1}");
            Counter c3 = new Counter();
            Console.WriteLine($"Value of static Counter = {Counter.counter} and non static = {c3.counter1}");
            Console.Read();
        }
    }

    class Counter
    {
        public static int counter;
        public int counter1;

        public Counter()
        {
            counter++;
            counter1++;
        }
    }
}
