using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //!!!!!4 video iseseisev  - - -- tehtud 
            //programm asendab kõik 'o' töhed lauses "Don't Panic" nulliga - 0
            //programm asendab kõik 'a' tähed samas lauses number - 4-ga


            string DP  = "Don't Panic";


            DP = DP.Replace('o', '0');
            DP= DP.Replace('a', '4');
            Console.WriteLine(DP);
        }
    }
}
