using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount(14997789, 554875, TypeAcc.Credite);
            bankAccount.OUT();
            bankAccount.OUT();
            bankAccount.OUT();
        }
    }
    
}
