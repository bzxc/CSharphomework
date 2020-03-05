using System;
using System.Collections.Generic;

namespace _1
{
    class Program
    {
        public class Solution {
            public static List<int> primeNumber(List<int> nums) {
                List<int> pNum = new List<int>();
                foreach(int n in nums) {
                    bool t = isPrime(n);
                    if(t) {
                        pNum.Add(n);
                    }
                }
                return pNum;
            }

            private static bool isPrime(int n) {
                if (n <= 3) {
                    return n > 1;
                }
                int sqrt = (int)Math.Sqrt(n);
                for (int i = 2; i <= sqrt; i++) {
                    if(n % i == 0) {
                        return false;
                    }
                }
                return true;
            }
        }
        static void Main(string[] args)
        {
            List<int> test = new List<int>{1,2,3,5,7,8};
            List<int> result = Solution.primeNumber(test);
            foreach(int i in result) {
                Console.Write(i);
            }
        }
    }
}
