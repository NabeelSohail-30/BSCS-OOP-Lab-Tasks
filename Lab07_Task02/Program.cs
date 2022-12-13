using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            GeeksforGeeks obj = new GeeksforGeeks();
            obj.languages();
            obj.courses();
            Console.Read();
        }
    }

    interface GFG1
    {
        void languages();
    }

    class Geeks1 : GFG1
    {
        public void languages()
        {
            ArrayList My_list = new ArrayList();

            My_list.Add("C");
            My_list.Add("C++");
            My_list.Add("C#");
            My_list.Add("Java");

            Console.WriteLine("Languages provided by GeeksforGeeks:");
            foreach (var elements in My_list)
            {
                Console.WriteLine(elements);
            }
        }
    }

    interface GFG2
    {
        void courses();
    }

    class Geeks2 : GFG2
    {
        public void courses()
        {
            ArrayList My_list = new ArrayList();

            My_list.Add("System Design");
            My_list.Add("Fork Python");
            My_list.Add("Geeks Classes DSA");
            My_list.Add("Fork Java");

            Console.WriteLine("\nCourses provided by GeeksforGeeks:");
            foreach (var elements in My_list)
            {
                Console.WriteLine(elements);
            }
        }
    }

    class GeeksforGeeks : GFG1, GFG2
    {
        Geeks1 obj1 = new Geeks1();
        Geeks2 obj2 = new Geeks2();

        public void languages()
        {
            obj1.languages();
        }

        public void courses()
        {
            obj2.courses();
        }
    }
}
