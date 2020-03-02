using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();
            
            byte choice;
            int balance = 0;
            int amount = 0;
            atm.setBalance(balance);

            do
            {
                Console.WriteLine("\n Welcome To ATM \n (1)>>Balance Display \n (2)>>Deposit Process \n (3)>>Withdrawal Process \n (4)>>Exit to Account \n\n Your Choice:");
                choice = byte.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nYour Balance "+ atm.getBalance()+ " TL");
                        break;
                    case 2:
                        Console.WriteLine("The amount you want to deposit = ");
                        amount = int.Parse(Console.ReadLine());
                        if (amount % 10 != 0)
                        {
                           Console.WriteLine("Please, 10 and its multiples can be deposited.");
                           break;
                        }
                        atm.deposit(amount);
                        break;
                    case 3:
                        Console.WriteLine("The amount you want to withdraw = ");
                        amount = int.Parse(Console.ReadLine());
                        if (amount % 10 != 0)
                        {
                            Console.WriteLine("Please, 10 and its multiples can be pulled.");
                            break;
                        }
                        atm.withDrawMoney(amount);
                        break;
                    default:
                        Console.WriteLine("Wrong choice, try again");
                        break;
                }
            } while (choice != 4);
        }
    }
}
