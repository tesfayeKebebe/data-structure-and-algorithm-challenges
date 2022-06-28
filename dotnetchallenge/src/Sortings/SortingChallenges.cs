using System;
namespace dotnetchallenge.src.Sortings
{
    public static class SortingChallenges
    {
     // implementations buble sorting
     public static int[] BubleSort(int[] arr)
      {
  for(int i=0; i<arr.Length; i++)
      {
      for(int j=0; j<(arr.Length-i-1); j++)
         {
          if(arr[j]>arr[j+1])
            {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
            }

         }
       }
            return arr;
      }
    }
}
