<<<<<<< HEAD
using System;
=======
﻿using System;
using System.Collections.Generic;

>>>>>>> 3b6aca54a9e045f7a282397e21b4d6f3aa4dfcaa
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
<<<<<<< HEAD
    public static int Factorial(int n)
    {
   
        if(n==1)
      {
        return 1;
      }
     return  n * Factorial(n - 1);
      
     
      
    }

    public static int SequncialMissingNumber(int [] numbers)
    {
      for(int i=0; i<=numbers.Length-1; i++)  
      {
        if(i+1 != numbers[i])
        {
          return i + 1;
        }
        else
        {
          if(i ==numbers.Length-1)
          {
            return i + 2;
          }
        }
      }
      return 0;
    }
=======
        public static List<int> SwapNumbersWithoutTemp(int n1, int n2)
        {
            n1 = n1 + n2;
            n2 = n1 - n2;
            n1 = n1 - n2;
            return new List<int>
            { n1,  n2 };
          
        }
>>>>>>> 3b6aca54a9e045f7a282397e21b4d6f3aa4dfcaa
    }
 
}
