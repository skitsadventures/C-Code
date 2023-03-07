using System;

namespace PRGYOURNAMEFA1
{
    class Program
    {
        class WordReplace
        {
            public int FindSubstring(string Word, string Substring)
            {
                int SubStringSize = Substring.Length;
                int WordSize = Word.Length;

                if (WordSize == 0 || SubStringSize > WordSize)
                {
                    return 0;
                }

                if (Word.Substring(0, SubStringSize).Equals(Substring))
                {
                    return FindSubstring(Word.Substring(SubStringSize - 1), Substring) + 1;
                }
                return FindSubstring(Word.Substring(SubStringSize - 1), Substring);
            }

            public void ReplaceSubstring(ref string Word, string Substring, string charReplace)
            {
                if (Word.Contains(Substring))
                {
                    Word = Word.Replace(Substring, charReplace);
                    ReplaceSubstring(ref Word, Substring, charReplace);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string: ");
            string Word = Console.ReadLine();
            Console.WriteLine("Please enter the substring you wish to find: ");
            string Substring = Console.ReadLine();
            Console.WriteLine("Please enter a string to replace the given substring: ");
            string charReplace = Console.ReadLine();
            

            WordReplace SearchReplace = new WordReplace();
            int n = SearchReplace.FindSubstring(Word, Substring);
            if (n > 0)
            {
                Console.WriteLine("Your new string is: ");
                SearchReplace.ReplaceSubstring(ref Word, Substring, charReplace);
                Console.WriteLine(Word);
            }
            else
            {
                Console.WriteLine("\nSubstring does not exist.");
            }

            Console.ReadLine();
        }
    }
}