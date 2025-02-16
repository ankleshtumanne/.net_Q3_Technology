using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4.net
{
    class Program
    {
        public static char FirstUniqueChar(string str)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (char c in str)
            {
                if (charCount.ContainsKey(c)) 
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }

            foreach (char c in str)
            {
                if (charCount[c] == 1)
                    return c;
            }

            return '\0';
        }
        static void Main(string[] args)
        {
            string str = "swiss";
            Console.WriteLine(FirstUniqueChar(str));
        }
    }
}
