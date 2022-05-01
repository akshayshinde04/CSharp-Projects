using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Program
    {   
        class Bank
        {
            int money = 1000;
            String accName = "Capt Jack";
            String accNum;
            static String bankName = "American Express";
            static public int updatedBalance;
            public void depositMoney ()
            {
                Console.WriteLine("Enter the amount you want to deposite:");
                int depMoney = int.Parse(Console.ReadLine());
                updatedBalance = money + depMoney;
                if (depMoney == 0)
                {
                    Console.WriteLine("minimum deposit should be 100 ");
                }
                else
                {
                    Console.WriteLine("updated balance of " + accName + " after deposit is " + updatedBalance);
                }
            }
            public void withdrawMoney()
            {
                try
                {
                    Console.WriteLine("Welcome " + accName + " your accountbalance: " + updatedBalance);
                    Console.WriteLine("Enter the amount you want to withdraw:");
                    int withdraw = int.Parse(Console.ReadLine());
                    updatedBalance = updatedBalance - withdraw;
                    if (withdraw > updatedBalance)
                    {
                        Console.WriteLine("Insufficient Balance");
                    }
                    else
                    {
                        Console.WriteLine("updated balance of " + accName + " after withdrawal is " + updatedBalance);
                    }
                }catch (Exception ex)
                {
                    Console.WriteLine(" Updated balance of " + accName + " after withdrawal is " + updatedBalance);
                }
            }
            public void Balance()
            {
                Console.WriteLine("Welcome to the " + bankName + "bank ");
                Console.WriteLine("Enter account number: ");
                accNum = Console.ReadLine();
                Console.WriteLine("Welcome " + accName + " your account balance: " + money);

            }
        }
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.Balance();
            bank.depositMoney();
            bank.withdrawMoney();
            Console.ReadLine();
        }
    }
}

       

