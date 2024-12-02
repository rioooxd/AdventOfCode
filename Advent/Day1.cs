using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    public static class Day1
    {
        public static int Sum(string[] file)
        {
            int sum = 0;
            int[] firstArray = new int[file.Length];
            int[] secondArray = new int[file.Length];

            for (int i = 0; i < file.Length; i++)
            {
                string[] pair = file[i].Split("   ").ToArray();
                int.TryParse(pair[0], out firstArray[i]);
                int.TryParse(pair[1], out secondArray[i]);
            }

            Array.Sort(firstArray);
            Array.Sort(secondArray);
            for (int i = 0; i < firstArray.Length; i++)
            {
                sum += Math.Abs(firstArray[i] - secondArray[i]);
            }
            return sum;
        }
    }
}
