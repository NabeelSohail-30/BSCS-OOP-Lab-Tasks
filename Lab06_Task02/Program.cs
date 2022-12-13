using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            AssessmentSummary obj = new AssessmentSummary();

            obj.SetGeneralInfo();
            Console.WriteLine();
            obj.SetStudentInfo();
            Console.WriteLine();
            obj.SetMarks();
            Console.WriteLine();
            obj.SetMarksheetSummary();

            Console.WriteLine();
            Console.WriteLine();

            obj.GetGeneralInfo();
            Console.WriteLine();
            obj.GetStudentInfo();
            Console.WriteLine();
            obj.GetMarks();
            Console.WriteLine();
            obj.GetMarksheetSummary();

            Console.Read();
        }
    }

    class General
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public DateTime Dob { get; set; }
        public string Email { get; set; }

        public void SetGeneralInfo()
        {
            Console.WriteLine("Enter General Details");
            Console.WriteLine("---------------------");

            Console.Write("Name: ");
            this.Name = Console.ReadLine();
            Console.Write("Father Name: ");
            this.FatherName = Console.ReadLine();
            Console.Write("Phone Number: ");
            this.PhoneNumber = Console.ReadLine();
            Console.Write("Age: ");
            this.Age = int.Parse(Console.ReadLine());
            Console.Write("Date of Birth: ");
            this.Dob = DateTime.Parse(Console.ReadLine());
            Console.Write("Email: ");
            this.Email = Console.ReadLine();
        }

        public void GetGeneralInfo()
        {
            Console.WriteLine("General Information");
            Console.WriteLine("-------------------");
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Father Name: {this.FatherName}");
            Console.WriteLine($"Phone Number: {this.PhoneNumber}");
            Console.WriteLine($"Age: {this.Age}");
            Console.WriteLine($"Date of Birth: {this.Dob.ToLongDateString()}");
            Console.WriteLine($"Email: {this.Email}");
        }
    }

    class Student : General
    {
        public string RollNumber { get; set; }
        public string Department { get; set; }
        public int Semester { get; set; }

        public void SetStudentInfo()
        {
            Console.WriteLine("Enter Student Details");
            Console.WriteLine("---------------------");

            Console.Write("Roll Number: ");
            this.RollNumber = Console.ReadLine();

            Console.Write("Department: ");
            this.Department = Console.ReadLine();

            Console.Write("Semester: ");
            this.Semester = int.Parse(Console.ReadLine());
        }

        public void GetStudentInfo()
        {
            Console.WriteLine("Student Detail");
            Console.WriteLine("--------------");
            Console.WriteLine($"Roll Number: {this.RollNumber}");
            Console.WriteLine($"Department: {this.Department}");
            Console.WriteLine($"Semester: {this.Semester}");
        }
    }

    class Marks : Student
    {
        protected int NumOfSubjects;
        public List<float> ListSubjectsMarks = new List<float>();
        public List<string> ListSubjects = new List<string>();

        public void SetMarks()
        {
            string subject;
            float mark;
            Console.Write("Enter Number of Subjects: ");
            this.NumOfSubjects = int.Parse(Console.ReadLine());

            for (int i = 0; i < this.NumOfSubjects; i++)
            {
                Console.Write("Enter Subject Name: ");
                subject = Console.ReadLine();
                Console.Write($"Enter Marks for Subject {subject}: ");
                mark = float.Parse(Console.ReadLine());

                ListSubjects.Add(subject);
                ListSubjectsMarks.Add(mark);
            }
        }

        public void GetMarks()
        {
            Console.WriteLine("Marks of Subjects");
            Console.WriteLine("-----------------");

            for (int i = 0; i < this.NumOfSubjects; i++)
            {
                Console.WriteLine($"{ListSubjects[i]}: {ListSubjectsMarks[i]}");
            }
        }
    }

    class AssessmentSummary : Marks
    {
        public float Percentage { get; set; }
        public float AverageMarks { get; set; }
        public string Grade { get; set; }
        public float CGPA { get; set; }
        private float sum;

        public void SetMarksheetSummary()
        {
            //Average Marks
            CalculateAvgMarks();

            //Percentage
            CalculatePercentage();

            //Grade
            CalculateGrade();

            //CGPA
            CalculateCGPA();
        }

        public void GetMarksheetSummary()
        {
            Console.WriteLine("Marksheet Summary");
            Console.WriteLine("--------------");
            Console.WriteLine($"Obtained Marks: {this.sum}");
            Console.WriteLine($"Average Marks: {this.AverageMarks}");
            Console.WriteLine($"Percentage: {this.Percentage}");
            Console.WriteLine($"Grade: {this.Grade}");
            Console.WriteLine($"CGPA: {this.CGPA}");
        }

        private void CalculateCGPA()
        {
            //CGPA
            if (this.Percentage >= 95)
            {
                this.CGPA = 4.00F;
            }
            else if (this.Percentage >= 90)
            {
                this.CGPA = 3.50F;
            }
            else if (this.Percentage >= 85)
            {
                this.CGPA = 3.00F;
            }
            else if (this.Percentage >= 80)
            {
                this.CGPA = 2.50F;
            }
            else if (this.Percentage >= 75)
            {
                this.CGPA = 2.50F;
            }
            else if (this.Percentage >= 70)
            {
                this.CGPA = 2.00F;
            }
            else if (this.Percentage >= 60)
            {
                this.CGPA = 1.50F;
            }
            else if (this.Percentage >= 50)
            {
                this.CGPA = 1.00F;
            }
            else
            {
                this.CGPA = 0;
            }
        }

        private void CalculateGrade()
        {
            //Grade
            if (this.Percentage >= 90)
            {
                this.Grade = "A+";
            }
            else if (this.Percentage >= 80)
            {
                this.Grade = "A";
            }
            else if (this.Percentage >= 70)
            {
                this.Grade = "B";
            }
            else if (this.Percentage >= 60)
            {
                this.Grade = "C";
            }
            else if (this.Percentage >= 50)
            {
                this.Grade = "D";
            }
            else if (this.Percentage >= 40)
            {
                this.Grade = "E";
            }
            else
            {
                this.Grade = "F";
            }
        }

        private void CalculatePercentage()
        {
            this.Percentage = (sum / (this.NumOfSubjects * 100)) * 100;
        }

        private void CalculateAvgMarks()
        {
            for (int i = 0; i < NumOfSubjects; i++)
            {
                sum += ListSubjectsMarks[i];
                this.AverageMarks = sum / this.NumOfSubjects;
            }
        }
    }
}
