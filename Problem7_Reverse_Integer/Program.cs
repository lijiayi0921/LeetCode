using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7_Reverse_Integer
{
    class Program
    {
        static Solution solution = new Solution();

        static void Main(string[] args)
        {
            Test(123, 321);
            Test(-123, -321);
            Test(120, 21);
            Test(1, 1);
            Test(0, 0);
            Test(1534236469, 0);
        }

        static bool Test(int integer, int answer)
        {
            int res = solution.Reverse(integer);
            bool good = (res == answer);
            if (!good)
            {
                Console.WriteLine(integer.ToString());
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
