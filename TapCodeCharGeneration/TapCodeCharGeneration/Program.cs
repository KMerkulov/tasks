    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

namespace TapCodeCharGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            // Just a text
            Console.WriteLine("Character statistics: " + "\n");
            /*
             String book is reading text from book.txt. Made it as all characthers with little symbols, because we use ToLower. 
              Also, if you remove that last function, then it will be with a huge text, if needed of course.. */
            string book = File.ReadAllText("book.txt").ToLower();

            // Forbidden symbols, what we don,t need to use in our program..
            char[] forbiddenChars = { '#', '!', '?', ';', ':', '[', ']', '(', ')', '<', '>',
                                       '*', '.', '\"', '\n', '\t', '\r', '0', '1', '2', '3', '4',
                                       '5', '6', '7', '8', '9', ' ','-','\'' };

            // We are creating new dictionary and we use sorted dictionary, to sort symbols.
            SortedDictionary<char, int> dict = new SortedDictionary<char, int>();
            // Used to iterate through the collection to get the information we need 
            foreach (char c in book)
            {
                //condition with if.. char (c) and statement in conjunction
                if (forbiddenChars.Contains(c)) continue;
                // increment by 1 for containtskey
                if (dict.ContainsKey(c)) dict[c]++;
                // else, add c, 1
                else dict.Add(c, 1);
            }

            // define a key that can retrieved.
            foreach (KeyValuePair<char, int> kvp in dict)
            {
                // write keyvaluepair KEY + - and a value keyvaluepair VALUE
                Console.WriteLine(kvp.Key + " - " + kvp.Value);
            }
            // char s to key and to array.
            char[] chars = dict.Select(s => s.Key).ToArray();
            // int name row and equal to 1
            int row = 1;
            // Just a text and next line free..
            Console.WriteLine("Suggested tap code table:" + "\n");
            // Text for our suggested tap code table.
            Console.WriteLine("___|_1_|_2_|_3_|_4_|_5_");
            // for int i what equals to 0 , if chars length is more than i -5
            for (int i = 0; i < chars.Length; i += 5)
            {
                // text for the left side of our table and our results..
                Console.WriteLine("_{0}_|_{1}_|_{2}_|_{3}_|_{4}_|_{5}_",
                    row++, chars[i], chars[i + 1], chars[i + 2], chars[i + 3], chars[i + 4]);
            }
            // For window not to disapear in the first seconds and watch results.
            Console.ReadKey();
        }
    }
}
    