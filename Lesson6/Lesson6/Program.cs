using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount(55000,TypeAcc.Credite);
            BankAccount bankAccount1 = new BankAccount(100000,TypeAcc.Credite);
            BankAccount bankAccount2 = new BankAccount(554000, TypeAcc.Credite);
            BankAccount bankAccount3 = new BankAccount(554000, TypeAcc.Credite);

            bankAccount.OUT();
            bankAccount1.OUT();
            bankAccount2.OUT();
            Console.WriteLine("проверка на равенство");
            Console.WriteLine(bankAccount1 == bankAccount1);
            Console.WriteLine("проверка на равенство");
            Console.WriteLine(bankAccount == bankAccount1);
            Console.WriteLine("проверка на не равенство");
            Console.WriteLine(bankAccount1 != bankAccount2);
            Console.WriteLine("проверка на не равенство");
            Console.WriteLine(bankAccount1 != bankAccount1);
            Console.WriteLine("перевод в строковый тип");
            Console.WriteLine(bankAccount.ToString());
            Console.WriteLine("хэш код аккаунта");
            Console.WriteLine(bankAccount.GetHashCode());
            Console.WriteLine("переопределенный Equals");
            Console.WriteLine(bankAccount2.Equals(bankAccount3));
            Console.WriteLine("переопределенный Equals");
            Console.WriteLine(bankAccount2.Equals(bankAccount2));
        }
    }
}

