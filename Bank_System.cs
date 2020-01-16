using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ConsoleApp6
{
    /* A simple console application that let you deposit, withdraw, calculate interest rate 
     and so on in the console. Doesn't save the data to a file, but I would probably use JSON for that. 
     */
    class Bank
    {
        private double balance;
        public string name;
        private double interestRate;
        public Bank(string n, double s = 0, double r = 0.01)
        {
            name = n;
            balance = s;
            interestRate = r;
        }
        // Method for depositing money into the bank account
        public void Deposit(double money)
        {
            double tempBalance = balance;
            balance += money;
            if (tempBalance < 1000000 && balance > 1000000)
                Console.WriteLine("Your interest rate increased by 1 percent");
            Balance_Exceed();
        }
        // Method to withdraw money from the bank account
        public void Withdrawal(double money)
        {
            double tempBalance;
            if (balance < money)
                Console.WriteLine("Money overdraft");
            else
            {
                tempBalance = balance;
                balance -= money;
                if (tempBalance > 1000000 && balance < 1000000)
                    Console.WriteLine("Your interest rate decreased by 1 percent");
                Balance_Exceed();
            }
        }
        // Method that calculates the interest rate on the balance and returns the rate value.
        public double interesCalculation()
        {
            return balance * interestRate;
        }
        // Method that adds the interest rate money value to the balance
        public void Interest_Settlement()
        {
            double tempBalance = balance;
            balance += interesCalculation();
            if (tempBalance < 1000000 && balance > 1000000)
                Console.WriteLine("Your interest rate increased by 1 percent");
            Balance_Exceed();
        }
        // Method that increases the interest rate if the balance has reached onver 1 million
        public void Balance_Exceed()
        {
            if (balance > 1000000)
                interestRate = 0.02;
            else
                interestRate = 0.01;
        }
        // Method that prints the menu
        public void Show_Menu()
        {
            Console.WriteLine("TYPE VALUE AND ENTER TO NAVIGATE (For instance: 2+ENTER for Deposit)\n1 - Show balance\n2 - Deposit\n3 - Withdrawal\n4 - Interest-settlement\n5 - Recent balance-changes\nm - menu\nx - Exit program");
        }
        // Methods that lets the user navigate the menu in the console
        public void Start_Menu()
        {
            Show_Menu();
            ArrayList lastChanges = new ArrayList(10);
            while (true)
            {
                string action = Console.ReadLine();
                if (action == "1")
                    Console.WriteLine("Balance: {0}", Convert.ToString(balance));
                else if (action == "2")
                {
                    Console.Write("Amount: ");
                    double amount = Convert.ToDouble(Console.ReadLine());
                    lastChanges.Add("+" + Convert.ToString(amount));
                    if (lastChanges.Count == 4)
                        lastChanges.RemoveAt(0);
                    Deposit(amount);
                    Console.WriteLine("New balance: {0}", balance);
                }
                else if (action == "3")
                {
                    Console.Write("Amount: ");
                    double amount = Convert.ToDouble(Console.ReadLine());
                    lastChanges.Add("-" + Convert.ToString(amount));
                    if (lastChanges.Count == 4)
                        lastChanges.RemoveAt(0);
                    Withdrawal(amount);
                    Console.WriteLine("New balance: {0}", balance);
                }
                else if (action == "4")
                {
                    lastChanges.Add("+" + Convert.ToString(balance * interestRate));
                    if (lastChanges.Count == 4)
                        lastChanges.RemoveAt(0);
                    Interest_Settlement();
                    Console.WriteLine("New balance: {0}", balance);
                }
                else if (action == "5")
                {
                    foreach (string change in lastChanges)
                    {
                        Console.WriteLine(change);
                    }
                }
                else if (action == "x")
                {
                    Console.WriteLine("Program has ended");
                    break;
                }
                else if (action == "m")
                    Show_Menu();
                else
                    continue;


            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Bank user1 = new Bank("Eric", 500);
            user1.Start_Menu();
        }
    }
}
