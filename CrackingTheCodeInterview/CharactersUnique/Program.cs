using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharactersUnique
{
    class Program
    {
        static void Main(string[] args)
        {

            string a = "abcdefg";
            string b = "abcdabcd";
            string c = "aaaa";
            string d = "a";

            Console.WriteLine(IsCharacterUnique(a));
            Console.WriteLine(IsCharacterUnique(b));
            Console.WriteLine(IsCharacterUnique(c));
            Console.WriteLine(IsCharacterUnique(d));
        }


        public static bool IsCharacterUnique(string text)
        {
            if (text == null || text == "" || text.Length == 1)
                return true;
            for(int i = 0; i < text.Length; i++)
            {
                char charToReplace = text.ElementAt(i);
                string replacedString = text.Replace(charToReplace.ToString(), "");
                if (text.Length - replacedString.Length >= 2)
                    return false;
            }
            return true;
        }
    }
}
