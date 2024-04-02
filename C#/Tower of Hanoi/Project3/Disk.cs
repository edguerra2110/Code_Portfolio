//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:			Project 3 - Tower of Hanoi
//	File Name:		Disk.cs
//	Description:		this class is the disk for the tower it holds the disk size and the visual representation of the disk
//	Course:			CSCI 2210-001 - Data Structures
//	Author:			Edgar Guerra, guerrae@etsu.edu, Department of Computing, East Tennessee State University
//	Created:			4/10/2020
//	Copyright:		Edgar Guerra, 2020
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    /// <summary>
    /// a disk class that holds the DiskSize variable and the ToString that returns a visual of the disk.
    /// </summary>
    public class Disk
    {
        public int DiskSize; // this disk's size

        /// <summary>
        /// The default constructor 
        /// </summary>
        public Disk()
        {
            DiskSize = 0;
        }

        /// <summary>
        /// This is for creating a copy of a disk.
        /// </summary>
        /// <param name="diskSize">Size of the disk we are copying.</param>
        public Disk(Disk disk)
        {
            DiskSize = disk.DiskSize;
        }

        /// <summary>
        /// Parameterized constructor that takes in a disk size or inputs a default disk size of 0
        /// </summary>
        public Disk(int diskSize=0)
        {
            DiskSize = diskSize;
        }

        /// <summary>
        /// Converts the disk class to a visual string of the disk.
        /// </summary>
        /// <returns>
        /// N amounts of dashes(-) where N is the DiskSize
        /// </returns>
        public override string ToString()
        {
            string visualDisk = "";
            for (int i = 0; i < DiskSize; i++)
            {
                visualDisk = visualDisk + "-";
            }
            return visualDisk;
        }
    }
}
