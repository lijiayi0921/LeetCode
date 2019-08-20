using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_Add_Two_Numbers
{
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
            int extra = 0;
            while (l1 != null || l2 != null)
            {
                int v1 = l1 != null ? l1.val : 0;
                int v2 = l2 != null ? l2.val : 0;
                int v = v1 + v2 + extra;
                extra = (v1 + v2 + extra) / 10;
                current = current.next = new ListNode(v % 10);
                l1 = l1?.next;
                l2 = l2?.next;
            }

            if (extra > 0)
                current.next = new ListNode(extra);

            return res.next;
        }
    }
}
