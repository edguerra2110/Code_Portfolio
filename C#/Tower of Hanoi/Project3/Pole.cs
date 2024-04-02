//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:			Project 3 - Tower of Hanoi
//	File Name:		Pole.cs
//	Description:		this class is the pole which will hold disks at any given time in the game
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
    /// this class represents one of the three poles for the game of Hanoi.
    /// </summary>
   public class Pole
    {
        private Stack<Disk> PoleStack = new Stack<Disk>(); // this will hold the pole classes pole with stacks of disks.
        private int poleStack = 0;
        public int DiskCount { get{ return poleStack; }  private set { poleStack = value; } }// read only property that gets the disk count
        /// <summary>
        /// default constructor for the pole class. 
        /// </summary>
        public Pole()
        {
        }

        //adds the disks to the pole by pushing the List of Disks to the stack
        public void SetUpDisks(List<Disk> tempDisk)
        {
            for (int i = tempDisk.Count; i > 0; i--)
            {
                PoleStack.Push(tempDisk[i-1]);
            }
            DiskCount = PoleStack.Count();
        }

        /// <summary>
        /// Peeks the pole stack to see whats on top
        /// </summary>
        /// <returns>top item on the stack</returns>
        public Disk PeekPole()
        {
            Disk peekDisk = new Disk();
            if (PoleStack.Count != 0)
            {
                peekDisk = PoleStack.Peek();
                return peekDisk;
            }
            return peekDisk;

        }

        /// <summary>
        /// Pushes a disk to the pole
        /// </summary>
        /// <param name="pushItem">The Disk to be pushed to the pole stack.</param>
        public void PushPole(Disk pushItem)
        {
            
            PoleStack.Push(pushItem);
            poleStack = PoleStack.Count();    
        }
        /// <summary>
        /// Pops the Disk off the top of the pole
        /// </summary>
        /// <returns>A Disk object</returns>
        public Disk PopPole()
        {
            Disk poppedDisk = new Disk();
            if (PoleStack.Count != 0)
            {
              poppedDisk =   PoleStack.Pop();
                poleStack = PoleStack.Count();
                return poppedDisk;
            }
            return poppedDisk;
        }
        /// <summary>
        /// Converts the pole to a visual string to be displayed later
        /// </summary>
        /// <returns>
        /// a visual of the pole stack
        /// </returns>
        public override string ToString()
        {
            List<Disk> tempList = new List<Disk>();
            String poleStackVisual = "";

            if (PoleStack.Count > 0)
            {
                foreach (var item in PoleStack)
                {
                    tempList.Add(item);
                }
                for (int i = 0; i < tempList.Count; i++)
                {
                    poleStackVisual = poleStackVisual + tempList[i].ToString() + Environment.NewLine;
                }


                return poleStackVisual;
            }
            return poleStackVisual;
           
        }

    }
}
