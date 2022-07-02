using System;
using System.Collections;
using System.Collections.Generic;

namespace dotnetchallenge.LinkedListChallenges
{
    public class Node
    {
        public Node Next { get; set; } = null;
        public int Data { get; set; }
        public Node(int data)
        {
            Data = data;
        }
        public void AddingTail(int data)
        {
            #region stack is working based on lifo
            Stack<int> myStack = new Stack<int>();
            myStack.Push(5);
            myStack.Push(6);
            myStack.Push(7);
            myStack.Peek();
            myStack.Pop();
            #endregion
            Node end = new Node(data);
            Node n = this;
            while(n.Next !=null)
            {
                n = n.Next;
            }
            n.Next = end;
        }
        /*
         In order to remove duplicates from a linked list, we need to be able to track duplicates. A simple hash table
will work well here.
In the below solution, we simply iterate through the linked list, adding each element to a hash table. When
we discover a duplicate element, we remove the element and continue iterating. We can do this all in one
pass since we are using a linked list. */
        public Node RemoveDeplicateLinkedList(Node n)
        {
            /*The HashSet class implements the ICollection, IEnumerable, IReadOnlyCollection, ISet, IEnumerable, IDeserializationCallback, and ISerializable interfaces.
In HashSet, the order of the element is not defined. You cannot sort the elements of HashSet.
In HashSet, the elements must be unique.
In HashSet, duplicate elements are not allowed.
Is provides many mathematical set operations, such as intersection, union, and difference.
The capacity of a HashSet is the number of elements it can hold.
A HashSet is a dynamic collection means the size of the HashSet is automatically increased when the new elements are added.
In HashSet, you can only store the same type of elements.
             */
            HashSet<int> hs = new HashSet<int>();
            Node prev = null;
            while(n!=null)
            {
             if(hs.Contains(n.Data))
                {
                    prev.Next = n.Next;
                }
                else
                {
                    hs.Add(n.Data);
                    prev = n;

                }
                n = n.Next;
            }
            return prev;
        }
    }
  
}
