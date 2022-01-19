using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


            List<BankAccount> NumberList = new();
            NumberList.Add(bankAccount);
            NumberList.Add(bankAccount1);
            NumberList.Add(bankAccount2);

            bool no_account = true;
            bool _isTake = true;

            Console.WriteLine("Введите номер счета");
            int vvodAcc = int.Parse(Console.ReadLine());
            decimal vvodSum = 0;
            int vvodAccTo = 0;

            switch (vvodAcc)
            {
                case 1:
                    {
                        Console.WriteLine("Выбран счет №1");
                        Console.WriteLine("Выберете счёт с которого будут переведены деньги:");
                        try
                        {

                            vvodAcc = int.Parse(Console.ReadLine());
                            foreach (var item in NumberList)
                            {
                                if (item.Number == vvodAcc)
                                {
                                    no_account = false;
                                    break;
                                }
                            }
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("Не корректный номер счёта");
                        }
                        Console.WriteLine("Выберите сумму,которую хотите списать со счета");
                        try
                        {
                            vvodSum = decimal.Parse(Console.ReadLine());
                            _isTake = false;
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("Нельзя списать такое колличество");
                        }
                         bankAccount.Transfer(NumberList[vvodAcc - 1], vvodSum);
                        break;
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Выбран счет №2");
                        Console.WriteLine("Выберете счёт с которого будут переведены деньги:");
                        try
                        {

                            vvodAcc = int.Parse(Console.ReadLine());
                            foreach (var item in NumberList)
                            {
                                if (item.Number == vvodAcc)
                                {
                                    no_account = false;
                                    break;
                                }
                            }
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("Не корректный номер счёта");
                        }
                        Console.WriteLine("Выберите сумму,которую хотите списать со счета");
                        try
                        {
                            vvodSum = decimal.Parse(Console.ReadLine());
                            _isTake = false;
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("Нельзя списать такое колличество");
                        }
                        bankAccount1.Transfer(NumberList[vvodAcc - 1], vvodSum);
                        break;
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Выбран счет №3");
                        Console.WriteLine("Выберете счёт с которого будут переведены деньги:");
                        try
                        {

                            vvodAcc = int.Parse(Console.ReadLine());
                            foreach (var item in NumberList)
                            {
                                if (item.Number == vvodAcc)
                                {
                                    no_account = false;
                                    break;
                                }
                            }
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("Не корректный номер счёта");
                        }
                        Console.WriteLine("Выберите сумму,которую хотите списать со счета");
                        try
                        {
                            vvodSum = decimal.Parse(Console.ReadLine());
                            _isTake = false;
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("Нельзя списать такое колличество");
                        }
                        bankAccount2.Transfer(NumberList[vvodAcc - 1], vvodSum);
                        break;
                    }
                    break;

                default:
                    break;

            }

        }
    }
    
}
