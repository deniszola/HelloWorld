using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("I am deniszola");
            Console.WriteLine("I am Learning C#");
            Console.WriteLine("It is awesome!\n");

            string text = "3 + 3 = ";
            int num = 3 + 3;
            bool myBool = true;
            if (myBool)
            {
                Console.WriteLine(text + num);
            }
            else
            {
                Console.WriteLine("myBool is false");
            }
        }
    }
}