using System;

namespace inluppg7_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många koder vill du skriva?");
            int antalKoder = int.Parse(Console.ReadLine());

            //Genererar dict
            Dictionary<char, char> map = new Dictionary<char, char>();
            for (int i = 0;i < antalKoder; i++)
            {
                string nyKod = Console.ReadLine();
                map[nyKod[0]] = nyKod[2];
            }

            Console.WriteLine("Skriv in ditt hemliga meddelande");
            string meddelande = Console.ReadLine();
            char[] avkodatMeddelande = new char[meddelande.Length];

            for (int i = 0; i < meddelande.Length; i++)
            {
                char tempChar = meddelande[i];
                char kodadChar = meddelande[i];

                while (map.ContainsKey(tempChar))
                {
                    tempChar = map[tempChar];
                }
                avkodatMeddelande[i] = tempChar;
            }

            Console.WriteLine("Här är ditt avkodade meddelande");
            foreach (char c in avkodatMeddelande)
            {
                Console.Write(c);
            }
        }
    }
}