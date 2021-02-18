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



            Console.ReadLine();
        }
    }
}
