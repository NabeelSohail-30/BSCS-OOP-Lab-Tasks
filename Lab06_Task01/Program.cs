using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            char choice;
            do
            {
                int opt, opt2;
                Console.WriteLine("--------- ABC Bank ---------");
                Console.WriteLine("----------------------------");
                Console.WriteLine();
                Console.WriteLine("1. Saving Account");
                Console.WriteLine("2. Checking Account");
                Console.Write("Please Select your Account Type: ");
                opt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (opt)
                {
                    case 1:
                        {
                            Saving_Account obj = new Saving_Account();
                            Console.WriteLine("1. Credit Amount");
                            Console.WriteLine("2. Debit Amount");
                            Console.Write("Select your Prefrence: ");
                            opt2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();

                            switch (opt2)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Account Type: Saving");
                                        Console.WriteLine("Transaction Type: Credit");
                                        obj.Credit();
                                        obj.calculateintrest();
                                    }
                                    break;

                                case 2:
                                    {
                                        Console.WriteLine("Account Type: Saving");
                                        Console.WriteLine("Transaction Type: Debit");
                                        obj.Debit();
                                        obj.calculateintrest();
                                    }
                                    break;

                                default:
                                    {
                                        Console.WriteLine("Invalid Selection!!!");
                                    }
                                    break;
                            }
                        }
                        break;

                    case 2:
                        {
                            CheckingAccount obj = new CheckingAccount();
                            Console.WriteLine("1. Credit Amount");
                            Console.WriteLine("2. Debit Amount");
                            Console.Write("Select your Prefrence: ");
                            opt2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();

                            switch (opt2)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Account Type: Checking");
                                        Console.WriteLine("Transaction Type: Credit");
                                        obj.Credit();
                                    }
                                    break;

                                case 2:
                                    {
                                        Console.WriteLine("Account Type: Checking");
                                        Console.WriteLine("Transaction Type: Debit");
                                        obj.Debit();
                                        obj.fee();
                                    }
                                    break;

                                default:
                                    {
                                        Console.WriteLine("Invalid Selection!!!");
                                    }
                                    break;
                            }
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("Invalid Selection!!!");
                        }
                        break;
                }

                Console.Write("Do you want to continue this program? (y/n): ");
                choice = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine();

            } while (choice == 'y' || choice == 'Y');
        }
    }

    class Account
    {
        private double balance = 100000;
        public string name, account;
        public double final_Amt;
        public double withdraw, dep, total;

        public double GetBalance()
        {
            return balance;
        }

        public void SetBalance(double bal)
        {
            balance = bal;
        }

        public void Credit()
        {
            Console.Write("Enter Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Account Number: ");
            account = Console.ReadLine();
            Console.Write("Enter Credit Amount: ");
            dep = Convert.ToDouble(Console.ReadLine());

            total = balance + dep;
            SetBalance(total);

            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine();
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Account Number: " + account);
            Console.WriteLine("Total Balance amount in the account  : " + GetBalance());
        }

        public void Debit()
        {
            Console.Write("Enter Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Account Number: ");
            account = Console.ReadLine();
            Console.Write("Enter Withdraw Amount: ");
            withdraw = Convert.ToDouble(Console.ReadLine());

            if (withdraw <= balance)
            {
                total = balance - withdraw;
                SetBalance(total);
                Console.WriteLine();
                Console.WriteLine("------------------------------");
                Console.WriteLine();
                Console.WriteLine("Name : " + name);
                Console.WriteLine("Account Number: " + account);
                Console.WriteLine("After Withdraw balnace Amount is : " + GetBalance());
            }
            else
                Console.WriteLine("\n\nWithdraw Ammount exceed your Account's Balance.");
        }
    }

    class Saving_Account : Account
    {
        double interest_rate, rate;
        public void calculateintrest()
        {
            interest_rate = 0.02;
            //calculation
            rate = total * (interest_rate / 100);
            final_Amt = total + rate;
            Console.WriteLine("Total Balance Amount with Interest : " + final_Amt);
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    class CheckingAccount : Account
    {
        double fee_per = 15;
        public void fee()
        {
            Console.WriteLine("Balance After Transection Charges : " + (total - fee_per));
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
