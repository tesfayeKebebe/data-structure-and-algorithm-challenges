using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace dotnetchallenge.Arrays
{
    public static class ArrayChallenges
    {

        public static void ShiftingToRight(int[] arr)
        {
            if (arr.Length > 1)
            {
                int x = arr[arr.Length-1];
                for (int i = arr.Length-2; i >0; i--)
                {
                    arr[i+1] = arr[i];
                    Console.WriteLine(arr[i + 1]);
                }
                arr[0] = x;
                Console.WriteLine(arr[0]);
            }

        }
        public static void ShiftingToLeft(int[] arr)
        {
            if (arr.Length > 0)
            {

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    int temp = arr[0];
                    arr[0] = arr[i + 1];
                    arr[i + 1] = temp;
                }
                ;
            }

        }
        public static long[] Solution(long n)
        {
            // Type your solution here
            List<long> arr = new List<long>();
            int f1 = 0, f2 = 1, i;
            if (n < 1)
                return arr.ToArray();
            if (n == 2)
                return arr.ToArray();
            for (i = 1; i < n; i++)
            {
                int next = f1 + f2;
                f1 = f2;
                f2 = next;
                if (f2 % 2 != 0)
                {
                    arr.Add(f2);
                }

            }
            return arr.ToArray();
        }

        public static void Checkout(out int value)
        {
            value = 1;
        }
        public static void CheckRef(ref int value)
        {
            value += 1;
        }
        public static string GetStringReverse(string s)
        {
            StringBuilder b = new StringBuilder();
            for (int i = s.Length-1; i >= 0; i--)
            {
                b.Append(s[i]);
            }
            return b.ToString();
        }
      
        public static int getFirstSetBit(int n)
        {
            // Special case
            if (n == 0)
            {
                return 0;
            }
            // Position of the first set bit from the right
            int position = 1;
            // Variable for shifting
            int mask = 1;
            // Counting the position of first set bit
            while ((n & mask) == 0)
            {
                position++;
                mask <<= 1;
            }
            return position;
        }
        public static void Triangle()
        {
            for (int row = 0; row < 6; row++)
            {
                // Counting backwards here!
                for (int spaces = 5 - row; spaces > 0; spaces--)
                {
                    Console.Write(" ");
                }

                for (int column = 0; column < (2 * row + 1); column++)
                {
                    Console.Write("*");
                }
            
                Console.WriteLine();
            }
        }
      public static List<string> merges(string[] words, string[] more)
        {
            List<string> sentence = new List<string>();
             foreach (string w in words) sentence.Add(w);
             foreach (var w in more) sentence.Add(w);
             return sentence;
            }

        //reversal approach of array rotation time complexity o(n) and auxilary place of o(1)

        public static int[] RotateToLeft(int [] arr, int r)
        {
            r %= arr.Length;
            ReverseArr(arr, 0,r- 1);
            ReverseArr(arr, r, arr.Length - 1);
            ReverseArr(arr, 0, arr.Length - 1);
            return arr;
        }
        //reverse the last all elements of the given array and then reverse the first
        //'r' elements followed by reversing the remaining 'n-1' elements
        public static int[] RotateToRight(int[] arr, int r)
        {
            r %= arr.Length;
            ReverseArr(arr, 0, arr.Length - 1);
            ReverseArr(arr, 0, r - 1);
            ReverseArr(arr, r, arr.Length - 1);
            return arr;
        }
        private static void ReverseArr(int[] arr, int start, int end)
        {
            while(start<end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
        /*
         * Given an array of integers, find two numbers such that they add up to a specific target
number.
The function twoSum should return indices of the two numbers such that they add
up to the target, where index1 must be less than index2. Please note that your returned
answers (both index1 and index2) are not zero-based.
         */
        public static int[] Sum(int[] nums, int target)
        {
            int[] result = new int[2];
            Dictionary<int, int> arr = new Dictionary<int, int>();
            for(int i=0; i<nums.Length; i++)
            {
                if(arr.ContainsKey(nums[i]))
                {
                    int index = arr[nums[i]];
                    result[0] = index + 1;
                    result[1] = i + 1;
                }
                else
                {
                    arr.Add(target - nums[i], i);
                }
            }
            return result;
        }
    }
    




}
