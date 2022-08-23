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
                int x = arr[arr.Length - 1];
                for (int i = arr.Length - 2; i > 0; i--)
                {
                    arr[i + 1] = arr[i];
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
            for (int i = s.Length - 1; i >= 0; i--)
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

        public static int[] RotateToLeft(int[] arr, int r)
        {
            r %= arr.Length;
            ReverseArr(arr, 0, r - 1);
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
            while (start < end)
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
            for (int i = 0; i < nums.Length; i++)
            {
                if (arr.ContainsKey(nums[i]))
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
        public static int DiagonalDifference(List<List<int>> arr)
        {
            int pd = 0, sd = 0, length = arr.Count();
            for (int r = 0; r < length; r++)
            {
                for (int c = 0; c < length; c++)
                {
                    //principal left to right
                    if (c == r)
                    {
                        pd += arr[r][c];
                    }
                    //right to left
                    if (c + r == length - 1)
                    {
                        sd += arr[r][c];
                    }
                }
            }
            return Convert.ToInt32(Math.Abs(sd - pd));

        }
        /*
         * Given an m x n 2D binary grid grid which represents a map of '1's (land) and '0's (water), return the number of islands.An island is surrounded by 
         * water and is formed by connecting adjacent lands horizontally or vertically. You may assume all four edges of the grid are all surrounded by water.

         */
        public static int NumIslands(char[][] grid)
        {
            int count = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        count++;
                        CallBfs(grid, i, j);
                    }

                }
            }
            return count;
        }
        public static void CallBfs(char[][] grid, int i, int j)
        {
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length || grid[i][j] == '0')
            {
                return;
            }
            grid[i][j] = '0';
            CallBfs(grid, i + 1, j);// row up
            CallBfs(grid, i - 1, j); //row down
            CallBfs(grid, i, j + 1); //column right
            CallBfs(grid, i, j - 1);  //column left
        }

        public static Dictionary<int, int> CountDuplicates(int[] arr)
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            foreach (var i in arr)
            {
                if (numbers.ContainsKey(arr[i])) numbers[i]++;
                else numbers[i]=1;
            }
            return numbers;
        }

        public static int MaximumOfDuplicates(Dictionary<int, int> datas)
        {
            int temp = 0;
            foreach(KeyValuePair<int, int> values in datas)
            {
                if(temp<values.Value)
                {
                    temp = values.Value;
                }

            }
            return temp;
        }
        public static List<int> GetEvenNumberFromDuplicateArray(Dictionary<int, int> arr)
        {
            var datas = arr.Keys;
            List<int> added = new List<int>();
            foreach(KeyValuePair<int, int> values in arr)
            {
                if(values.Key %2 ==0)
                {
                    added.Add(values.Key);
                }
            }
            return added;
        }
        public static int[] OrderArrayDesending(int[] arr)
        {
           
            for(int i=0; i<arr.Length; i++)
            {
                for(int j=i+1; j<arr.Length; j++)
                {
                    if(arr[i]<arr[j])
                    {
                        int tem = arr[j];
                        arr[j] = arr[i];
                        arr[i] = tem;
                    }
                }
            }
            return arr;
        }
        public static int[] OrderArrayAssending(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int tem = arr[j];
                        arr[j] = arr[i];
                        arr[i] = tem;
                    }
                }
            }
            return arr;
        }
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int i = 0;
            int j = 1;
            while (nums.Length > j)
            {

                if (nums[i] != nums[j])
                {

                    i++;
                    nums[i] = nums[j];
                }
                j++;
            }
            return i + 1;
        }
        public static int ReturnNumbersNotInArray(int[] A)
        {
            int temp = A[0];
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = i+1; i < A.Length; i++)
                {
                    if (i > j)
                    {
                        temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                    }

                }
            }
            temp = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    if (A[i] != i + 1)
                    {
                        Console.WriteLine("this is a debug message", i + 1);
                        return i + 1;
                    }
                    else
                    {
                        if (i == A.Length - 1)
                        {
                            Console.WriteLine("this is a debug message", i + 2);
                            return i + 2;
                        }
                    }
                }

            }

            return temp;
            // write your code in C# 6.0 with .NET 4.5 (Mono)
        }
        public static List<int> GetDistinict(int[] arr)
        {
            List<int> dist = new List<int>();
            List<int> convert = new List<int>(arr);
            foreach(int item in convert)
            {
                int count = convert.Count(x => x == item);
                if(count==1)
                {
                    dist.Add(item);
                }
            }
            return dist;
        }
    }

  }

    





