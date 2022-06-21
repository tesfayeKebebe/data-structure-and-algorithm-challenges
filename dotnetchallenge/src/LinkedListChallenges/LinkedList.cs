using System;
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
    }
  
}
