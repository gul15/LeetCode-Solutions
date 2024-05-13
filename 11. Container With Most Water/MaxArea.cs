using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._11._Container_With_Most_Water
{
    internal class _MaxArea
    {
        public static int MaxArea(int[] height)
        {
            int start = 0;
            int end = height.Length - 1;

            int max_volume = 0;

            while (true)
            {
                int current_volume = Math.Min(height[start], height[end]) * (end - start);
                if (current_volume > max_volume)
                    max_volume = current_volume;

                if (height[start] > height[end])
                {
                    end--;
                }
                else
                {
                    start++;
                }

                if (start >= end)
                {
                    break;
                }
            }
            return max_volume;
        }
    }
}
