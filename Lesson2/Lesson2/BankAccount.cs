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
        private int AccountNumber { get; set; }
        
        public BankAccount(int account_number, decimal balance, TypeAcc type)
        {
            AccountNumber = account_number;
            Balance = balance;
            Type = type;

        }
       
        private decimal Balance { get; set; }

        private TypeAcc Type { get; set; }


        public void OUT()
        {
            Console.WriteLine($"номер счета{Number}\t баланс{Balance}\t тип счета{Type}\t");

        }
    }
}


