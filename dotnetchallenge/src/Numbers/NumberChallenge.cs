using System;
using System.Collections.Generic;

namespace dotnetchallenge.src.Numbers
{
    public static class NumberChallenge
    {
        public static int Reverse(int x)
        {
            long reverse = 0;
        
            while (x != 0)
            {
                int rem = x % 10;
                reverse = reverse * 10 + rem;
               
                if (reverse < int.MinValue || reverse > int.MaxValue)
                {
                    return 0;
                }
                x = x / 10;

            }
            return (int)reverse;
        }
        public static List<int> SwapNumbersWithoutTemp(int n1, int n2)
        {
            n1 = n1 + n2;
            n2 = n1 - n2;
            n1 = n1 - n2;
            return new List<int>
            { n1,  n2 };
          
        }
    }
}
