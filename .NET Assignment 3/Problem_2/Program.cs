using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    public class Interval
    {
        public int Start { get; set; }
        public int End { get; set; }

        public Interval(int start, int end)
        {
            this.Start = start;
            this.End = end;
        }

        public override string ToString()
        {
            return "[" + Start + "," + End + "]";
        }
    }

    class Program
    {
        public static List<Interval> MergeIntervals(List<Interval> intervals)
        {
            if (intervals == null || intervals.Count == 0)
                return new List<Interval>();

            
            intervals.Sort((a, b) => a.Start.CompareTo(b.Start));

            List<Interval> merged = new List<Interval>();
            Interval prev = intervals[0];

            
            foreach (var current in intervals)
            {
                if (current.Start <= prev.End)
                {
                    prev.End = Math.Max(prev.End, current.End);
                }
                else
                {
                    merged.Add(prev);
                    prev = current;
                }
            }
            merged.Add(prev); 

            return merged;
        }

        static void Main()
        {
            List<Interval> intervals = new List<Interval>
        {
            new Interval(1, 3),
            new Interval(2, 6),
            new Interval(8, 10),
            new Interval(15, 18)
        };

            List<Interval> result = MergeIntervals(intervals);

            Console.WriteLine(string.Join(", ", result));
        }
    }

}
