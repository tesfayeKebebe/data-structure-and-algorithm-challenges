using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace dotnetchallenge.Arrays
{
    public  class StringChallenge
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
       /* In the first scan, we
        count the number of spaces.By tripling this number, we can compute how many extra characters we will
        have in the final string. In the second pass, which is done in reverse order, we actually edit the string.*/
        public static string ReplaceAllSpaceInString(string s)
        {
            s= s.Trim();
           char[] c = s.ToCharArray();
            int trueLength = c.Length;
            //replace space by %20;
            int spaceCount = 0, index, i = 0;
            for ( i = 0; i < trueLength; i++)
            {
                if (c[i] == ' ')
                {
                    spaceCount++;
                }
            }
            index = trueLength + spaceCount * 2;
            char[] newArr = new char[index];
            for(i=trueLength-1; i>=0; i--)
            {
                if (c[i] ==' ')
                {
                    newArr[index - 1] = '0';
                    newArr[index - 2] = '2';
                    newArr[index - 3] = '%';
                    index = index - 3;
                }
                else
                {
                    newArr[index-1] = c[i];
                    index--;
                }
                
            }
            string st = new string(newArr);
          return st;
        }


        private static int GetCharcterNumber(char c)
        {
            //If a character represents a number, then this method returns the numeric value of c, otherwise it returns - 1.0.
            int a = (int) Char.GetNumericValue('a');
            int z = (int)Char.GetNumericValue('z');
            int val = (int)Char.GetNumericValue(c);
            if (val>=a && val<=z)
            {
                return val-a;
            }

            return -1;
        }
        /* tactcoapapa
    This is a question where it helps to figure out what it means for a string to be a permutation of a palindrome.
This is like asking what the "defining features" of such a string would be.
A palindrome is a string that is the same forwards and backwards. Therefore, to decide if a string is a permutation of a palindrome, we need to know if it can be written such that it's the same forwards and backwards.
What does it take to be able to write a set of characters the same way forwards and backwards? We need to
have an even number of almost all characters, so that half can be on one side and half can be on the other
side. At most one character (the middle character) can have an odd count.
For example, we know tactcoapapa is a permutation of a palindrome because it has two Ts, four As, two Cs, two Ps, and one 0. That O would be the center of all possible palindromes. 
         */
        public static bool IsPermutationOfPalindrome(string s)
        {
            int oddCount = 0;
            /* Count how many times each character appears. */
            int[] tables = new int[(int)(Char.GetNumericValue('z') - Char.GetNumericValue('a') + 1)];
            foreach(var i in s.ToCharArray())
            {
                int x = GetCharcterNumber(i);
                if(x!=-1)
                {
                    tables[x]++;
                    if(tables[x]%2==1)
                    {
                        oddCount++;
                    }
                    else
                    {
                        oddCount--;
                    }
                    
                }
            }
            return oddCount <= 1;
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
    /* String Compression: Implement a method to perform basic string compression using the counts
of repeated characters. For example, the string aabcccccaaa would become a2blc5a3. If the
"compressed" string would not become smaller than the original string, your method should return
the original string. You can assume the string has only uppercase and lowercase letters (a - z). 
     */
      public  static string StringCompression(string s)
      {
      StringBuilder b = new StringBuilder();
      int counter = 0;
       for(int i=0; i<s.Length; i++)
      {
        counter++;
        if(i+1 >= s.Length || s.ElementAt(i)!=s.ElementAt(i+1))
        {
          b.Append(s.ElementAt(i));
          b.Append(counter);
          counter = 0;
        }
      }
      return b.Length < s.Length ? b.ToString() : s;

    }
        //["5","2","C","D","+"]
        public static int CalPoints(string[] ops)
        {
            int sum = 0;
            List<int> numbers = new List<int>();
            for(int i=0; i<ops.Count(); i++)
            {
                if(!int.TryParse(ops[i], out int n))
                {
                    if(ops[i]=="C")
                    {
                        numbers.RemoveAt(i - 1);
                    }
                    if(ops[i]=="D")
                    {
                        int numb = 1;
                        for(int j= 0; j<numbers.Count(); j++)
                        {
                            numb *= numbers[j] * 2;
                        }
                        numbers.Add(numb);
                    }
                    if(ops[i]=="+")
                    {
                        for (int p = 0; p < numbers.Count(); p++)
                            sum += numbers[p];
                        numbers.Add(sum);
                        sum = 0;
                        for (int p = 0; p < numbers.Count(); p++)
                            sum += numbers[p];
                    }
                }
                else
                {
                    numbers.Add(Convert.ToInt32(ops[i]));
                }
            }
            return sum;
        }
        public bool IsValidParantheses(string s)
        {
         
            int n = -1;
            while (s.Length != n)
            {
                n = s.Length;
                s = s.Replace("()", "");
                s = s.Replace("[]", "");
                s = s.Replace("{}", "");
            }
            if (n == 0) return true;
            else return false;
        }

        public static bool IsPalindrom( string s)
        {
            char[] arr = s.ToCharArray();
            int st = 0;
            int end = s.Length - 1;
            while(st<end)
            {
                if(arr[st]!=arr[end])
                {
                    return false;
                }
                st++;
                end--;
            }
            return true;

        }

        public static bool IsPalindromeFromRemovingAlphanumeric(string s)
        {
            if (String.IsNullOrEmpty(s)) return true;

            s = s.ToLower();

            // check palindrome
            int i = 0;
            int j = s.Length - 1;

            bool isLetterOrDigitForward = false;
            bool isLetterOrDigitBack = false;
            //object x = 5;
            //bool isx = x is int; // used for checking the type of object
            //string y = x as string;// as used for conversion

            while (i < j)
            {
                isLetterOrDigitForward = Char.IsLetterOrDigit(s[i]);
                isLetterOrDigitBack = Char.IsLetterOrDigit(s[j]);

                if (isLetterOrDigitForward && isLetterOrDigitBack)
                {
                    if (s[i++] != s[j--]) return false;
                }
                else
                {
                    // Skip non-alphanumeric characters
                    if (!isLetterOrDigitForward) i++;
                    if (!isLetterOrDigitBack) j--;
                }
            }
            return true;

        }


   public static string ReverseString(string i)
    {
      char[] arr = i.ToCharArray();
      StringBuilder b = new StringBuilder();
for (int r = i.Length - 1; r > 0; r--)
      {
        b.Append(arr[r]);
      }
      return b.ToString();
    }

        ///You need to create a function to takes a string and returns the middle characters(s).
        ///If the words length is odd return the middle, buy if the words length is even return the middle 2 characters.
        public static string ReturnMiddleString(string s)
        {
            char[] sArray = s.ToCharArray();
            int midd = s.Length / 2;
            if(s.Length%2==0)
            {
                return sArray[midd - 1].ToString() + sArray[midd].ToString();
            }
            return sArray[midd].ToString();
        }


        public List<string> GetAllPosts() => new List<string>();

        public static int CountVowels(string s)
        {
            List<char> converted = new List<char>(s.ToLower().ToCharArray());
            List<char> vowels = new List<char>(new char[] { 'a', 'e', 'i', 'o', 'u' });
            int count = 0;
            foreach(char item in converted)
            {
                int check = vowels.Count(x => x == item);
                if(check>0)
                {
                    count++;
                }
            }
            return count;
        }
        public static List<int> GetIndexOfCapitalLetter(string s)
        {
            List<int> retVal = new List<int>();
            char[] arr = s.ToCharArray();
            for(int i=0; i<arr.Length; i++)
            {
                if(arr[i]>='A' && arr[i]<='Z')
                {
                    retVal.Add(i);
                }
            }
            return retVal;
        }
        public static List<int> GetIndexOfSmallLetter(string s)
        {
            List<int> retVal = new List<int>();
            char[] arr = s.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 'a' && arr[i] <= 'z')
                {
                    retVal.Add(i);
                }
            }
            return retVal;
        }



    }
}

