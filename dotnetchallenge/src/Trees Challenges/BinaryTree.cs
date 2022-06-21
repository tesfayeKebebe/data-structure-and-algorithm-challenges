using System;
namespace dotnetchallenge.TreesChallenges
{
    public static class BinaryTree
    {
        //Binary Search Algorithm (Finding Target in a Sorted List)
        public static int Recursive(int[] a, int low, int high, int target)
        {
            
            if(low>high)
            {
                return -1;
            }
            int mid = (low + high) / 2;
            if(a[mid]==target)
            {
                return a[mid];
            }
            else if(target > a[mid])
            {
              return  Recursive(a, mid + 1, high, target);
            }
            else 
            {
              return  Recursive(a, low, mid-1, target);
            }
        }
        public static int IterativeBinarySearch(int[] a, int n, int target)
        {
            int low = 0;
            int high = n - 1;
            int retValue = 0;
            while(low<=high)
            {
                int mid = (high + low) / 2;
                if(a[mid]==target)
                    retValue= a[mid];
                if(target> a[mid])
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            return retValue;
        }
    }
}
