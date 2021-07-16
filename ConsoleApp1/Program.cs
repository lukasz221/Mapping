using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program 
    {
        public static char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        public static List<NuberWithLetter> ListOfNuberWithLetter = new List<NuberWithLetter>();
        public static string theNumber = "111";


        static void Main(string[] args)
        {
            LinkletterToNumber();
            SearchingSingleNumbers();
            Console.ReadKey();
        }

        public static void LinkletterToNumber()
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                ListOfNuberWithLetter.Add(new NuberWithLetter() { letters = alphabet[i], number = i + 1 });
            }
        }

        public static void SearchingSingleNumbers()
        {
            string[] digits = theNumber.Select(c => c.ToString()).ToArray();

            for (int i = 0; i < digits.Length; i++)
            {
                foreach (var l in ListOfNuberWithLetter)
                {
                    if (digits[i] == l.number.ToString())
                    {
                        Console.Write(l.letters);
                    }
                }
            }
        }
    }

    class NuberWithLetter
    {
        public char letters { get; set; }
        public int number { get; set; }
    }
}
