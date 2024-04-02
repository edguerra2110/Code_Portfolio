//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 3 - Experience using stacks
//	File Name:		Text.cs
//	Description:	Inputs text from a text file, parses it into tokens, and serves the collection of those tokens to other classes that will analyze the text.
//	Course:			CSCI 2210-001 - Data Structures
//	Author:			Edgar Guerra, guerrae@etsu.edu, Department of Computing, East Tennessee State University
//	Created:		Friday, April 24, 2020
//	Copyright:		Edgar Guerra, 2020
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Utils;
using System.Windows.Forms;

namespace Project1
{
    /// <summary>
    /// lets a user open a file through file dialog
    /// </summary>
    public class Text
    {
        List<string> OgList = new List<string>(); // creates string list for ogstring to live in later
        private String FilePath; // saves file path of text
        private String OgString; // saves string from the file

        #region Constructor that can take in a file path
        /// <summary>
        /// Takes a String parameter representing path/file name of the text file to be processed
        /// </summary>
        public Text(String filePath)
        {
            FilePath = filePath;
        }
        /// <summary>
        /// default Constructor
        /// </summary>
        public Text()
        { }
        #endregion

        #region Text String
        /// <summary>
        /// Holds the original string consisting of the entire text from the file
        /// </summary>
        public String OriginalTxtString
        {
            get { return OgString; }
            set {OgString = value;}
        }
        #endregion

        #region Generic String List
        /// <summary>
        /// Represents a Generic string type List of all tokens found in the text.
        /// </summary>
        public List<String> OriginalTxtList
        {
            get { return OgList; }
            private set { OgList = value; }
        }
        #endregion

        #region creates String List
        /// <summary>
        /// Creates a String list from the tokenizer
        /// </summary>
        /// <returns>string list of originaltxtlist</returns>
        public void CreateList()
        {
            
            string strWithTabs = OriginalTxtString;
            OriginalTxtList = Utility.Tokenize(OriginalTxtString, "\n\r");
            OriginalTxtList.TrimExcess();
            for (int i = 0; i < OriginalTxtList.Count; i++)
            {
                OriginalTxtList.Remove("\n");
                OriginalTxtList.Remove("\r");
                OriginalTxtList.TrimExcess();

            }
            

        }
        #endregion

        #region Text File Path
        /// <summary>
        /// Saves Text File Path
        /// </summary>
        /// <returns>String of File Path</returns>
        public String TxtFilePath
        {
            get { return FilePath; }
            set { FilePath = value; }
        }
        #endregion

        #region Get and Save text File Path
        /// <summary>
        /// Uses openfiledialog to get .txt file path
        /// </summary>
        /// <returns>returns file path</returns>
        public void GetFilePath()
        {

            // creates variable for the file name
            String FileName = "";
            // creates an object from openfiledialog
            OpenFileDialog OpenDlg = new OpenFileDialog();
            // filters text files through the file manager
            OpenDlg.Filter = "text files|*.txt;*.text";
            // title of GUI
            OpenDlg.Title = "Select the .txt file";
            // if the dialog isn't canceled
            if (DialogResult.Cancel != OpenDlg.ShowDialog())
            {
                //save file path to FileName
                FileName = OpenDlg.FileName;
            }
            else// if user exits or has an error, then show an error and exit the app
            {
                MessageBox.Show("File Open Canceled By User", "File Open Error");
                Application.Exit();
            }
            TxtFilePath = FileName;
        }
        #endregion

        #region Read File
        /// <summary>
        /// Reads file 
        /// </summary>
        /// <returns>nothing its void</returns>
        public void ReadFile()
        {
            String Data = File.ReadAllText(FilePath);
            OriginalTxtString = Data;
            CreateList();

        }
        #endregion

        #region Manual Data Input
        /// <summary>
        /// Method to manually input String
        /// </summary>
        public void ManualInput() 
        {
            Console.WriteLine("Please type your String below.");
            OriginalTxtString = Console.ReadLine();
        }
        #endregion

       
    }
}