using System;

namespace MemorablePasswordGenerator
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Console.Write("What is the name of the wordlist you want to use? (ex. wordlist.txt)" +
                "\n>");
            string listname = Console.ReadLine();

            if (!System.IO.File.Exists(listname))
            {
                Console.WriteLine("I can not find the given file, please try again. :(\n");
                Main(null);
            }

            Console.WriteLine("\nThank you, I found it! :)");

            int wordcount = getWordcount_FromUser();

            Console.WriteLine("This could take a while, please wait...");
            Console.WriteLine(MemorablePasswordGenerator.GenerateWords(listname, wordcount));
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }



        private static int getWordcount_FromUser() {
            Console.Write("\nSo what's the number of words you want to generate?" +
                "\n>");
            int wordcount = 1;
            try
            {
                wordcount = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("That hasn't been a number ;), pls try again");
                return getWordcount_FromUser();
            }

            return wordcount;
        }


    }
}