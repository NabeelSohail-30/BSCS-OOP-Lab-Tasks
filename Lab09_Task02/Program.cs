using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Task02
{
    class Program
    {
        static int user(int book)
        {
            if (book == 0)
                throw new System.OutOfMemoryException();
            return book;
        }
        static void Main(string[] args)
        {
            int b = 0;
            int avaible = 0;
            try
            {
                avaible = user(b);
                Console.WriteLine("AVAILABILITY", avaible);
            }
            catch (OutOfMemoryException s)
            {
                Console.WriteLine("\n \tCheck the book is already issued ", s);
            }
            Console.ReadLine();
        }
    }
}
