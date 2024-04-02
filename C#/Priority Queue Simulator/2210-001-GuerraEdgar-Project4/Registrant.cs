///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Project 4
//	File Name:         Registrant.cs
//	Description:       Registrant Class to assign start, interval, id, and hasevent
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

namespace Project4
{
    class Registrant: IComparable
    {
        /// <summary>
        /// properties
        /// </summary>
        public TimeSpan Start { get; set; }// start time
        public TimeSpan Interval { get; set; }// interval
        public string RegistrantID { get; set; }// registrant ID
        public Boolean HasEvent { get; set; }// Hasevent bool to know if the events have been created

        /// <summary>
        /// constructor for the registrant class
        /// </summary>
        /// <param name="start"> start time</param>
        /// <param name="interval"> interval to know end time</param>
        /// <param name="id">user ID</param>
        /// <param name="even">even is short for event to know if they have an event or not</param>
        public Registrant(TimeSpan start, TimeSpan interval, int id, Boolean even)
        {
            Start = start;
            Interval = interval;
            RegistrantID = id.ToString().PadLeft(4, '0');
            HasEvent = even;
        }

        /// <summary>
        /// implementation of icomparable in case we want to compare objects
        /// </summary>
        /// <param name="obj">the object to be compared</param>
        /// <returns>registrant ID</returns>
        public int CompareTo(object obj)
        {
            if (!(obj is Registrant))
            {
                throw new ArgumentException("The argument is not a Registrant object");
            }
            Registrant r = (Registrant)obj;
            return (r.RegistrantID.CompareTo(RegistrantID));
        }
    }
}
