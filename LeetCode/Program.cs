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
            Solution.LongestDiverseString(1, 1, 7);
        }
    }
    public static class Solution
    {
        public static string generate(int a, int b, int c, char aa, char bb, char cc)
        {
            if (a < b)
                return generate(b, a, c, bb, aa, cc);
            if (b < c)
                return generate(a, c, b, aa, cc, bb);
            if (b == 0)
                return new string(aa, Math.Min(2, a));
            int use_a = Math.Min(2, a), use_b = (a - use_a) >= b ? 1 : 0;
            return new string(aa, use_a) + new string(bb, use_b) +
                generate(a - use_a, b - use_b, c, aa, bb, cc);
        }
        public static string LongestDiverseString(int a, int b, int c)
        {
            return generate(a, b, c, 'a', 'b', 'c');
        }
    }
}
