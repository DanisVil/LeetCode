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
            Solution.TriangleNumber(new int[] { 2, 2, 3, 4});
        }
    }
    public static class Solution
    {
        public static int TriangleNumber(int[] nums)
        {
            Array.Sort(nums);
            int count = 0, n = nums.Length;
            for (int i = n - 1; i >= 2; i--)
            {
                int l = 0, r = i - 1;
                while (l < r)
                {
                    if (nums[l] + nums[r] > nums[i])
                    {
                        count += r - l;
                        r--;
                    }
                    else l++;
                }
            }
            return count;
        }
    }
}
