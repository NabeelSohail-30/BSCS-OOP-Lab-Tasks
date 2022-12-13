using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Name myName = new Name();

            Console.WriteLine("Vowels Counter");
            Console.WriteLine("--------------");

            Console.Write("Enter Name: ");
            myName.name = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"Name ({myName.name}) contains {myName.GetVowels()} vowels");

            Console.Read();
        }
    }

    class Name
    {
        public string name { get; set; }

        public int GetVowels()
        {
            int vowelsCount = 0;

            foreach (char ch in this.name.ToLower())
            {
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    vowelsCount++;
                }
            }
            return vowelsCount;
        }
    }
}
