using System;
using System.Linq;
using dotnetchallenge.Arrays;
using dotnetchallenge.LinkedListChallenges;
using dotnetchallenge.src.Numbers;
using dotnetchallenge.src.Sortings;
using dotnetchallenge.TreesChallenges;

namespace dotnetchallenge
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var n = ArrayChallenges.ReturnSmallestPositive(new int[] { 1, 3, 6, 4, 2 });
            var captil = StringChallenge.GetIndexOfCapitalLetter("jose LUJan");
            var small = StringChallenge.GetIndexOfSmallLetter("jose LUJan");
            bool isAssending = ArrayChallenges.IsAssending(new int[] { 9, 17, 90, 106 });
            var od=  StringChallenge.ReturnMiddleString("books");
            var even = StringChallenge.ReturnMiddleString("coin");
            var dist = ArrayChallenges.GetDistinict(new int[] { 1, 1, 2, 2, 3, 3, 4, 5, 5, 6 });
            ArrayChallenges.ReturnNumbersNotInArray(new int[] { 1, 3, 6, 4, 1, 2 });
            int vowels = StringChallenge.CountVowels("car");
      var missingNumber = NumberChallenge.SequncialMissingNumber(new int [] { 1, 2, 3, 5 });
      //var s = StringChallenge.ReverseString("tesfaye");
      //int x = int.Parse(Console.ReadLine());
      int[] arr = new int[] { 1,1,  2,2, 5, 6,6,6, 8, 8, 8, 8, 8 };
        var data=    ArrayChallenges.CountDuplicates(arr);
            var maximumDuplicate = ArrayChallenges.MaximumOfDuplicates(data);
            var evenNumbers = ArrayChallenges.GetEvenNumberFromDuplicateArray(data);
            int[] arrs = new int[] { 1, 1, 2, 2, 8, 8, 8, 8, 8, 5, 6, 6, 6 };
            int[] arr1 = new int[] { 1, 1, 2, 2, 8, 8, 8, 8, 8, 5, 6, 6, 6 };
            var datas = ArrayChallenges.OrderArrayDesending(arrs);
            var assending = ArrayChallenges.OrderArrayAssending(arr1);
            var removeDu = ArrayChallenges.RemoveDuplicates(new int [] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 });
            LinqChallenge.MethodsInLinQ();
            ArrayChallenges.ShiftingToLeft(arr);
            //ArrayChallenges.ShiftingToRight(arr);
            //int x = 2;
            //    ArrayChallenges.Checkout(out x);
            //ArrayChallenges.Checkout(out x);
            //ArrayChallenges.Checkout(out x);
            //ArrayChallenges.Checkout(out x);
            // var st=  ArrayChallenges.GetStringReverse("tesfaye");
            // int reversed = ArrayChallenges.GetNumberReverse(257);
            //var byts = ArrayChallenges.getFirstSetBit(33);
            // bool isx = StringChallenge.IsPermutation("abcd", "abef");
             //ArrayChallenges.Triangle();
      //  int[] binaryData = new int[] { 3,7,12,15,22,25,30,41,74,83,92,95};
      //var r=  BinaryTree.Recursive(binaryData, 0, binaryData.Length-1, 83);
      //var i=  BinaryTree.IterativeBinarySearch(binaryData, binaryData.Length, 83);

      //Node n = new Node(5);
      //n.AddingTail(6);
      //n.AddingTail(8);
      //n.AddingTail(8);
      //n.AddingTail(6);
      //n.AddingTail(5);
      //n.RemoveDeplicateLinkedList(n);
            // ArrayChallenges.Triangle();
            //  int[] binaryData = new int[] { 3,7,12,15,22,25,30,41,74,83,92,95};
            //var r=  BinaryTree.Recursive(binaryData, 0, binaryData.Length-1, 83);
            //var i=  BinaryTree.IterativeBinarySearch(binaryData, binaryData.Length, 83);

            //Node n = new Node(5);
            //n.AddingTail(6);
            //n.AddingTail(8);
            //n.AddingTail(8);
            //n.RemoveDeplicateLinkedList(n);
            //char[][] matrix = new char[][] { { '1', '1', '1', '1', '0' }, { '1', '1', '1', '1', '0' } };
            //ArrayChallenges.NumIslands(matrix);

            //var swapped=   NumberChallenge.SwapNumbersWithoutTemp(10, 25);

            //   Node n1 = new Node(5);
            //   n1.Push(6);
            //   n1.Push(8);
            //   n1.Push(8);
            //   n1.Delete(6);

            /*var notUnique=   StringChallenge.IsUniqueString("tesfaye");
                        var unique = StringChallenge.IsUniqueString("tesfa");
                 var bitVector = StringChallenge.IsUniqueStringWithMinimizedSpace("tesfaye");
                  var uniqueBitVector = StringChallenge.IsUniqueStringWithMinimizedSpace("tesfa");   */
            //var IsPermutations = StringChallenge.Permutation("dogo", "ogod");
            //    var x=  NumberChallenge.Reverse(-12300);
            //var rotateToLeft = ArrayChallenges.RotateToLeft(new int[] { 1, 2, 3, 4,5 }, 2);
            //var rotateToRigh = ArrayChallenges.RotateToRight(new int[] { 1, 2, 3, 4,5 }, 3);
            // StringChallenge.ReverseString(new char[] { 'h', 'e', 'l', 'l', 'o' });
            //var IsPermutations = StringChallenge.IsPermutationUsingSort("dogo", "ogod");
            //var IsOneAway = StringChallenge.IsOneAway("pale", "bale");
            //var IsNotOneAway = StringChallenge.IsOneAway("pale", "bae");
            //var bubleSort = SortingChallenges.BubleSort(new int[] { 3, 4, 9, 3, 1 });
            //      var sum = ArrayChallenges.Sum(new int[] { 2, 7, 11, 15 }, 9);
            //var StringCompression = StringChallenge.StringCompression("aabcccccaaa");

            int sum = StringChallenge.CalPoints(new string[] { "5", "2", "C", "D", "+" });
            ArrayChallenges.Triangle();
            //  int[] binaryData = new int[] { 3,7,12,15,22,25,30,41,74,83,92,95};
            //var r=  BinaryTree.Recursive(binaryData, 0, binaryData.Length-1, 83);
            //var i=  BinaryTree.IterativeBinarySearch(binaryData, binaryData.Length, 83);

            //Node n = new Node(5);
            //n.AddingTail(6);
            //n.AddingTail(8);
            //n.AddingTail(8);
            //n.AddingTail(6);
            //n.AddingTail(5);
            //n.RemoveDeplicateLinkedList(n);
            /*var notUnique=   StringChallenge.IsUniqueString("tesfaye");
                        var unique = StringChallenge.IsUniqueString("tesfa");
                 var bitVector = StringChallenge.IsUniqueStringWithMinimizedSpace("tesfaye");
                  var uniqueBitVector = StringChallenge.IsUniqueStringWithMinimizedSpace("tesfa");   */
            //var IsPermutations = StringChallenge.Permutation("dogo", "ogod");
            //    var x=  NumberChallenge.Reverse(-12300);
            //var rotateToLeft = ArrayChallenges.RotateToLeft(new int[] { 1, 2, 3, 4,5 }, 2);
            //var rotateToRigh = ArrayChallenges.RotateToRight(new int[] { 1, 2, 3, 4,5 }, 3);
            // StringChallenge.ReverseString(new char[] { 'h', 'e', 'l', 'l', 'o' });
            //var IsPermutations = StringChallenge.IsPermutationUsingSort("dogo", "ogod");
            //var IsOneAway = StringChallenge.IsOneAway("pale", "bale");
            //var IsNotOneAway = StringChallenge.IsOneAway("pale", "bae");
            //var bubleSort = SortingChallenges.BubleSort(new int[] { 3, 4, 9, 3, 1 });
            // var sum = ArrayChallenges.Sum(new int[] { 2, 7, 11, 15 }, 9);
            //var StringCompression = StringChallenge.StringCompression("aabcccccaaa");
            bool isPalindrom = StringChallenge.IsPalindrom("Madam");
            int factorial = NumberChallenge.Factorial(5);

        }

    }
  }


