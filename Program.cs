using System;

namespace ConsoleAppGenerics
{
    class Program
    {
        static void Main(string[] args)
        {

            //This is the first example of a generic class, DataTypes is our generic class that receives any type of data in the static
            //ShowType method.
            DataTypes<int>.ShowType(2);
            DataTypes<string>.ShowType("Hello World");
            DataTypes<double>.ShowType(3.4);

            //here we have examples of generic class called addition that receives one parameter
            Additions<string> MyStringData = new Additions<string>();
            MyStringData.Addition("Hello World example 2 using Generics");


            //here i will show a message in the void method , using the console.write line , that will,
            //print the number that i add to the method of the class.
            Additions<int> MyIntegerData = new Additions<int>();
            MyIntegerData.Addition(24);


            //here i sent a wrong example using boolean data type, that will show not supported by the method in the class
            Additions<bool> MyWorstExampleUsingBoolean = new Additions<bool>();
            MyWorstExampleUsingBoolean.Addition(false);

        }
    }
}
