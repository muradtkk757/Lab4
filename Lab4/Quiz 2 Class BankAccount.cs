using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class BankAccount
    {
        private decimal _balance;
        public decimal Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }
        public void Deposit(decimal pul)
        {
            Balance = +pul;
        }
        public decimal GetBalance()
        {
            return Balance;
        }
    }
}