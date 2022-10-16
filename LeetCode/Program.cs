using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public static class Solution
    {
        public static int[][] Insert(int[][] intervals, int[] newInterval)
        {
            List<int[]> processed = new List<int[]>();
            int i = 0;
            while (i < intervals.Length && intervals[i][1] < newInterval[0])
                processed.Add(intervals[i++]);
            while (i < intervals.Length && intervals[i][0] <= newInterval[1])
            {
                newInterval = new int[] { Math.Min(newInterval[0], intervals[i][0]), Math.Max(newInterval[1], intervals[i][1]) };
                i++;
            }
            processed.Add(newInterval);
            while (i < intervals.Length) processed.Add(intervals[i++]);
            return processed.ToArray();
        }
    }
}
