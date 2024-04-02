///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Project 4
//	File Name:         PriorityQueue.cs
//	Description:       The priority Queue for the project
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Edgar Guerra, guerrae@etsu.edu, Dept. of Computing, East Tennessee State University
//	Created:           Sunday, November 24, 2019
//	Copyright:         Edgar Guerra, 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PQ_Wiener
{
    /// <summary>
    /// Priority queue
    /// </summary>
    /// <typeparam name="T">item type T</typeparam>
    public class PriorityQueue<T>: IPriorityQueue<T> where T:IComparable
    {
        //Fields and properties
        private Node<T> top; // reference to the top of the PQ
        public int Count { get; set; } //Number of items in the PQ 

        /// <summary>
        /// add to queue
        /// </summary>
        /// <param name="item">item to add to queue</param>
        public void Enqueue(T item)
        {
            if (Count == 0) // if pq empty
            {
                top = new Node<T>(item, null); // add new node with desired item
            }
            else
            {
                Node<T> current = top;
                Node<T> previous = null;

                // search for the first node in the linked structure that is smaller than item
                while (current != null && current.Item.CompareTo(item) >= 0)
                {
                    previous = current;
                    current = current.Next;
                }

                // found the place to insert the new node
                Node<T> newNode = new Node<T>(item, current);

                // If there is a previous node, set it to link to the new node
                if (previous != null)
                {
                    previous.Next = newNode;// insert new node
                }
                else 
                {
                    top = newNode;
                }

            }
            Count++;// add 1 to number of nodes in the pq
        }// end enqueue method

        /// <summary>
        /// removes from queue
        /// </summary>
        public void Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Cannot remove from empty queue.");
            }

            else
            {
                Node<T> oldNode = top;
                top = top.Next;
                Count--;
                oldNode = null; // do this so the removed node can be garbage collected
            }
        }


        /// <summary>
        /// makes the PQ empty
        /// </summary>
        public void Clear()
        {
            top = null; // Nodes will be garbage collected
            Count = 0;	// Count is now 0 since PQ is empty
        }

        /// <summary>
        /// retrieve top item on the pq
        /// </summary>
        /// <returns>top item in pq if not empty</returns>
        public T Peek()
        {
            if (!IsEmpty())
            {
                return top.Item;
            }
            else
            {
                throw new InvalidOperationException("Cannot obtain top of empty priority queue.");
            }
        }

        /// <summary>
        /// asks whether the PQ is empty
        /// </summary>
        /// <returns>true if empty</returns>
        public bool IsEmpty() 
        {
            return Count == 0; //empty if count == 0
        }

    }
}
