///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Project 4
//	File Name:         PQNodeT.cs
//	Description:       Top node to be compared
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
    /// Node class for events 
    /// </summary>
    /// <typeparam name="T"> event obj</typeparam>
    public class Node<T> where T:IComparable
    {
        //Properties
        /// <summary>
        /// Value named item of type t
        /// </summary>
        public T Item { get; set; }
        /// <summary>
        /// Reference to the next Node in the Priority Queue
        /// </summary>
        public Node<T> Next { get; set; }
        /// <summary>
        /// Initilizes a new instance of node class
        /// </summary>
        /// <param name="value">item of type t</param>
        /// <param name="link">node link</param>
        public Node(T value, Node<T> link)
        {
            Item = value;
            Next = link;
        }
    }
}
