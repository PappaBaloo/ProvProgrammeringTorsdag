using System;
using System.Collections.Generic;

namespace Prov
{
    class Program
    {
        static void Main(string[] args)
        {
            TheMethod();
        }

        private static void TheMethod()
        {
            //Deklarerar alla variabler som är nödvändiga
            Random föremålvikt = new Random();

            List<string> föremål = new List<string>() { "Limpa", "Kexchoklad", "Monster", "Proteindrycka", "Brunsås" };

            List<int> vikt = new List<int>();

            //For-loop som visar alla föremål och deras vikter
            for (int i = 0; i < föremål.Count; i++)
            {

                vikt.Add(föremålvikt.Next(1, 101));

                Console.WriteLine("" + föremål[i] + ": " + vikt[i] + "");

            }

            Console.WriteLine("Skriv in hur mycket vikt du kan ta: ");

            string möjligvikt = Console.ReadLine();


            //stänger programmet om du inte skriver in en siffra

            try
            {
                int.Parse(möjligvikt);
            }
            catch
            {
                Console.WriteLine("Skriv in ett positivt tal tack!");
                Console.ReadLine();
            }




            //For-loop som skriver ut endast de förmål som användaren kan lyfta
            for (int i = 0; i < föremål.Count; i++)
            {

                int fungerandevikt = vikt[i];

                if (fungerandevikt < Convert.ToInt32(möjligvikt) || fungerandevikt == Convert.ToInt32(möjligvikt))
                {
                    Console.WriteLine("" + föremål[i] + ": " + vikt[i] + "");
                }


            }

            Console.ReadLine();
        }
    }
}
