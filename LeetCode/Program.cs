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
    public class Solution
    {
        public IList<string> GenerateParenthesis(int n)
        {
            List<string> list = new List<string>();
            backtrack(list, "", 0, 0, n);
            return list;
        }
        private void backtrack(List<string> list, string str, int open, int close, int max)
        {
            if (str.Length == max * 2)
            {
                list.Add(str);
                return;
            }
            if (open < max) backtrack(list, str + "(", open + 1, close, max);
            if (close < open) backtrack(list, str + ")", open, close + 1, max);
        }
    }
}
