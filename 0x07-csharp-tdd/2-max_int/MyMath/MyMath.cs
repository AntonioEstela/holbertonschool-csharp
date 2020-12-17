using System;
using System.Collections.Generic;
using System.Linq;

namespace MyMath
{
    /// <summary>Provides operations with integers</summary>
    public class Operations
    {

        /// <summary>Find the max integer in a list</summary>
        public static int Max(List<int> nums)
        {
            if (nums == null)
                return 0;

            int maxInt = nums.First();

            foreach (var item in nums)
            {
                if (item > maxInt)
                    maxInt = item;
            }

            return maxInt;
        }
    }
}
