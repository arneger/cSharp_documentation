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
        private double interest_rate;
        public Bank(string n, double s = 0, double r = 0.01)
        {
            name = n;
            balance = s;
            interest_rate = r;
        }
        // Method for depositing money into the bank account
        public void Deposit(double money)
        {
            double temp_balance = balance;
            balance += money;
            if (temp_balance < 1000000 && balance > 1000000)
                Console.WriteLine("Your interest rate increased by 1 percent");
            Balance_Exceed();
        }
        // Method to withdraw money from the bank account
        public void Withdrawal(double money)
        {
            double temp_balance;
            if (balance < money)
                Console.WriteLine("Money overdraft");
            else
            {
                temp_balance = balance;
                balance -= money;
                if (temp_balance > 1000000 && balance < 1000000)
                    Console.WriteLine("Your interest rate decreased by 1 percent");
                Balance_Exceed();
            }
        }
        // Method that calculates the interest rate on the balance and returns the rate value.
        public double Interest_Calculation()
        {
            return balance * interest_rate;
        }
        // Method that adds the interest rate money value to the balance
        public void Interest_Settlement()
        {
            double temp_balance = balance;
            balance += Interest_Calculation();
            if (temp_balance < 1000000 && balance > 1000000)
                Console.WriteLine("Your interest rate increased by 1 percent");
            Balance_Exceed();
        }
        // Method that increases the interest rate if the balance has reached onver 1 million
        public void Balance_Exceed()
        {
            if (balance > 1000000)
                interest_rate = 0.02;
            else
                interest_rate = 0.01;
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
            ArrayList last_3_changes = new ArrayList(10); 
            while (true)
            {
                string action = Console.ReadLine();
                if (action == "1")
                    Console.WriteLine("Balance: {0}", Convert.ToString(balance));
                else if (action == "2")
                {
                    Console.Write("Amount: ");
                    double amount = Convert.ToDouble(Console.ReadLine());
                    last_3_changes.Add("+" + Convert.ToString(amount));
                    if (last_3_changes.Count == 4)
                        last_3_changes.RemoveAt(0);
                    Deposit(amount);
                    Console.WriteLine("New balance: {0}", balance);
                }
                else if (action == "3")
                {
                    Console.Write("Amount: ");
                    double amount = Convert.ToDouble(Console.ReadLine());
                    last_3_changes.Add("-" + Convert.ToString(amount));
                    if (last_3_changes.Count == 4) 
                        last_3_changes.RemoveAt(0);
                    Withdrawal(amount);
                    Console.WriteLine("New balance: {0}", balance);
                }
                else if (action == "4")
                {
                    last_3_changes.Add("+" + Convert.ToString(balance * interest_rate));
                    if (last_3_changes.Count == 4) 
                        last_3_changes.RemoveAt(0);
                    Interest_Settlement();
                    Console.WriteLine("New balance: {0}", balance);
                }
                else if (action == "5")
                {
                    foreach (string change in last_3_changes)
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