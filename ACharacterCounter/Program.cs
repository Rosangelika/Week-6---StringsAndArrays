using System;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 video õpe
            //programm küsib kasutajal sisestada ees- ja perekonnime
            //programm kuvab, mitu 'a'tähte on kasutaja ees- ja perekonnanimes

            Console.WriteLine("Sisesta eesnimi:");
            string fistName = Console.ReadLine();
            Console.WriteLine("Sisesta perekonnanimi:");
            string lastName = Console.ReadLine();

            string fullName = $"{fistName}{lastName}".ToLower();

            Console.WriteLine(fullName);

            int aCounter = 0;

            for (int i = 0; i < fullName.Length; i++)
            {
                if (fullName [i] == 'a')
                {
                    aCounter++;
                }
 
            }

            if (aCounter != 1)
            {
                Console.WriteLine($"Sinu täisnimes on {aCounter} 'a' tähte.");
            }
            else
            {
                Console.WriteLine($"Sinu täisnimes on {aCounter} 'a' täht.");
            }
        }
    }
}
