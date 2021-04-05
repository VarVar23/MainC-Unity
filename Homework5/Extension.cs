using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    static class Extension
    {
        public static int CountChar(this string str)
        {
            return str.Length;
        }
    }
}
