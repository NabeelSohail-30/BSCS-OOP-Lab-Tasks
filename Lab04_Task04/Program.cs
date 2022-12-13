using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            u.Name = "Burak";
            u.Location = "Turkey";
            u.Age = 40;
            u.GetUserDetails();
            Console.Read();
        }
    }

    class User
    {
        protected internal string Name;
        protected internal string Location;
        protected internal int Age;
        protected internal void GetUserDetails()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Location: {0}", Location);
            Console.WriteLine("Age: {0}", Age);
        }
    }
}
