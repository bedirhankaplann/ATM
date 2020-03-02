using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class ATM
    {
        private int addAmount { get; set; }
        private int balance { get; set; }

        public int getAmount()
        {
            return addAmount;
        }
        public void setAmount(int addAmount)
        {
            this.addAmount = addAmount;
        }
        public int getBalance()
        {
            return balance;
        }
        public void setBalance(int balance)
        {
            this.balance = balance;
        }
        public void deposit(int amount)
        {
            this.balance += amount;
        }
        public void withDrawMoney(int amount)
        {
            this.balance -= amount;
        }
    }
}