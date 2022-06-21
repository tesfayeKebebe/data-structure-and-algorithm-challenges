using System;
using System.Linq;

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
                if(char_set[val])
                {
                    return false;
                }
                char_set[val] = true;

            }
            return true;
        }

      
    }
}
