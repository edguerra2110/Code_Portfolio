//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 3 - Experience using Stacks
//	File Name:		Utility.cs
//	Description:	This class contains only static methods that may be useful beyond this project.  
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
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Console;
using Project1;


namespace Utils 
{
    /// <summary>
    /// contains only static methods that may be useful beyond this project.
    /// </summary>
    static class Utility
    {
        

        /// <summary>
        /// The method parses an input string into its individual tokens (words, numbers, punctuation marks, and so forth).  Although a space is used in the delimiters, it is not saved.
        /// </summary>
        /// <param name="original">Original String to be split into a List</param>
        /// <param name="delimiters">add delimiters INCLUDING space to this string</param>
        /// <returns>List<string> of the string original</returns>
        #region Tokenizer method 
        public static List<String> Tokenize(string original, string delimiters)
        {

            List<String> Token = new List<string>();

            String work = original.Trim(" \t".ToCharArray()); //removes spaces in front of string original and puts it in the work variable
            while (!String.IsNullOrEmpty(work)) // loops through the work string until there is no string left.
            {
                work = work.Trim(" \t".ToCharArray());
                
                int Col = work.IndexOfAny(delimiters.ToCharArray()); // searches for index of first delimiter in the sentence and saves it as an int.
                
                if (Col == -1) // if there are no delimiters 
                {
                    Token.Add(work);// add rest of string as token
                    work = work.Remove(0, work.Length);
                }
                
                else if (Col == 0) // if Col is 0 then the delimiter is in the first thing in the string
                {
                    Token.Add(work.Substring(0, Col + 1)); // add a substring of work into token from index 0 to Col+1
                    work = work.Remove(0, 1);// remove the substring from work.
                }
                
                else  // if there are delimiters and the delimiter isn't in index 0
                {
                    Token.Add(work.Substring(0, Col));// add a substring of work into Token from index 0 to Col which adds the first token.

                    work = work.Remove(0, Col); // removes token from string
                }

               
            }
               
            return Token;

            
        }
        #endregion

        #region Reverse String
        /// <summary>
        /// Reverses a string.
        /// </summary>
        /// <param name="myString">string that you would like to have reversed</param>
        /// <returns>myString reversed</returns>
        public static string Reverse(string myString)
        {
            char[] charArray = myString.ToCharArray();//converts a string to char array and saves it to charArray
            Array.Reverse(charArray);// reverses the charArray 
            return new string(charArray);// converts the charArray to string returning myString backwards
        }
        #endregion

        /// <summary>
        /// Gives user a welcome message on console when called
        /// </summary>
        /// <param name="msg">Desired msg to output</param>
        #region Welcom Messege
        public static void WelcomMessage(string msg)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            
            Console.SetCursorPosition((Console.WindowWidth - msg.Length) / 2,8);

            Console.WriteLine($"{msg}");  
        }
        #endregion

     

      
    }

}

