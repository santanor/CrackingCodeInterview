using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "abcd";
            string b = "cdba";
            string c = "";
            string d = "a";

            Console.WriteLine(IsPermutation(a,b));
            Console.WriteLine(IsPermutation(a, a));
            Console.WriteLine(IsPermutation(a, c));
            Console.WriteLine(IsPermutation(c, c));
            Console.WriteLine(IsPermutation(c, d));
            Console.WriteLine(IsPermutation(d, d));


        }

        public static bool IsPermutation(string first, string second)
        {
            if ((first.Length != second.Length) || first.Length == 0)
                return false;

            char[] letters = first.ToCharArray();
            foreach (var charac in letters)
                second = second.Replace(charac.ToString(), "");

            if (second == "")
                return true;
            else
                return false;
        }
    }
}
