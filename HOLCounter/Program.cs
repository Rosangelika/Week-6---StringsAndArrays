using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2video iseseisev töö - - - - tehtud
            //programm kuvab konsoolis, mitu 'h', 'o', ja 'l' tähte on lauses "Hello, World!"

            Console.WriteLine("Hello, World!");
         
            string HelloWorld = "Hello, World!".ToLower();

            
            
            int aCounter = 0;
            int bCounter = 0;
            int cCounter = 0;

            for (int i = 0; i < HelloWorld.Length; i++)
            {
                if (HelloWorld[i] == 'h')
                {
                    aCounter++;
                }
                if (HelloWorld[i] == 'o')
                {
                    bCounter++;
                }
                if (HelloWorld[i] == 'l')
                {
                    cCounter++;
                }

            }

            if (aCounter != 0)
            {
                Console.WriteLine($"Hello World on {aCounter} 'h' tähte.");
            }
            if (bCounter != 0)
            {
                Console.WriteLine($"Hello World on {bCounter} 'o' tähte.");
            }
            if (cCounter != 0)
            {
                Console.WriteLine($"Hello World on {cCounter} 'l' tähte.");
            }



        }
    }
}
