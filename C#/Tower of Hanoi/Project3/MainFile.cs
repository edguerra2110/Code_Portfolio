//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:			Project 3 - Tower of Hanoi
//	File Name:		MainFile.cs
//	Description:		this class holds main method which will execute the splash screen form and main form
//	Course:			CSCI 2210-001 - Data Structures
//	Author:			Edgar Guerra, guerrae@etsu.edu, Department of Computing, East Tennessee State University
//	Created:			4/10/2020
//	Copyright:		Edgar Guerra, 2020
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    /// <summary>
    /// this is the main file class
    /// </summary>
    static class MainFile
    {
        /// <summary>
        /// this is where the start of the application lives. it will start the forms for us
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Splashscreen());// runs the splash screen
            Application.Run(new MainForm());// runs the main form
        }
    }
}
