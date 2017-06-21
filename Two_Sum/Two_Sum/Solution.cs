using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Two_Sum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {

            for (int index1 = 0; index1 < nums.Length; index1++)
            {
                for (int index2 = index1 + 1; index2 < nums.Length; index2++)
                {
                    if ((nums[index1] + nums[index2]) == target)
                        return new int[] { index1, index2 };
                }
            }

            throw new ArgumentException("Can not get target from nums.");
        }
    }
}
