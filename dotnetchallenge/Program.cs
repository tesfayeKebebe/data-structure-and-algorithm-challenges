using System;
using System.Linq;
using dotnetchallenge.Arrays;
using dotnetchallenge.LinkedListChallenges;
using dotnetchallenge.src.Numbers;
using dotnetchallenge.TreesChallenges;

namespace dotnetchallenge
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //int x = int.Parse(Console.ReadLine());
            int[] arr = new int[] { 1, 2, 5, 6, 8 };
            //ArrayChallenges.ShiftingToLeft(arr);
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
            // ArrayChallenges.Triangle();
            //  int[] binaryData = new int[] { 3,7,12,15,22,25,30,41,74,83,92,95};
            //var r=  BinaryTree.Recursive(binaryData, 0, binaryData.Length-1, 83);
            //var i=  BinaryTree.IterativeBinarySearch(binaryData, binaryData.Length, 83);

            //Node n = new Node(5);
            //n.AddingTail(6);
            //n.AddingTail(8);


            /*var notUnique=   StringChallenge.IsUniqueString("tesfaye");
                        var unique = StringChallenge.IsUniqueString("tesfa");
                 var bitVector = StringChallenge.IsUniqueStringWithMinimizedSpace("tesfaye");
                  var uniqueBitVector = StringChallenge.IsUniqueStringWithMinimizedSpace("tesfa");   */
            //var IsPermutations = StringChallenge.Permutation("dogo", "ogod");
            //    var x=  NumberChallenge.Reverse(-12300);
            // var rotateToLeft = ArrayChallenges.RotateToLeft(new int[] { 1, 2, 3, 4,5 }, 2);
            //var rotateToRigh = ArrayChallenges.RotateToRight(new int[] { 1, 2, 3, 4,5 }, 3);
            // StringChallenge.ReverseString(new char[] { 'h', 'e', 'l', 'l', 'o' });
           // var newString = StringChallenge.ReplaceAllSpaceInString("Mr John Smith ");
            var s = StringChallenge.IsPermutationOfPalindrome("tactcoapapa");
        }
    }
}
