//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:			Project 3 - Tower of Hanoi
//	File Name:		Tower.cs
//	Description:		this class holds the poles of the tower
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
    /// this class holds the 3 towers in which a player can move the disk from
    /// </summary>
    class Tower
    {
        private static int Poles = 3;// the amount of poles allowed in the game
        public static double TotalDisks = 0;
        public  List<Pole> PoleList = new List<Pole>(); // list of the poles that contain disks

        /// <summary>
        /// Initializes a new instance the tower class and sets up the disks.
        /// </summary>
        public Tower(double diskCount)
        {
            TotalDisks = diskCount; // total disk count
            List<Disk> diskList = new List<Disk>();// a list of disk
            for (int i = 0; i <Poles; i++) // loops through and create the three poles and add it to the PoleList
            {
                Pole pole = new Pole();
                PoleList.Add(pole);
            }
            for (int i = 0; i < TotalDisks; i++)
            {
                Disk disk = new Disk(i+1);
                diskList.Add(disk);

                
            }
            PoleList[0].SetUpDisks(diskList);

        }
        /// <summary>
        /// gets the total disks in the game.
        /// </summary>
        /// <returns>total disks in the game</returns>
        public int DiskCount()
        {
            return Convert.ToInt32(TotalDisks);
        }

        /// <summary>
        /// creates a copy of a former tower.
        /// </summary>
        /// <param name="copyTower">The copied tower.</param>
        public Tower(Tower copyTower)
        {
            this.PoleList = copyTower.PoleList;
        }

        /// <summary>
        /// a generic constructor for the class.
        /// </summary>
        public Tower()
        {
          
        }

        /// <summary>
        /// gets the current count of the total disks in a pole
        /// </summary>
        /// <param name="pole">specified pole</param>
        /// <returns>Disk count</returns>
        public int PoleCount(int pole)
        {
            if (pole == 0)
            {
                return PoleList[0].DiskCount;
            }
            if (pole == 1)
            {
                return PoleList[1].DiskCount;
            }
            if (pole == 2)
            {
                return PoleList[2].DiskCount;
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Determines whether the specified pole is even and returns true or false.
        /// </summary>
        /// <param name="pole">The pole we will check.</param>
        /// <returns>
        ///   returns true if the specified pole is even else it returns false.
        /// </returns>
        public bool IsEven(Pole pole)
        {
            if (pole.DiskCount % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// returns the total moves required to win
        /// </summary>
        /// <returns> total moves required</returns>
        public double TotalMovesRequired()
        {
            return Math.Pow(2, TotalDisks) - 1;
        }

        

        /// <summary>
        /// gives a visual representation of the towers
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            string visual = "";
            foreach (var item in PoleList)
            {
                item.ToString();
            }
            return visual;
        }
    }
}
