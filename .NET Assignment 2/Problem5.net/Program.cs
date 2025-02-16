using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5.net
{
    class Program
    {
        public static int MajorityElement(int[] arr)
        {
            Dictionary<int, int> Items = new Dictionary<int, int>();
            int n = arr.Length;
            foreach(int c in arr)
            {
                if (Items.ContainsKey(c))
                    Items[c]++;
                else
                    Items[c] = 1;
            }

            foreach (var k in Items)
            {
                if (k.Value > n / 2)
                    
                    return k.Key;
            }

            return -1;
        }
        static void Main(string[] args)
        {
            int[] arr = { 3, 3, 4, 2, 3, 3, 3, 1 };
            Console.WriteLine(MajorityElement(arr));
        }
    }
}
