//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:			Project 3 - Tower of Hanoi
//	File Name:		SplashScreen.cs
//	Description:		this class is the splash screen form 
//	Course:			CSCI 2210-001 - Data Structures
//	Author:			Edgar Guerra, guerrae@etsu.edu, Department of Computing, East Tennessee State University
//	Created:			4/10/2020
//	Copyright:		Edgar Guerra, 2020
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Project3
{
    /// <summary>
    /// This is the splash screen for the project
    /// </summary>
    public partial class Splashscreen : Form
    {
        /// <summary>
        /// Initializes a new instance of the splash screen and sets the version for the user.
        /// </summary>
        public Splashscreen()
        {
            InitializeComponent();
            this.VersionLabel.Text = String.Format("Version {0}", AssemblyVersion);
        }
        /// <summary>
        /// Gets the assembly version for the user to use on the form
        /// </summary>
        /// <value>
        /// returns the assembly version
        /// </value>
        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        /// <summary>
        /// a timer that ticks for 3.5 seconds and tells the form to close
        /// </summary>
        /// <param name="sender">the timer on the form.</param>
        /// <param name="e">the timer stops ticking</param>
        private void SplashScreenTimer_Tick(object sender, EventArgs e)
        {
            this.Close();// close after its done
        }
    }
}
