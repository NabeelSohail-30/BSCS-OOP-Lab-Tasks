using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();

            myObj.Name = "Burak";
            myObj.Age = 40;
            myObj.Nationality = "Turkish";

            Console.WriteLine($"Name: {myObj.Name}");
            Console.WriteLine($"Age: {myObj.Age}");
            Console.WriteLine($"Nationality: {myObj.Nationality}");

            Console.Read();
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Nationality { get; set; }
    }
}
