using System;
using System.Collections.Generic;
namespace _3
{
    class Program
    {
        class Solution {
            public static List<int> aith(List<int> nums) {
                int max = maxNumber(nums);
                int sqrt = (int)Math.Sqrt(max);
                for(int i = 2; i < sqrt; i++) {
                    if(nums.Contains(i)) {
                        int x = i + i;
                        while(x < max) {
                            nums.Remove(x);
                            x += i;
                        }
                    }
                }
                return nums;
            }

            private static int maxNumber(List<int> nums) {
                int max = int.MinValue;
                foreach(int i in nums) {
                    if(i > max) {
                        max = i;
                    }
                }
                return max;
            }
        }
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            for(int i = 2; i <101; i++) {
                nums.Add(i);
            }
            List<int> newNums = Solution.aith(nums);
            foreach(int i in newNums) {
                Console.Write(i);
            }
        }
    }
}
