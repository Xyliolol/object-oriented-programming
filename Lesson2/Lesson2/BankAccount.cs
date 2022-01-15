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
        public BankAccount(int account_number, decimal balance, TypeAcc type)
            {
            AccountNumber = account_number;
            Balance = balance;
            Type = type;

            }
        private int AccountNumber { get; set; }

        private decimal Balance { get; set; }

        private TypeAcc Type { get; set; }

       
    public void OUT()
    {
        Console.WriteLine($"номер счета{AccountNumber}\t баланс{Balance}\t тип счета{Type}\t");

    }
}
}
