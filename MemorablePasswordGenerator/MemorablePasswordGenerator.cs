using System;
using System.IO;
using System.Linq;

namespace MemorablePasswordGenerator
{
    internal class MemorablePasswordGenerator
    {
        private static int getLineCount(string wordlist_Filepath) => File.ReadLines(wordlist_Filepath).Count();

        public static string GenerateWords(string wordlist_Filepath, int wordcount)
        {
            Random rnd = new Random();
            int numLines = getLineCount(wordlist_Filepath);
            string pw = "";
            for (int i = 0; i < wordcount; i++)
            {
                pw += " " + File.ReadLines(wordlist_Filepath).Skip(rnd.Next(numLines - 1)).Take(1).First();
            }
            return pw;
        }  
    }
}