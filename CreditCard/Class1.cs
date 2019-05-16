using System;

namespace CreditCard
{
    public class CreditCard
    {
        private decimal balance = 0;
        private String number;
        public string GetMoney()
        {
            return "Balance: " + balance.ToString();
        }
        public void fullfill(decimal amount)
        {
            this.balance += amount;
        }
        public string GetNumber()
        {
            return this.balance;
        }
        public CreditCard(String number)
        {
            this.number = number;
        }
    }
}