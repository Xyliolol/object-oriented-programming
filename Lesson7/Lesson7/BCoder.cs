using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class BCoder : ICoder
    {
        private static readonly int[] LowerCaseRange = { 'a', 'z' };
        private static readonly int[] UpperCaseRange = { 'A', 'Z' };

        private static bool IsLowerCase(char symbol) => symbol >= LowerCaseRange[0] && symbol <= LowerCaseRange[1];

        private static bool IsUpperCase(char symbol) => symbol >= UpperCaseRange[0] && symbol <= UpperCaseRange[1];


        public string Encode(string toEncode)
        {
            var data = toEncode.AsSpan();
            var symb = new StringBuilder(toEncode.Length);

            foreach (var symbol in data)
            {
                if (IsLowerCase(symbol))
                {
                    var rangeFromStart = symbol - LowerCaseRange[0];
                    if (rangeFromStart == 0)
                    {
                        symb.Append((char)LowerCaseRange[1]);
                        continue;
                    }
                    symb.Append((char)(LowerCaseRange[1] - rangeFromStart));
                    continue;
                }


                if (IsUpperCase(symbol))
                {
                    var rangeFromStart = symbol - UpperCaseRange[0];
                    if (rangeFromStart == 0)
                    {
                        symb.Append((char)UpperCaseRange[1]);
                        continue;
                    }
                    symb.Append((char)(UpperCaseRange[1] - rangeFromStart));
                }
            }

            return symb.ToString();
        }


        public string Decode(string toDecode)
        {
            var data = toDecode.AsSpan();
            var symb = new StringBuilder(toDecode.Length);

            foreach (var symbol in data)
            {
                if (IsLowerCase(symbol))
                {
                    var rangeFromEnd = LowerCaseRange[1] - symbol;
                    if (rangeFromEnd == 0)
                    {
                        symb.Append((char)LowerCaseRange[0]);
                        continue;
                    }
                    symb.Append((char)(LowerCaseRange[0] + rangeFromEnd));
                    continue;
                }

                if (IsUpperCase(symbol))
                {
                    var rangeFromEnd = UpperCaseRange[1] - symbol;
                    if (rangeFromEnd == 0)
                    {
                        symb.Append((char)UpperCaseRange[0]);
                        continue;
                    }
                    symb.Append((char)(UpperCaseRange[0] + rangeFromEnd));
                }
            }
            return symb.ToString();
        }
    }
}
