using System;
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
    }
}
