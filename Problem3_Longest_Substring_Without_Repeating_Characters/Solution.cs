using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_Longest_Substring_Without_Repeating_Characters
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            return LengthOfLongestSubstring_SlidingWindowOptimized(s);
        }


        public int LengthOfLongestSubstring_SlidingWindowOptimized(string s)
        {
            // Sliding window
            // RunTime 90%
            int n = s.Length;
            if (n == 0)
                return 0;

            int maxLen = 0;

            Dictionary<char, int> chars = new Dictionary<char, int>();
            for (int i = 0, j = 0; j < n; j++)
            {
                // try to extend the range [i, j]
                char sj = s[j];

                if (chars.ContainsKey(sj))
                {
                    i = Math.Max(chars[sj], i);
                }
                maxLen = Math.Max(maxLen, j - i + 1);
                chars[sj] = j + 1;
            }

            return maxLen;
        }

        public int LengthOfLongestSubstring_SlidingWindow(string s)
        {
            // Sliding window
            // RunTime 68%, Memory 35% (90%-99.7% also with same code)
            int n = s.Length;
            if (n == 0)
                return 0;

            int i = 0, j = 0;

            int maxLen = 0;

            HashSet<char> chars = new HashSet<char>();
            while (i < n && j < n)
            {
                // try to extend the range [i, j]
                if (chars.Contains(s[j]))
                {
                    chars.Remove(s[i++]);
                }
                else
                {
                    chars.Add(s[j++]);
                    maxLen = Math.Max(maxLen, j - i);
                }
            }

            return maxLen;
        }

        public int LengthOfLongestSubstring_BruteForce(string s)
        {
            // RunTime 29%, Memory 32%
            if (s == null || s.Length == 0)
                return 0;

            int maxLen = 0;

            HashSet<char> chars = new HashSet<char>();
            for (int i = 0; i < s.Length; i++)
            {
                chars.Clear();
                int len = 0;

                for (int j = i; j < s.Length; j++)
                {
                    if (chars.Contains(s[j]))
                        break;
                    chars.Add(s[j]);
                    len++;
                }

                if (len > maxLen)
                    maxLen = len;
                if (s.Length - i < maxLen)
                    break;
            }

            return maxLen;
        }
    }
}
