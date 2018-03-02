using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TapTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert full path to the file:");
            string path = Console.ReadLine();
            string ignore = "#!?;:[]()<>*'. \"\n\t\r0123456789-";
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char c in File.ReadAllText(path))
            {
                char letter = Char.ToLower(c);
                if (!ignore.Contains(letter))
                {
                    if (!dict.ContainsKey(letter))
                    {
                        dict.Add(letter, 1);
                    }
                    else
                    {
                        dict[letter] += 1;
                    }
                }
            }
            Console.WriteLine("\r\nCharacter statistics:\r\n");
            var records = from r in dict orderby r.Value descending select r;
            var list = new List<char>();
            foreach (KeyValuePair<char, int> kvp in records)
            {
                Console.WriteLine(kvp.Key + " - " + kvp.Value);
                list.Add(kvp.Key);
            }
            Console.WriteLine("\r\nSuggested tap code table:\r\n");
            Console.WriteLine("___|_1_|_2_|_3_|_4_|_5_"); int i = 0;
            for (int row = 1; row <= 5; row++)
            {
                Console.Write("_" + row + "_");
                for (int column = 1; column <= 5; column++)
                {
                    Console.Write("| " + list[i] + " ");i++;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}