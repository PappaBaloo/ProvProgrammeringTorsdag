using System;
using System.Collections.Generic;

namespace Prov
{
    class Program
    {
        static void Main(string[] args)
        {

            Random föremålvikt = new Random();

            List<string> föremål = new List<string>() { "Limpa", "Kexchoklad", "Monster", "Proteindrycka", "Brunsås" };

            List<int> vikt = new List<int>();

            for (int i = 0; i < föremål.Count; i++)
            {

                vikt.Add(föremålvikt.Next(1, 101));

                Console.WriteLine("" + föremål[i] + ": " + vikt[i] + "");

            }

            Console.WriteLine("Skriv in hur mycket vikt du kan ta: ");

            string möjligvikt = Console.ReadLine();

            try
            {
                int.Parse(möjligvikt);
            }
            catch
            {
                Console.WriteLine("Skriv in ett positivt tal tack!");
            }

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
