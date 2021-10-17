using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //!!!!!!!5 video iseseisev - valmis!!!!!!!
            //programm ennustab, mis juhtub kasutajaga homme (kasutame Ranom klassi)

            string[] prediction = { "win a millon", "fall in love", "buy youtube premium", "join the darkside for cookies" };

            Random rnd = new Random();
            int userNumber = rnd.Next(0, prediction.Length);

            Console.WriteLine($"Today you will have {prediction[userNumber]}.");
        }
    }
}
