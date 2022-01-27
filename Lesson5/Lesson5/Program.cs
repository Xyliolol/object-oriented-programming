using System;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var RationalNumber1 = new Rational(10,15);
            var RationalNumber2 = new Rational(11, 30);
            Console.WriteLine("сложение дробей");
            Console.WriteLine(RationalNumber1+RationalNumber2);
            Console.WriteLine("вычитание дробей");
            Console.WriteLine(RationalNumber1 - RationalNumber2);
            Console.WriteLine("умножение дробей");
            Console.WriteLine(RationalNumber1 * RationalNumber2);
            Console.WriteLine("деление дробей");
            Console.WriteLine(RationalNumber1 / RationalNumber2);
            Console.WriteLine("проверка на больше");
            Console.WriteLine(RationalNumber1 > RationalNumber2);
            Console.WriteLine("проверка на меньше");
            Console.WriteLine(RationalNumber1 < RationalNumber2);
            Console.WriteLine("проверка на больше или равно");
            Console.WriteLine(RationalNumber1>= RationalNumber2);
            Console.WriteLine("проверка на меньше или равно");
            Console.WriteLine(RationalNumber1 <= RationalNumber2);
            Console.WriteLine("инкремент");
            Console.WriteLine(RationalNumber1++);
            Console.WriteLine("декримент");
            Console.WriteLine(RationalNumber1--);
            Console.WriteLine("перевод в вещественный тип");
            Console.WriteLine((float)RationalNumber1);
            Console.WriteLine("перевод в целый тип");
            Console.WriteLine((int)RationalNumber1);
            Console.WriteLine("деление без остатка");
            Console.WriteLine(RationalNumber1 % RationalNumber2);
            Console.WriteLine("проверка на равенство");
            Console.WriteLine(RationalNumber1 == RationalNumber2);
            Console.WriteLine("проверка на не равенство");
            Console.WriteLine(RationalNumber1 != RationalNumber2);
            Console.WriteLine("перевод в строковый тип");
            Console.WriteLine(RationalNumber1.ToString());
        }
    }
}
