///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Project 4
//	File Name:         PQIPriority.cs
//	Description:       Sets priority based on the events ENTER/LEAVES
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
    /// Contract for priority queue
    /// </summary>
    /// <typeparam name="T">generic type t</typeparam>
   public interface IPriorityQueue<T>: IContainer<T> 
          where T: IComparable
    {
        //inserts item based on its priority 
        void Enqueue(T item);
        //Removes first item in the queue
        void Dequeue();
        //Query
        T Peek();
    }
}
