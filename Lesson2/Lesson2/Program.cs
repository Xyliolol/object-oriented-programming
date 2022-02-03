using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    { 
        static string StringReverse(string vvod)
        { 
            char[] vvodReverse = vvod.ToCharArray();
            Array.Reverse(vvodReverse);
            return new string(vvodReverse);
            
        }
        static void Main(string[] args)
        { 
            Console.WriteLine("Введите любой текст");
            string vvod = Console.ReadLine();
            vvod = StringReverse(vvod);
            Console.WriteLine(vvod);
        }
       
    }
   
}
