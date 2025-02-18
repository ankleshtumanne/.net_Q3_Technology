using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5
{
    class Program
    {
        public static bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0) return false; // No matching opening bracket

                char top = stack.Pop();
                
                if ((c == ')' && top != '(') ||
                    (c == '}' && top != '{') ||
                    (c == ']' && top != '['))
                {
                    return false; // Mismatched brackets
                }
            }
        }

        return stack.Count == 0; // If stack is empty, brackets are balanced
    }
        static void Main(string[] args)
        {
            string input = "()[]{}";
            Console.WriteLine(IsValid(input)); // Output: true

            //input = "(]";
            //Console.WriteLine(IsValid(input)); // Output: false

            //input = "({[]})";
            //Console.WriteLine(IsValid(input));
        }
    }
}
