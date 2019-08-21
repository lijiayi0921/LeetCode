using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Tools
    {
        public static string IntArrayToString(int[] array)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("[");
            for (int i = 0; i < array.Length; i++)
            {
                stringBuilder.AppendFormat("{0}, ", array[i]);
            }
            return stringBuilder.ToString().Substring(0, stringBuilder.Length - 2) + "]";
        }
    }
}
