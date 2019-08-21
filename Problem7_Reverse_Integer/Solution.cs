using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7_Reverse_Integer
{
    public class Solution
    {

        public int Reverse(int x)
        {
            int res = 0;
            int remainder = x;
            while (remainder != 0)
            {
                int pop = remainder % 10;
                remainder = remainder / 10;
                if (res > int.MaxValue / 10 || (res == int.MaxValue / 10 && pop > 7))
                    return 0;
                if (res < int.MinValue / 10 || (res == int.MinValue / 10 && pop < -8))
                    return 0;

                res = res * 10 + pop;
            }
            
            return res;
        }

        public int Reverse_Lazy(int x)
        {
            long res = 0;
            long remainder = x;
            while (remainder != 0)
            {
                long pop = remainder % 10;
                remainder = remainder / 10;
                res = res * 10 + pop;
            }

            if (res > int.MaxValue || res < int.MinValue)
                res = 0;
            return (int)res;
        }
    }
}
