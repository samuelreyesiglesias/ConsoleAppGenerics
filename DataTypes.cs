using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppGenerics
{
    class DataTypes<T>
    {
        public static void ShowType(T Parameter)
        {
            Console.WriteLine("The type of data of this generic class is:" + Parameter.GetType().ToString());
        }
    }
}
