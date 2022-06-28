using System;
using System.Linq;
using System.Text;

namespace dotnetchallenge.Arrays
{
    public static class StringChallenge
    {
        public static bool IsPermutation(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }
            char[] arrOfS1 = s1.ToCharArray();
            char[] arrOfS2 = s2.ToCharArray();
            //declare an array of integer type with size 128 because as per the ASCII standard character set  
            //there are 128 characters for electronic communication.
            int[] charSettingMap = new int[128];
            PrepareCharSetMapping(arrOfS1, charSettingMap);
            PrepareCharSetMapping(arrOfS2, charSettingMap);
            return IsOddOneFound(charSettingMap);

        }
        public static void PrepareCharSetMapping(char[] inputString, int[] charSettingMap)
        {
            foreach (char s in inputString)
            {
                var index = (int)s;
                switch (charSettingMap[index])
                {
                    case 0:
                        charSettingMap[index] = 1;
                        break;
                    case 1:
                        charSettingMap[index] = 0;
                        break;
                }
            }
        }

        /// <summary>  
        /// Check if any index contains odd value in the integer array or not  
        /// </summary>  
        /// <param name="characterSetMappingTable">array of integer type with size 128 </param>  
        /// <returns></returns>  
        private static bool IsOddOneFound(int[] characterSetMappingTable)
        {
            return characterSetMappingTable.All(index => index != 1);
        }

        public static bool IsUniqueString(string str)
        {
            if (str.Length > 128) return false;
            Boolean[] char_set = new Boolean[128];
            for (int i = 0; i < str.Length; i++)
            {
                int val = str.ElementAt(i);
                if (char_set[val])
                {
                    return false;
                }
                char_set[val] = true;

            }
            return true;
        }
        public static bool IsUniqueStringWithMinimizedSpace(string str)
        {
            int checker = 0;
            for (int i = 0; i < str.Length; i++)
            {
                int val = str.ElementAt(i) - 'a';
                if ((checker & (1 << val)) > 0)
                {
                    return false;
                }
                checker |= (1 << val);

            }
            return true;
        }
    /*
         create permutation using sort method in C#
       */
       public static bool IsPermutationUsingSort(string s1, string s2)
    {
      if (s1.Length != s2.Length) return false;
      return Sort(s1).Equals(Sort(s2));
    }                          
    private static string  Sort(string s)
    {
      char[] sc = new char[s.Length];
      sc = s.ToCharArray();
      Array.Sort(sc);
      return new string(sc);
    }
        //We can also use the definition of a permutation-two words with the same character counts-to implement this algorithm. We simply iterate through this code, counting how many times each character appears.
        //Then, afterwards, we compare the two arrays.
        public static bool Permutation(string s, string t)
        {
            if (s.Length != t.Length) return false;
            int[] char_set = new int[128];
            char[] sArray = s.ToCharArray();
            foreach (var i in sArray)
            {
                char_set[i]++;
            }
            for (int i = 0; i < t.Length; i++)
            {
                int val = (int)t.ElementAt(i);
                char_set[val]--;
                if (char_set[val] < 0)
                {
                    return false;
                }
            }
            return true;
        }
        //Given two strings s1 and s2, return true if s2 contains a permutation of s1, or false otherwise.
        //In other words, return true if one of s1's permutations is the substring of s2.
        /* Example
         Input: s1 = "ab", s2 = "eidbaooo"
 Output: true
 Explanation: s2 contains one permutation of s1("ba").*/
        public static bool CheckInclusion(string s1, string s2)
        {
            if (s1.Length > s2.Length)
                return false;
            int[] s1map = new int[26];
            int[] s2map = new int[26];
            for (int i = 0; i < s1.Length; i++)
            {
                s1map[s1.ElementAt(i) - 'a']++;
                s2map[s2.ElementAt(i) - 'a']++;
            }

            int count = 0;
            for (int i = 0; i < 26; i++)
                if (s1map[i] == s2map[i])
                    count++;

            for (int i = 0; i < s2.Length - s1.Length; i++)
            {
                int r = s2.ElementAt(i + s1.Length) - 'a', l = s2.ElementAt(i) - 'a';
                if (count == 26)
                    return true;
                s2map[r]++;
                if (s2map[r] == s1map[r])
                    count++;
                else if (s2map[r] == s1map[r] + 1)
                    count--;
                s2map[l]--;
                if (s2map[l] == s1map[l])
                    count++;
                else if (s2map[l] == s1map[l] - 1)
                    count--;
            }
            return count == 26;

        }
        public static void ReverseString(char[] s)
        {

            string c = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                c = c + s[i];
            }
            s = c.ToCharArray();
        }
    /* There are three types of edits that can be performed on strings: insert a character,
remove a character, or replace a character. Given two strings, write a function to check if they are
one edit (or zero edits) away. 
     */
    public static bool IsOneAway(string sl, string s2)
    {
      if (Math.Abs(sl.Length - s2.Length) > 1) return false;
      int index1 = 0;
      int index2 = 0;
      bool IsFoundDifference = false;
      while(index1 < sl.Length && index2 < s2.Length)
      {
         if(sl.ElementAt(index1)!= s2.ElementAt(index2))
        {
          /* Ensure that this is the first difference found.*/
          if (IsFoundDifference) return false;
          IsFoundDifference = true;
          if (sl.Length == s2.Length)
            index1++;
        }
          else
        {
          index1++; ; // If matching, move shorter pointer
        }
        index2++; // Always move pointer for longer string
      }
      return true;
    }
  }
}
