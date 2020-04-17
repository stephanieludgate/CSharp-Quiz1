using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz1
{
    public static class MyExtensions
    {
        public static bool IsDivisibleBy(this int i, int div)
        {
            return i % div == 0;
        }
    }
}
