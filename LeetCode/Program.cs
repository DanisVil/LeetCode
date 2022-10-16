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
            int[][] points = new int[][] { new int[] { 8, 7 }, new int[] { 9, 9 }, new int[] { 7, 4 }, new int[] { 9, 7 }, new int[] { -3, 7 }, new int[] { 2, 7 } };
            Solution.MaxWidthOfVerticalArea(points);
            Console.ReadKey();
        }
    }
    public static class Solution
    {
        public static int MaxWidthOfVerticalArea(int[][] points)
        {
            IComparer<int[]> myComparer = new MyComparer();
            Array.Sort(points, myComparer);
            int maxWidth = 0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                if (points[i + 1][0] - points[i][0] > maxWidth) maxWidth = points[i + 1][0] - points[i][0];
            }
            return maxWidth;
        }
    }
    public class MyComparer : IComparer<int[]>
    {
        int IComparer<int[]>.Compare(int[] p1, int[] p2)
        {
            return p1[0] - p2[0];
        }
    }
}
