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
        public static IList<int> LargestDivisibleSubset(int[] nums)
        {
            int[] l = new int[nums.Length];
            int[] prev = new int[nums.Length]; // the previous index of element i in the largestDivisibleSubset ends with element i

            Array.Sort(nums);

            int max = 0;
            int index = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                l[i] = 1;
                prev[i] = -1;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (nums[i] % nums[j] == 0 && l[j] + 1 > l[i]) //почему не break? потому что могут попасться число может делиться и на другие числа
                    {
                        l[i] = l[j] + 1;
                        prev[i] = j;
                    }
                }
                if (l[i] > max)
                {
                    max = l[i];
                    index = i;
                }
            }
            List<int> res = new List<int>();
            while (index != -1)
            {
                res.Add(nums[index]);
                index = prev[index];
            }
            return res;
        }
    }
}
