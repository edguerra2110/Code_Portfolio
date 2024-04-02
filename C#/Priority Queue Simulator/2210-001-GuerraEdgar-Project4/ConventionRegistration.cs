///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Project 4
//	File Name:         ConventionRegistration.cs
//	Description:       Simulation of a convention that gathers statistics.
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
using PQ_Wiener;
using System.Threading;
using System.Collections;

namespace Project4
{
    /// <summary>
    /// Simulation of a convention that gathers statistics
    /// </summary>
    class ConventionRegistration
    {
        /// <summary>
        /// Variables
        /// </summary>
        private static List<Registrant> registrants = new List<Registrant>(); // list of registrant id's
        private static Random r = new Random(); /// random class
        public static List<Queue<Registrant>> conventionWindows = new List<Queue<Registrant>>();// windows
        private static PriorityQueue<Event> PQ = new PriorityQueue<Event>();/// Event type PriorityQueue 
        private static DateTime timeWeOpen;/// time opened class
        private static TimeSpan shortest,   //shortest stay
                                longest,    //longest stay
                                totalTime;  //totalTime

        /// <summary>
        /// Getters and setters
        /// </summary>
        public double ConventionHours { get; set; }// hours open
        public int NumberOfWindows { get; set; } // number of windows
        public double AverageWaitingTime { get; set; } // avgerage waiting time
        public int RegistrantCount { get; set; } // number of registrants
        public int Queuemin { get; set; } // gets the queue min ammount
        public int MaxQueueCount { get; set; } // gets max queue count
        public int MinQueueID { get; set; } // gets/sets minque id
        public int amountLeft { get; set; } // gets/sets amount of users left
        public int amountArrived { get; set; } // gets/sets ammount of people who have arrived

        /// <summary>
        /// Constructor for the class
        /// </summary>
        /// <param name="conventionHours">gets and sets convention hours</param>
        /// <param name="numberOfWindows"> gets and sets number of windows</param>
        /// <param name="avgWaitingTime">gets and sets avgerage waiting time</param>
        /// <param name="registCount">gets and sets total registrant count</param>
        public ConventionRegistration(double conventionHours, int numberOfWindows, double avgWaitingTime, int registCount)
        {
            //setting all getters and setters
            ConventionHours = conventionHours;
            NumberOfWindows = numberOfWindows;
            AverageWaitingTime = avgWaitingTime;
            RegistrantCount = Distribution.Poisson(registCount, r);
            timeWeOpen = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 8, 0, 0);
        }

        /// <summary>
        /// creates all enter queue based on the registrant count
        /// </summary>
        public void CreateEvents() 
        {
            TimeSpan start;
            TimeSpan interval;
            shortest = new TimeSpan(0, 1, 30);
            longest = new TimeSpan(0, 0, 0);
            totalTime = new TimeSpan(0, 0, 0);
          

            amountLeft = 0;// amount who left
            amountArrived = 0;// amount arrived
            Queuemin = 1000; // set queue min

            for (int i = 1; i < RegistrantCount; i++)
            {
                //Random start time based on number of min. in the 10 hours open
                start = new TimeSpan(0, r.Next((int)ConventionHours * 60), 0);

                //random (neg. exp) interval with a min of 1.5 min; expected time 4.5
                interval = new TimeSpan(0, (int)(1.5 + Distribution.NegExp(AverageWaitingTime, r)), 0);
                totalTime += interval;
                if (shortest > interval)
                    shortest = interval;
                if (longest < interval)
                    longest = interval;
                Registrant regi = new Registrant(start, interval, i, true);
                registrants.Add(regi);
                PQ.Enqueue(new Event(EVENTTYPE.ENTER, timeWeOpen.Add(start), regi));// enqueue arrival
            }
           

        }

        /// <summary>
        /// does the sumulation for the convention
        /// </summary>
        public void DoSimulation()
        {
            amountLeft = 0;// amount who left
            amountArrived = 0;// amount arrived
            Queuemin = 1000; // set queue min

            //creating queues
            for (int i = 0; i < NumberOfWindows; i++)
            {

                Queue<Registrant> window = new Queue<Registrant>(); // single line
                conventionWindows.Add(window);// creates all the windows
            }

            conventionWindows.TrimExcess();
        
            while (PQ.Count > 0) // loop through priority queue
            {
                if (PQ.Count != 0) // check if pq is not empty
                {
                    if (PQ.Peek().Type == EVENTTYPE.LEAVE) // is leave event
                    {
                        for (int i = 0; i < conventionWindows.Count; i++)//go through each queue and find the register
                        {
                            if (conventionWindows[i].Count != 0) // if convention window is not 0
                            {
                                if (conventionWindows[i].Peek().RegistrantID == PQ.Peek().Registrant.RegistrantID) //if id matches
                                {
                                    TimeSpan newStart = PQ.Peek().Registrant.Start;
                                    TimeSpan newInterval = PQ.Peek().Registrant.Interval;
                                    PQ.Dequeue();
                                    conventionWindows[i].Dequeue();
                                    amountLeft++;
                                    if (conventionWindows[i].Count != 0)// if convention window is not 0
                                    {
                                        if (conventionWindows[i].Peek().HasEvent == false)
                                        {
                                            conventionWindows[i].Peek().HasEvent = true;
                                            PQ.Enqueue(new Event(EVENTTYPE.LEAVE, timeWeOpen.Add(conventionWindows[i].Peek().Start + conventionWindows[i].Peek().Interval), conventionWindows[i].Peek())); //enqueue departure

                                            break;
                                        }

                                    }
                                    break;
                                }
                            }
                        }
                    }
                    else // even is an enter event
                    {
                        for (int i = 0; i < conventionWindows.Count; i++) // get queue with the least amount of users
                        {
                            if (conventionWindows[i].Count <= Queuemin) // if has least amount
                            {
                                Queuemin = conventionWindows[i].Count; // get queuemin
                                MinQueueID = i;

                            }
                        }
                        if (conventionWindows[MinQueueID].Count == 0) // if min window count is 0
                        {
                            conventionWindows[MinQueueID].Enqueue(PQ.Peek().Registrant);
                            amountArrived++;
                            PQ.Peek().Registrant.HasEvent = true;
                            PQ.Dequeue();
                            PQ.Enqueue(new Event(EVENTTYPE.LEAVE, timeWeOpen.Add(conventionWindows[MinQueueID].Peek().Start + conventionWindows[MinQueueID].Peek().Interval), conventionWindows[MinQueueID].Peek()));
                            Queuemin = 1000;
                        }
                        else // event window is not 0 so registrant has to wait his turn
                        {
                            conventionWindows[MinQueueID].Enqueue(PQ.Peek().Registrant);
                            amountArrived++;
                            PQ.Peek().Registrant.HasEvent = false;
                            PQ.Dequeue();
                            Queuemin = 1000;
                        }
                    }
                        
                } // END OF: if pq is not empty check for the event 

                for (int i = 0; i < conventionWindows.Count; i++) // find max queue count
                {
                    if (conventionWindows[i].Count >= MaxQueueCount)
                    {
                        MaxQueueCount = conventionWindows[i].Count;
                    }
                }
                
                List<Queue<Registrant>> newQueue = new List<Queue<Registrant>>(); // temporary list queue of registrants
                List<Queue<string>> stringQueue = new List<Queue<string>>();// temporary string queue for registrant id
                for (int i = 0; i < NumberOfWindows; i++)// loop through window count and set the queues
                {
                    Queue<string> newSTQ = new Queue<string>();
                    Queue<Registrant> tempQueue = new Queue<Registrant>();
                    newQueue.Add(tempQueue);
                    stringQueue.Add(newSTQ);
                }
               // update queue to have same amount of items
                for (int i = 0; i < conventionWindows.Count; i++)
                {
                    var copy = new Queue<Registrant>(conventionWindows[i]);
                    if (copy.Count !=0)
                    {
                        newQueue[i] = copy;
                    }
                       

                    for (int w = 0; w < newQueue[i].Count; w++)
                    {
                        while (newQueue[i].Count!=0)
                        {
                            stringQueue[i].Enqueue(newQueue[i].Peek().RegistrantID);
                                                    newQueue[i].Dequeue();
                        }
                        
                    }
                   
                }

                for (int i = 0; i < stringQueue.Count; i++)
                {
                    if (stringQueue[i].Count != MaxQueueCount) // if convention windows i count does not equal maxqueuecount
                    {
                        for (int w = stringQueue[i].Count; w < MaxQueueCount; w++) // loop through the list and add an empty string until all lists are the same size
                        {
                            stringQueue[i].Enqueue("    ");
                        }
                    }
                }

                StringBuilder heading = new StringBuilder();
                Console.WriteLine("\n\n");
                heading.Append("\t\t");
                for (int i = 0; i < stringQueue.Count; i++) // create all the windows in the console
                {
                    heading.Append(" W " + i+"".PadRight(16));
                }
                Console.WriteLine(heading.ToString());
                Console.WriteLine("\n\n");
                StringBuilder QSB = new StringBuilder();
                QSB.Append("\t\t");
                for (int i = 0; i <= MaxQueueCount; i++) // loop through the max queue height
                {
                    QSB.Clear();
                    QSB.Append("\t\t");

                    for (int c = 0; c < stringQueue.Count; c++) // loop through all the windows
                    {
                            if (stringQueue[c].Count != 0)
                            {
                                QSB.Append(stringQueue[c].Peek() + "".PadRight(16));
                                stringQueue[c].Dequeue();
                            }
                    }
                    Console.WriteLine(QSB.ToString() + "\n");


                }
                
                ///statistics 

                Console.WriteLine("----------------------------------------------------------------------------------------------\n\n");
                Console.WriteLine("Longest Queue Encountered So Far: " + MaxQueueCount);
                Console.WriteLine("Events Processed So Far: " + (amountArrived + amountLeft) + "\tArrivals: " + amountArrived + "\tDepartures: " + amountLeft);
                Thread.Sleep(75);
                if (PQ.Count == 0)
                {
                    AverageWaitingTime = (totalTime.TotalSeconds / RegistrantCount) / 60;
                    
                    Console.WriteLine("The average service time for " + RegistrantCount + " Registrants was " + AverageWaitingTime + ".");
                    Console.WriteLine("The minimum service times was " + shortest.ToString() + " and the maximum service time was " + longest.ToString()); 
                    Console.ReadKey();
                }
                Console.Clear();

                

            }
            
        }





    }
}
