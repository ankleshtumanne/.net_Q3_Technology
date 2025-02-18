using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8
{
    class Program
    {
        public static List<int> TopKFrequent(int[] nums, int k)
        {
            
            Dictionary<int, int> freqMap = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (!freqMap.ContainsKey(num))
                    freqMap[num] = 0;
                freqMap[num]++;
            }

            
            return freqMap.OrderByDescending(x => x.Value)
                          .Take(k)
                          .Select(x => x.Key)
                          .ToList();
        }

        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 1, 2, 2, 3 };
            int k = 2;

            List<int> result = TopKFrequent(nums, k);
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
