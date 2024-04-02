//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:			Project 3 - Tower of Hanoi
//	File Name:		MainForm.cs
//	Description:		this class is the Main form where most of the game will be played
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

namespace Project3
{
    
    /// <summary>
    /// main form that lets the user go through the tower of Hanoi by clicking the next button
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class MainForm : Form
    {
        public static int counter = 0;// this will check how many moves are remaining.
        Tower hanoi;// this is the tower class named hanoi it will hold the poles and disks 
        public static int gameStep = 0;// what step we are on

        /// <summary>
        /// The constructor for the MainForm form
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            
        }
        /// <summary>
        /// a recursive algorithm that pushes disks into the correct poles using the rules of the tower of Hanoi game.
        /// </summary>
        /// <param name="totalDisks">The total disks number of disks to move.</param>
        /// <param name="totalMoves">The total moves required to win the game.</param>
        /// <param name="startPole">The start pole where the disks will be moved from</param>
        /// <param name="intermediatePole">The intermediate pole that will be used to move disks to and from.</param>
        /// <param name="finalPole">The final pole where the disks will be in order.</param>
        public static void Hanoi(int totalDisks, int totalMoves, Pole startPole, Pole intermediatePole, Pole finalPole)
        {
            if (totalDisks % 2 == 0)// if the total amount of disks is even then switch the order of the rotations
            {
                Pole temp;
                temp = intermediatePole;
                intermediatePole = finalPole;
                finalPole = temp;
            }
            if (totalMoves % 3 == 1) //if is a 1 step
            {
                MoveDisk(startPole, finalPole);// move disk between start pole and final pole
            }
            else if (totalMoves % 3 == 2)//if it is a second step
            {
                MoveDisk(startPole, intermediatePole);// move disk between start pole and intermediate pole
            }
            else if (totalMoves % 3 == 0)//if it is a third step
            {
                MoveDisk(intermediatePole,finalPole);// move disk between intermediate pole and finale pole
            }
            

        }

        /// <summary>
        /// Makes a legal disk move to move the game along.
        /// </summary>
        /// <param name="startPole">The start pole where the disk will be moved from if it is smaller than the disk on the final pole.</param>
        /// <param name="finalPole">The final pole where the disk from start pole will be moved too if it is big enough to hold a smaller disk.</param>
        public static void MoveDisk(Pole startPole, Pole finalPole)
        {
            if (startPole.DiskCount <= 0)// if the start pole is empty
            {
                startPole.PushPole(finalPole.PopPole());//pop the final pole into the start pole
            }
            else if (finalPole.DiskCount <= 0)// if the finale pole is empty
            {
                finalPole.PushPole(startPole.PopPole());//pop the start pole into the final pole
            }
            else if (startPole.PeekPole().DiskSize < finalPole.PeekPole().DiskSize)// if the start pole top disk is smaller than the final pole disk
            {
                finalPole.PushPole(startPole.PopPole());// pop the start pole into the final pole
            }
            else// the final pole disk is smaller than the start pole
            {
                startPole.PushPole(finalPole.PopPole());// pop the finale pole into the start pole
            }

        }

        /// <summary>
        /// The about button was pressed so the about form pops up
        /// </summary>
        /// <param name="sender">about button.</param>
        /// <param name="e">button was pressed so we open the about form</param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.Show();
        }

        /// <summary>
        /// once the next button is clicked then it goes to the next step in algorithm
        /// </summary>
        /// <param name="sender">The next button.</param>
        /// <param name="e">the button gets pressed</param>
        private void NextMoveBtn_Click(object sender, EventArgs e)
        {
            gameStep++; // increase game steps by 1
            Hanoi(hanoi.DiskCount(), gameStep, hanoi.PoleList[0], hanoi.PoleList[1], hanoi.PoleList[2]);// start Hanoi algorithm 
            // populate the towers
            FirstPoleTxtBx.Text = hanoi.PoleList[0].ToString();
            SecondPoleTxtBx.Text = hanoi.PoleList[1].ToString();
            ThirdPoleTxtBx.Text = hanoi.PoleList[2].ToString();
            CurrentMoveInt.Text = gameStep.ToString();// set the current move
            if (gameStep == Convert.ToInt32(hanoi.TotalMovesRequired()))// if it is the last move
            {
                NextMoveBtn.Enabled = false;// disable the button 
                MessageBox.Show("YOU WON! Press restart to start again.");// tells user they won
            }

        }

        /// <summary>
        /// the start button was clicked to indicate the game has started
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (NumDiskTxtBx.Text != string.Empty)
            {
                NextMoveBtn.Enabled = true; // enables next move button
                nextMoveToolStripMenuItem.Enabled = true;// enables next move button in tool strip
                StartBtn.Enabled = false;// disables the start button
                NumDiskTxtBx.Enabled = false;// disables the text box
                startToolStripMenuItem.Enabled = false;// disables the start button in the tool strip
                hanoi = new Tower(Convert.ToDouble(NumDiskTxtBx.Text.ToString()));// creates the tower 
                FirstPoleTxtBx.Text = hanoi.PoleList[0].ToString();// populates the first pole
                CurrentMoveInt.Text = gameStep.ToString();// sets current move
                NumLabel.Text = hanoi.TotalMovesRequired().ToString();// sets total moves
            }
            


        }
        /// <summary>
        /// The start button in the menu strip was clicked
        /// </summary>
        /// <param name="sender">The start button in the menu strip</param>
        /// <param name="e">was clicked</param>
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NumDiskTxtBx.Text != string.Empty)
            {
                NextMoveBtn.Enabled = true; // enables next move button
                nextMoveToolStripMenuItem.Enabled = true;// enables next move button in tool strip
                StartBtn.Enabled = false;// disables the start button
                NumDiskTxtBx.Enabled = false;// disables the text box
                startToolStripMenuItem.Enabled = false;// disables the start button in the tool strip
                hanoi = new Tower(Convert.ToDouble(NumDiskTxtBx.Text.ToString()));// creates the tower 
                FirstPoleTxtBx.Text = hanoi.PoleList[0].ToString();// populates the first pole
                CurrentMoveInt.Text = gameStep.ToString();// sets current move
                NumLabel.Text = hanoi.TotalMovesRequired().ToString();// sets total moves
            }
           
        }

        /// <summary>
        /// closes the program when the quit button is pressed
        /// </summary>
        /// <param name="sender">The quick button</param>
        /// <param name="e">was clicked to close the program</param>
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// restarts the game so the user can input a new amount of disks
        /// </summary>
        /// <param name="sender">the reset button</param>
        /// <param name="e">reset button was pressed</param>
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            NextMoveBtn.Enabled = false;
            nextMoveToolStripMenuItem.Enabled = false;
            StartBtn.Enabled = true;
            NumDiskTxtBx.Enabled = true;
            gameStep = 0; // reset the game steps 
            NumLabel.Text = "0";// reset the amount of turns to 0
            // clears out the text boxes that represent the poles
            FirstPoleTxtBx.Text = "";
            SecondPoleTxtBx.Text = "";
            ThirdPoleTxtBx.Text = "";
            // a message box that explains to the user what to do.
            MessageBox.Show("Please type in a number of disk \nand press 'Start'.");
        }
        /// <summary>
        /// the next move button in the tool strip menu was clicked
        /// </summary>
        /// <param name="sender">tool strip next button.</param>
        /// <param name="e">The button was clicked</param>
        private void nextMoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameStep++; // increase game steps by 1
            Hanoi(hanoi.DiskCount(), gameStep, hanoi.PoleList[0], hanoi.PoleList[1], hanoi.PoleList[2]);// start Hanoi algorithm 
            // populate the towers
            FirstPoleTxtBx.Text = hanoi.PoleList[0].ToString();
            SecondPoleTxtBx.Text = hanoi.PoleList[1].ToString();
            ThirdPoleTxtBx.Text = hanoi.PoleList[2].ToString();
            CurrentMoveInt.Text = gameStep.ToString();// set the current move
            if (gameStep == Convert.ToInt32(hanoi.TotalMovesRequired()))// if it is the last move
            {
                NextMoveBtn.Enabled = false;// disable the button 
                MessageBox.Show("YOU WON! Press restart to start again.");// tells user they won
            }
        }
    }
}
