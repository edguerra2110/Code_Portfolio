///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Project 4
//	File Name:         Event.cs
//	Description:       Event class to assign leave or enter type.
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
    enum EVENTTYPE { ENTER, LEAVE };
    class Event : IComparable
    {
        /// <summary>
        /// properties
        /// </summary>
        public EVENTTYPE Type { get; set; } // type of event
        public DateTime Time { get; set; } // time of event
        public Registrant Registrant { get; set; } // registrant ID

        
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="type">event type</param>
        /// <param name="time">time</param>
        /// <param name="registrant">registrant id</param>
        public Event(EVENTTYPE type, DateTime time, Registrant registrant)
        {
            Type = type;
            Time = time;
            Registrant = registrant;
        }

        /// <summary>
        /// to string override
        /// </summary>
        /// <returns>event in string form</returns>
        public override string ToString()
        {
            string str = "";
            str += String.Format("Registrant {0}",Registrant.RegistrantID.PadLeft(3));
            str += Type + "'s";
            str += String.Format(" at {0}", Time.ToShortTimeString().PadLeft(8));
            return str;
        }

        /// <summary>
        /// compare to make sure even is an object
        /// </summary>
        /// <param name="obj">time</param>
        /// <returns>dateTime</returns>
        public int CompareTo(Object obj)
        {
            if (!(obj is Event))
            {
                throw new ArgumentException("The argument is not an Event object");
            }
            Event e = (Event)obj;
            return (e.Time.CompareTo(Time));
        }

    }
}
	

	

