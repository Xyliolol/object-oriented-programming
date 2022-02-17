using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class ACoder : ICoder
    {
       
        public string Encode(string toEncode)
        {
            var data = toEncode.AsSpan(); 
            var sb = new StringBuilder(toEncode.Length); 
            foreach (var symbol in data)
            {
                sb.Append((char)(symbol + 1));
            }

            return sb.ToString();
        }     
        public string Decode(string toDecode)
        {
            var data = toDecode.AsSpan();
            var sb = new StringBuilder(toDecode.Length);
            foreach (var symbol in data)
            {
                sb.Append((char)(symbol));
            }

            return sb.ToString();
        }
    }
}
