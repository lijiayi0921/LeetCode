using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_Add_Two_Numbers
{
    class Program
    {
        static Solution solution = new Solution();
        static void Main(string[] args)
        {
            Test(new List<int>() { 2, 4, 3 }, new List<int>() { 5, 6, 4 }, new List<int>() { 7, 0, 8 });
            Test(new List<int>() { 0 }, new List<int>() { 0 }, new List<int>() {0 });
            Test(new List<int>() { 5 }, new List<int>() { 5 }, new List<int>() { 0, 1 });
            Test(new List<int>() { 1 }, new List<int>() { 9, 9 }, new List<int>() { 0, 0, 1 });
            Console.ReadKey();
            
        }

        static bool Test(List<int> L1, List<int> L2, List<int> target)
        {
            var ln1 = CreateListNode(L1);
            var ln2 = CreateListNode(L2);
            var res = solution.AddTwoNumbers(ln1, ln2);
            var tar = CreateListNode(target);

            Console.WriteLine("");
            Console.WriteLine(ListNode2String(ln1));
            Console.WriteLine(ListNode2String(ln2));
            Console.WriteLine(" => " + ListNode2String(res));
            Console.WriteLine("  : " + ListNode2String(tar));

            var c_res = res;
            var c_tar = tar;
            while(c_res != null && c_tar != null)
            {
                if (c_res.val != c_tar.val)
                {
                    Console.WriteLine(" BAD");
                    return false;
                }
                c_res = c_res.next;
                c_tar = c_tar.next;
            }
            if (c_res == null && c_tar == null)
            {
                Console.WriteLine(" GOOD");
                return true;
            }

            Console.WriteLine(" BAD");
            return false;
        }

        static Solution.ListNode CreateListNode(List<int> L)
        {
            Solution.ListNode res = new Solution.ListNode(0);
            var cur = res;
            foreach (int i in L)
            {
                cur = cur.next = new Solution.ListNode(i);
            }
            return res.next;
        }

        static string ListNode2String(Solution.ListNode L)
        {
            string s = "(";
            while(L != null)
            {
                s += L.val.ToString() + "->";
                L = L.next;
            }
            return s.Substring(0, s.Length - 2) + ')';
        }
    }
}
