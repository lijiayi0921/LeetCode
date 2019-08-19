using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }

    public class Solution
    {

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode res = new ListNode(0);
            ListNode current = res;
            ListNode last = res;
            int extra = 0;
            do
            {
                int v1 = l1 != null ? l1.val : 0;
                int v2 = l2 != null ? l2.val : 0;
                int v = v1 + v2 + extra;
                current.val = v % 10;
                extra = (v1 + v2 + extra) / 10;
                last = current;
                current = current.next = new ListNode(0);
                l1 = l1?.next;
                l2 = l2?.next;
            } while (extra > 0 || l1 != null || l2 != null);

            last.next = null;

            return res;
        }
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int c = target - nums[i];
                if (map.ContainsKey(c))
                {
                    return new int[] { map[c], i };
                }
                map[nums[i]] = i;
            }
            return null;
        }
    }
}
