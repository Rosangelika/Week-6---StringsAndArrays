using System;

namespace HelloWorldReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            //3 video iseseisev töö - - - - valmis
            //programm kuvab lauset "Hello, World!" tagurpidi

            Console.WriteLine("Hello, World!");
            string HelloWorld = "Hello, World!";

            for(int i = HelloWorld.Length - 1; i >= 0; i--)
            {
                Console.Write (HelloWorld[i]);
            }

        }
    }
}
