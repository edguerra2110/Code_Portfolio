//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 5 - Experience using dictionary and linq class
//	File Name:		GameForm.cs
//	Description:	A game that makes you pick a capital based on the random state shown. It also grades you based on your choices.
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
using System.IO;
using Project1;
using Utils;

namespace _2210_001_GuerraEdgar_Project5
{
    /// <summary>
    /// class that contains the game for this project
    /// </summary>
    public partial class GameForm : Form
    {
        private static SortedDictionary<string, string> StateDictionary = new SortedDictionary<string, string>();//stores the states
        private static int TimerNumber = 20;// set to reset timer
        private static Random r = new Random();// will be used to determine the random states
        private static string[] StateFile = new string[50];//creates an array for the state files
        private static int NumCorrect = 0;// variable for number correct
        private static int NumAttempts = 0;// variable for number of attempts
        private static double PercentScore = 0.00;// variable to calculate percent score

        /// <summary>
        /// constructor for the Gameform
        /// </summary>
        public GameForm()
        {
            InitializeComponent();
            //open the txt data file
            Text txt = new Text("..\\..\\Resources\\State Data\\states.txt");
            txt.ReadFile();
            // tokenize data by , and space then add it to the dictionary
            for (int i = 0; i < txt.OriginalTxtList.Count; i++)
            {
                List<String> Token = new List<string>();
                Token.Clear();
                String work = txt.OriginalTxtList[i].Trim(" \t".ToCharArray()); //removes spaces in front of the string original and puts it in the work variable
                var delimiters = ",";
                while (!String.IsNullOrEmpty(work)) // loops through the work string until there is no string left
                {
                    work = work.Trim(" \t".ToCharArray());

                    int Col = work.IndexOfAny(delimiters.ToCharArray()); // searches for the index of the first delimiter in the sentence and saves it as an int

                    if (Col == -1) // if there are no delimiters 
                    {
                        Token.Add(work);// add the rest of the string as a token
                        work = work.Remove(0, work.Length);
                    }

                    else if (Col == 0) // if Col is 0 then the delimiter is in the first thing in the string
                    {
                        work = work.Remove(0, 1);// remove the substring from work
                    }

                    else  // if there are delimiters and the delimiter isn't in index 0
                    {
                        Token.Add(work.Substring(0, Col));// add a substring of work into Token from index 0 to Col which adds the first token.

                        work = work.Remove(0, Col); // removes token from string
                    }
                    
                    
                }
                Token.TrimExcess();
                StateDictionary.Add(Token[1], Token[0]);// adds to the dictionary
            }
            var StatDicValue = StateDictionary.Values.ToList();
            listBox1.DataSource = StatDicValue;
            //create an array of size 50 with all the file paths of the images in the array
            var currentDir = "..\\..\\Resources\\State Pictures";
            var files = from file in Directory.GetFiles(currentDir)
                        orderby file
                        select file;
            StateFile = files.ToArray();
            //create a random class from 0 to 49 to select a random state based on the index

        }

        /// <summary>
        /// Timer expired, so the users turn ends
        /// </summary>
        /// <param name="sender">timer</param>
        /// <param name="e">timer ended</param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerNumber--;
            this.TimerTB.Text = TimerNumber.ToString();
            if (TimerNumber==0)
            {
                this.timer1.Enabled = false;
                this.listBox1.Enabled = false;
            }
        }

        /// <summary>
        /// user selected a capital
        /// </summary>
        /// <param name="sender">list box</param>
        /// <param name="e">item was selected</param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            this.listBox1.Enabled = false;
            //compare the user's choice to the value of the index
            string TKEY = "";
            foreach (var item in StateDictionary)// loop through dictionary
            {
                if (item.Value == this.listBox1.SelectedItem.ToString())// if items are equal
                {
                    TKEY = item.Key;
                }
            }

            if (TKEY.Contains(" ") == true) // Check if the key contains a space. If it does, then erase it.
            {
                var hasSpace = TKEY.IndexOf(" ");
                TKEY = TKEY.Remove(hasSpace, 1);
            }

            if (NumAttempts != 0) // if it is not the first attempt
            {
                if (this.StatePic.ImageLocation == $"..\\..\\Resources\\State Pictures\\{TKEY}State.jpg") // if the image location matches the selection
                {
                    MessageBox.Show("Correct");
                    NumCorrect++;
                }
                else // else it's wrong
                {
                    MessageBox.Show("Incorrect");
                   
                }
            }
            // set correct and attempts
            this.CorrectTXTB.Text = NumCorrect.ToString();
            this.AttemptsTXTB.Text = NumAttempts.ToString();


        }

        /// <summary>
        /// Next button was clicked, so we generate a new state picture based on the random state selected
        /// </summary>
        /// <param name="sender">next button</param>
        /// <param name="e">button was clicked</param>
        private void NextQSTNBTN_Click(object sender, EventArgs e)
        {
            this.TimerTB.Text = TimerNumber.ToString();//set timer on screen
            NumAttempts++;// add number of attempts
            var RandState = r.Next(0, 50);//select a number 0-50
            var stateList =  StateDictionary.Keys.ToList();//make the keys a list
            TimerNumber = 20;// reset timer to 20 sec
            this.StateNameTB.Text = stateList[RandState];// set state name based on index
            StatePic.ImageLocation = StateFile[RandState];//set state picture based on index of random number
            this.CorrectTXTB.Text = NumCorrect.ToString();// set correct text box
            this.AttemptsTXTB.Text = NumAttempts.ToString();// set number of attempts text box
            this.timer1.Enabled = true; // set timer to true
            this.listBox1.Enabled = true;// enable the list of capitals
        }

        /// <summary>
        /// the user ends the game
        /// </summary>
        /// <param name="sender">end button</param>
        /// <param name="e">was clicked</param>
        private void EndGameBTN_Click(object sender, EventArgs e)
        {
            this.Close();// close the game
        }

        /// <summary>
        /// if the game form was closed
        /// </summary>
        /// <param name="sender">game form closed</param>
        /// <param name="e">closed</param>
        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if num attempts is not 0
            if (NumAttempts!=0)
            {
                PercentScore =((double)NumCorrect / (double)NumAttempts)*100;// solve for the percent score
            }
            MessageBox.Show($"Thank you for trying your luck at the State Capital Matching Game.\n\nYour score was {PercentScore}% on {NumAttempts} attempts.");// display message box
        }
    }
}
