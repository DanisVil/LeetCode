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
        public static int MinimumDeletions(string s)
        {
            int n = s.Length;
            int[] a = new int[n], b = new int[n];
            int c = 0;
            for (int i = 0; i < n; i++)
            {
                b[i] = c;
                if (s[i] == 'b') c++;
            }
            c = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                a[i] = c;
                if (s[i] == 'a') c++;
            }
            int ans = n;
            for (int i = 0; i < n; i++) ans = Math.Min(ans, a[i] + b[i]);
            return ans;
        }
    }
}
