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
        private static int _Number = 1;
        private static int Number { get { return _Number++; }  }
               
        private decimal Balance { get; set; }
        public BankAccount( decimal balance)
        {
            Balance = balance; 
            
        }

        private TypeAcc Type { get; set; }

        public BankAccount(TypeAcc type)
        {
            Type = type;
        }
        public BankAccount(decimal balance,TypeAcc type)
        {
            Balance = balance;
            Type = type;
        }

        public void OUT()
        {
            Console.WriteLine($"номер счета{Number}\t баланс{Balance}\t тип счета{Type}\t");

        }
    }
}


