///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Project 4
//	File Name:         MenuDriver.cs
//	Description:       Driver for the program
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Edgar Guerra, guerrae@etsu.edu, Dept. of Computing, East Tennessee State University
//	Created:           Sunday, November 24, 2019
//	Copyright:         Edgar Guerra, 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using UtilityNamespace;
using Project4;
using PQ_Wiener;
using System.Threading;

namespace MenuClassDemo
{
    /// <summary>
    /// driver for the program
    /// </summary>
    class MenuDriver
    {
        /// <summary>
        /// main method
        /// </summary>
        /// <param name="args"></param>
        static void Main (string [ ] args)
        {
            ///setting the console to look pretty
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Title = "Convention Registration Simulation";
            ConventionRegistration convention = new ConventionRegistration(10.0,7,4.5,1000);
            Menu menu = new Menu ("Menu Demo");
            menu = menu + "Set the number of Registrants" + "Set the number of hours of operation" + "Set the number of windows" + "Set the expected checkout duration"+"Run the Simulation"+"End the program";

            Choices choice = (Choices) menu.GetChoice ( );
            while (choice != Choices.End)
            {
                switch (choice)
                {
                    case Choices.SetRegi:
                        Console.WriteLine ("How many registrants are expected to be served in a day?");
                        string regicount = Console.ReadLine();
                        convention.RegistrantCount = Int32.Parse(regicount);
                        Console.ReadKey ( );
                        break;

                    case Choices.SetHrs:
                        Console.WriteLine ("How many hours will registration be open?");
                        string hours = Console.ReadLine();
                        convention.ConventionHours = Int32.Parse(hours);
                        Console.ReadKey ( );
                        break;

                    case Choices.SetWindows:
                        Console.WriteLine ("How many registration lines are to be simulated?");
                        
                        string windows = Console.ReadLine();
                        convention.NumberOfWindows = Int32.Parse(windows);
                        Console.WriteLine(windows);
                        Console.ReadKey ( );
                        break;
                    case Choices.SetChkOut:
                        Console.WriteLine("What is the expected service time for a Registrant in minutes?\nExample: Enter 5.5 for  5 and half minutes ( 5 minutes, 30 seconds).");
                        string avg = Console.ReadLine();
                        convention.ConventionHours = Double.Parse(avg);
                        Console.ReadKey();
                        break;
                    case Choices.Run:
                        convention.CreateEvents();
                        convention.DoSimulation();
                        Console.ReadKey();
                        break;
                    case Choices.End:
                        Console.WriteLine("You selected End the program");
                        Console.ReadKey();
                        break;
                }  // end of switch

                choice = (Choices) menu.GetChoice ( );
            }  // end of while

        }  // end of main
    }
}
