using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 osa iseseisev töö -----valmis
            //programm küsib kasutajal sisestada ees- ja perekonnanime
            //programm kontrollib andmete pikkust
            //programm kuvab kumb nendes on pikem, kas ees- või perekonnanimi

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta perekonnanimi:");
            string lastName = Console.ReadLine();

            int firstNameLength = firstName.Length;
            int lastNameLength = lastName.Length;

            
            Console.WriteLine($"Sinu eesnimes on {firstNameLength} ja perekonnanimes on {lastNameLength} tähte.");

            if (firstNameLength > lastNameLength)
            {
                Console.WriteLine($"Eesnimi on {firstNameLength- lastNameLength} tähte pikem perekonnanimest.");
            }
            else if (lastNameLength > firstNameLength)
            {
                Console.WriteLine($"Perekonnanimi on {lastNameLength - firstNameLength} tähte pikem eesnimest.");

            }
            else
            {
                Console.WriteLine("Ees ja perekonnanimes on sama palju tähti.");
            }

            
        }
    }
}
