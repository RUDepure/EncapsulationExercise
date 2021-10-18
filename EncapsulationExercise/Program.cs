using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAcc = new BankAccount();
            string command = "";
            double money = 0;
            bool deposit = false;
            double currBalance = 0;

            do
            {
                Console.WriteLine("Please enter the action you want to take in your balance account:");
                Console.WriteLine("Deposit - to deposit money into your account.");
                Console.WriteLine("Withdraw - to withdraw money from your account.");
                Console.WriteLine("Balance - to check your current balance.");
                Console.WriteLine($"Exit - to exit the aplication.\n");

                command = Console.ReadLine();

                switch (command.ToLower())
                {
                    case "deposit":
                        Console.WriteLine($"Please enter the amount of money you want to deposit in your account: \n");
                        deposit = double.TryParse(Console.ReadLine(), out money);

                        while (deposit == false)
                        {
                            Console.WriteLine("Please enter a valid numeric value.");
                            deposit = double.TryParse(Console.ReadLine(), out money);
                        }

                        bankAcc.Deposit(money);
                        break;

                    case "withdraw":
                        currBalance = bankAcc.GetBalance();
                        Console.WriteLine($"Please enter the amount of money you want to withdraw from your account: \n Current balance = {currBalance} \n");

                        do
                        {
                            deposit = double.TryParse(Console.ReadLine(), out money);
                            while (deposit == false)
                            {
                                Console.WriteLine($"Please enter a valid numeric value. \n");
                                deposit = double.TryParse(Console.ReadLine(), out money);
                            }

                            if (money > currBalance)
                                Console.WriteLine($"You cannot withdraw more money than your current bank account balance, please try again \n");

                        } while (money > currBalance);

                        bankAcc.Withdraw(money);
                        break;
                    case "balance":
                        currBalance = bankAcc.GetBalance();
                        Console.WriteLine($"Your current balance is {currBalance} \n");
                        break;
                    case "exit":
                        break;
                    default:
                        Console.WriteLine($"This command does not exist, please try again.\n");
                        break;
                }

            } while (command != "exit");
        }
    }
}
