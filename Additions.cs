using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppGenerics
{
    class Additions<T>
    {
        public void Addition(T data)
        {
            if (data.GetType()==typeof(string))
            {
                Console.WriteLine("The addition is:"+data);
            }
            else if(data.GetType()==typeof(int))
            {
                Console.WriteLine("The addition is:"+data.ToString());
            }
            else
            {
                Console.WriteLine("Not suported");
            }
        }
    }
}
