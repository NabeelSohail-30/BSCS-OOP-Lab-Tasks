using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            Console.WriteLine("Enter Student Details");
            Console.WriteLine("---------------------");
            Console.Write("Name: ");
            std.Name = Console.ReadLine();
            Console.Write("Age: ");
            std.Age = int.Parse(Console.ReadLine());
            Console.Write("Marks in English: ");
            std.mEnglish = double.Parse(Console.ReadLine());
            Console.Write("Marks in Math: ");
            std.mMath = double.Parse(Console.ReadLine());
            Console.Write("Marks in Science: ");
            std.mScience = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Student's Details");
            Console.WriteLine("-----------------");
            Console.WriteLine($"Name: {std.Name}");
            Console.WriteLine($"Age: {std.Age}");
            Console.WriteLine($"Marks in English: {std.mEnglish}");
            Console.WriteLine($"Marks in Math: {std.mMath}");
            Console.WriteLine($"Marks in Science: {std.mScience}");
            Console.WriteLine($"Obtained Marks: {(float)std.CalculateTotalMarks()}");
            Console.WriteLine($"Percentage: {(float)std.CalculatePercentage()}");

            Console.Read();
        }
    }

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double mEnglish { get; set; }
        public double mMath { get; set; }
        public double mScience { get; set; }

        private double TotalMarks = 300;

        public double CalculateTotalMarks()
        {
            return (this.mEnglish + this.mMath + this.mScience);
        }

        public double CalculatePercentage()
        {
            return (this.CalculateTotalMarks() / this.TotalMarks) * 100;
        }
    }
}
