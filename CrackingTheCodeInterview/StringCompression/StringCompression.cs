using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCompression
{
    public class StringCompressor
    {
        static void Main(string[] args)
        {
        }

        public string Compress(string text)
        {
            if (text == null) return "";
            if (text == "" || text.Length == 1 || text.Length == 2)
                return text;
            char[] chars = text.ToCharArray();
            int currentChar = 0;
            StringBuilder sb = new StringBuilder();
            while(currentChar < text.Length)
            {
                int consecutiveChars = consecutive(chars, chars[currentChar], currentChar);
                sb.Append(consecutiveChars);
                sb.Append(chars[currentChar]);
                currentChar += consecutiveChars;
            }

            if (text.Length <= sb.ToString().Length)
                return text;
            else return sb.ToString();
        }

        private int consecutive(char[] chars, char charac, int current)
        {
            int counter = 0;
            int index = current;
            while (index < chars.Length)
            {
                if (chars[index] == charac)
                {
                    index++;
                    counter++;
                }
                else
                    return counter;
            }
            
            return counter;
        }
    }
}
