using System;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            //4video õpe
            //programm asendab kõik 'o' tähed lauses "Hello World!" tänriga (*)

            string helloW = "Hello World!";

            /*for (int i = O; i < helloW.Length; i++)
            {
                helloW[i] = '*'; //sõned on muutumatu
            }*/

            helloW = helloW.Replace('o', '*');
            helloW = helloW.Replace('!','1');
            Console.WriteLine(helloW);
        }
    }
}
