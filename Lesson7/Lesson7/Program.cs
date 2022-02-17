using System;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            ICoder aCoder = new ACoder();
            ICoder bCoder = new BCoder();

            const string toEncodeUpperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string toEncodeLowerCase = "abcdefghijklmnopqrstuvwxyz";


            var encodedWithACoderUpperCase = aCoder.Encode(toEncodeUpperCase);
            var encodedWithACoderLowerCase = aCoder.Encode(toEncodeLowerCase);



            Console.WriteLine("Alphabet: " + toEncodeUpperCase);

            Console.WriteLine();

            Console.WriteLine("A Coder");
            Console.WriteLine("EncodedUpperCase: " + encodedWithACoderUpperCase);
            Console.WriteLine("EncodedLowerCase: " + encodedWithACoderLowerCase);

            Console.WriteLine();

            Console.WriteLine("DecodedUpperCase: " + toEncodeUpperCase);
            Console.WriteLine("DecodedLowerCase: " + toEncodeLowerCase);


            var encodedWithBCoderUpperCase = bCoder.Encode(toEncodeUpperCase);
            var encodedWithBCoderLowerCase = bCoder.Encode(toEncodeLowerCase);


            Console.WriteLine();

            Console.WriteLine("B Coder");
            Console.WriteLine("EncodedUpperCase: " + encodedWithBCoderUpperCase);
            Console.WriteLine("EncodedLowerCase: " + encodedWithBCoderLowerCase);

            Console.WriteLine();

            Console.WriteLine("DecodedUpperCase: " + toEncodeUpperCase);
            Console.WriteLine("DecodedLowerCase: " + toEncodeLowerCase);
        }
    }
}
