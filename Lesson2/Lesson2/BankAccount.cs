using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    enum TypeAcc
    {
        Credite,
        Debet,
        Cumulative
    }
    class BankAccount
    {
        private static int i = 1;
        int calc()
        {
            return i++;
        }
        private int _Number;
        public int Number
        {
            get
            {
                return this._Number;
            }
            set
            {
                this._Number = value;

            }

        }

        private decimal _Balance;

        public decimal Balance
        {
            get
            {
                return this._Balance;
            }
            set
            {
                this._Balance = value;
            }
        } 
        TypeAcc _Type;
        public TypeAcc Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                this._Type = value;
            }
        }
        public BankAccount(decimal balance)
        {

            Balance = balance;
            _Number = calc();
        }
       
        public BankAccount()
        {
            _Number = calc();

        }

        public BankAccount(TypeAcc type)
        {
            Type = type;
            _Number = calc();
        }
        public BankAccount(decimal balance, TypeAcc type)
        {
            Balance = balance;
            Type = type;
            _Number = calc();
        }

        public void OUT()
        {
            Console.WriteLine($"номер счета{Number}\t баланс{Balance}\t тип счета{Type}\t");

        }
    }
}


