using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Program
    {
        public static int LengthOfLongestSubstring(string s)
        {
            int maxLength = 0;

            for (int i = 0; i < s.Length; i++)
            {
                bool[] seen = new bool[256]; // Boolean array to track characters

                for (int j = i; j < s.Length; j++)
                {
                    if (seen[s[j]]) // If character repeats, break
                        break;

                    seen[s[j]] = true; // Mark character as seen
                    maxLength = Math.Max(maxLength, j - i + 1);
                }
            }

            return maxLength;
        }

        static void Main()
        {
            string input = "abcabcbb";
            int result = LengthOfLongestSubstring(input);
            Console.WriteLine("Length of Longest Substring Without Repeating Characters: " + result);
        }
    }
}
