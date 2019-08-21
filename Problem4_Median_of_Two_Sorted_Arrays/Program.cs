using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Common;

namespace Problem4_Median_of_Two_Sorted_Arrays
{
    class Program
    {
        static Solution solution = new Solution();

        static void Main(string[] args)
        {
            Test(new int[] { 1, 3 }, new int[] { 2 }, 2.0);
            Test(new int[] { 1, 2 }, new int[] { 3, 4 }, 2.5);
        }

        static bool Test(int[] nums1, int[] nums2, double answer)
        {
            double res = solution.FindMedianSortedArrays(nums1, nums2);
            bool good = (res == answer);
            if (!good)
            {
                Console.WriteLine(Tools.IntArrayToString(nums1));
                Console.WriteLine(Tools.IntArrayToString(nums2));
                Console.WriteLine(" => " + res.ToString());
                Console.WriteLine("  : " + answer.ToString());
                Console.WriteLine(good ? " GOOD" : " BAD");
                Console.WriteLine("");
                Console.ReadKey();
            }
            return good;
        }
    }
}
