//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:			Project 3 - Tower of Hanoi
//	File Name:		AboutForm.cs
//	Description:		this class holds the about forms information
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
    /// About form class that displays the information about the program
    /// </summary>
    public partial class AboutForm : Form
    {
        /// <summary>
        /// About form constructor that sets up all of the labels and text box for the form
        /// </summary>
        public AboutForm()
        {
            InitializeComponent();
            this.ProductName.Text = AssemblyProduct;// sets product name
            this.Version.Text = String.Format("Version {0}", AssemblyVersion);// sets assembly version
            this.Copyright.Text = AssemblyCopyright;// sets copyright information
            this.AurthourName.Text = AssemblyCompany;// sets Aurthur name
            this.textBoxDescription.Text = AssemblyDescription;// sets text box description
        }
        /// <summary>
        /// Gets the programs version from the assembly so that you can call it in to the form
        /// </summary>
        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        /// <summary>
        /// Gets the programs Description from the assembly so that you can call it in to the form
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
        /// Gets the programs title from the assembly so that you can call it in to the form
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
        /// Gets the programs Copyright information from the assembly so that you can call it in to the form
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

        /// <summary>
        /// Gets the programs Company which was modified to say the developers name from the assembly so that you can call it in to the form
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
        /// if the ok button is pressed from the about page then it closes the form
        /// </summary>
        private void AboutButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
