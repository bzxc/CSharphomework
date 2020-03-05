using System;
using System.Collections.Generic;

namespace _2
{
    class Program
    {
        class Solution 
        {
            public static int maxNumber(List<int> nums) {
                int max =  int.MinValue;
                foreach(int i in nums) {
                    if(i > max) {
                        max = i;
                    }
                }
                return max;
            }
            public static int minNumber(List<int> nums) {
                int min =  int.MaxValue;
                foreach(int i in nums) {
                    if(i < min) {
                        min = i;
                    }
                }
                return min;
            }

            public static int sumNumber(List<int> nums) {
                int count = 0;
                foreach(int i in nums) {
                    count += i;
                }
                return count;
            }

            public static int meanValue(List<int> nums) {
                int sum = sumNumber(nums);
                return sum/nums.Count;
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
