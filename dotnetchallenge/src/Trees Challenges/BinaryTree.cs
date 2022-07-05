using System;
using System.Collections.Generic;

namespace dotnetchallenge.TreesChallenges
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
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
        //Definition for a binary tree node.

//        Given the root of a binary tree, return the level order traversal of its nodes' values. (i.e., from left to right, level by level).

//Example 1:
//    3
///9     20
// /    15 7

//Input: root = [3,9,20,null,null,15,7]
//        Output: [[3],[9,20],[15,7]]

            public static IList<IList<int>> LevelOrder(TreeNode root)
            {
                IList<IList<int>> result = new List<IList<int>>();
                if (root != null)
                {
                    AddValue(root, 0);
                }
                return result;

                void AddValue(TreeNode node, int level)
                {
                    if (result.Count == level)
                    {
                        result.Add(new List<int>());
                    }
                    result[level].Add(node.val);
                    if (node.left != null)
                    {
                        AddValue(node.left, level + 1);
                    }
                    if (node.right != null)
                    {
                        AddValue(node.right, level + 1);
                    }
                }
            }
        
    }
}
