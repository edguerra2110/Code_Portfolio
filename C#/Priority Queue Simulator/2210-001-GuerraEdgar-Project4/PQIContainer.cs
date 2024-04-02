///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Project 4
//	File Name:         PQIcontainer.cs
//	Description:       Interface for icontainer
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
    /// Icontainer interface for events
    /// </summary>
    /// <typeparam name="T">event</typeparam>
    public interface IContainer<T>
    {
        //Remove all objects from the container
        void Clear();
        //Returns true if container is empty
        bool IsEmpty();
        //Returns the number of entries in the container
        int Count {get; set;}
    }
}
