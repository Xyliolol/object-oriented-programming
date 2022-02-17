using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    interface ICoder
    {
        string Encode(string toEncode);
        string Decode(string toDecode);
    }
}
