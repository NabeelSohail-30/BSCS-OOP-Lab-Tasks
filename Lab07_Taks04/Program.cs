using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_Taks04
{
    class Program
    {
        static void Main(string[] args)
        {
            Transaction tr = new Transaction("012888456", "06-05-2020", 2500);
            tr.ShowTransaction();
            Console.WriteLine($"Total Amount: {tr.GetAmount()}");
            Console.Read();
        }
    }

    interface ITransaction
    {
        void ShowTransaction();
        double GetAmount();
    }

    class Transaction : ITransaction
    {
        private string tCode;
        private string date;
        private double amount;

        public Transaction()
        {

        }

        public Transaction(string code, string d, double am)
        {
            this.tCode = code;
            this.date = d;
            this.amount = am;
        }

        public double GetAmount()
        {
            return amount;
        }

        public void ShowTransaction()
        {
            Console.WriteLine($"Transaction Code: {tCode}");
            Console.WriteLine($"Transaction Date: {date}");
            Console.WriteLine($"Transaction Amount: {amount}");
        }
    }
}
