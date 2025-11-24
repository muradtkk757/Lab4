using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Student
    {
        private string _name;
        private int _age;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 18)
                    _age = value;
                else
                {
                    Console.WriteLine("Yas 18 den kicik ola bilmez");
                }

            }
        }
    }
}


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

class MathTools
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }
}


