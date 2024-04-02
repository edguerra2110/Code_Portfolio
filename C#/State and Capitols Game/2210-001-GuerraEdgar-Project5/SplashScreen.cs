//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 5 - Experience using dictionary and linq class
//	File Name:		SplashScreen.cs
//	Description:	A splashscreen form to show the user information about the program
//	Course:			CSCI 2210-001 - Data Structures
//	Author:			Edgar Guerra, guerrae@etsu.edu, Department of Computing, East Tennessee State University
//	Created:		Friday, April 24, 2020
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


namespace _2210_001_GuerraEdgar_Project5
{
    /// <summary>
    /// form to show the user information about the program
    /// </summary>
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            this.Version.Text = String.Format("Version {0}", AssemblyVersion); // sets the version label
            this.ProjName.Text = AssemblyProduct; //sets the project name
            this.OwnerLabel.Text = AssemblyCompany; // sets the owner name
            this.CopyR.Text = AssemblyCopyright;// sets the copyright
            this.textBox1.Text = AssemblyDescription;// sets the description from the assembly file

        }
        /// <summary>
        /// timer to close the file
        /// </summary>
        /// <param name="sender">timer</param>
        /// <param name="e">timer expired</param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// method to get assembly version
        /// </summary>
        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }
        /// <summary>
        /// method to get assembly description
        /// </summary>
        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }
        /// <summary>
        /// method to get assembly product
        /// </summary>
        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }
        /// <summary>
        /// method to get assembly company
        /// </summary>
        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        /// <summary>
        /// method to get assembly copyright
        /// </summary>
        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }
    }
}
