using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz1
{
    class MyGenericClass<T> where T: class
    {
        public static void Print(T val)
        {
            Console.WriteLine(val);
        }
    }
}
