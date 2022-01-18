using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount( 554875);
            BankAccount bankAccount1 = new BankAccount(TypeAcc.Credite);
            BankAccount bankAccount2 = new BankAccount(554875, TypeAcc.Credite);

            bankAccount.OUT();
            bankAccount1.OUT();
            bankAccount2.OUT();
        }
    }
    
}
