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

        public static void ShiftingToLeft(int[] arr)
        {
            if (arr.Length > 0)
            {
                int x = arr[0];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                    Console.WriteLine(arr[i + 1]);
                }
                arr[arr.Length - 1] = x;
                Console.WriteLine(arr[arr.Length - 1]);
            }

        }
        public static void ShiftingToRight(int[] arr)
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
        public static int GetNumberReverse(int n)
        {
            int  reverse = 0;
            while(n>0)
            {
                int rem = n % 10;
                reverse = (reverse * 10) + rem;
                n = n / 10;
            }
            return reverse;
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

    }




}
