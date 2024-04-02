///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Project 4
//	File Name:         Distribution.cs
//	Description:       Class with distribution methods for statistics.
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

namespace Project4
{
    /// <summary>
    /// Public class to access different distributions
    /// </summary>
    public class Distribution
    {
        /// <summary>
        /// negative exponential code
        /// </summary>
        /// <param name="expectedValue">expected value</param>
        /// <param name="R">random class</param>
        /// <returns>negative exponential of the expected value</returns>
        public static double NegExp(double expectedValue, Random R)
        {   
            return -expectedValue * Math.Log(R.NextDouble(), Math.E);
        }

        /// <summary>
        /// Normal Distribution
        /// </summary>
        /// <param name="expectedValue">expected value</param>
        /// <param name="StdDev"> standard deviation</param>
        /// <param name="R">Random Class</param>
        /// <returns>normal distribution</returns>
        public static double Normal(double expectedValue, double StdDev, Random R)
        {
            double r = Math.Sqrt(-2.0 * Math.Log(R.NextDouble()));
            double Theta = 2.0 * Math.PI * R.NextDouble();
            double Value = r * Math.Sin(Theta);
            return expectedValue + StdDev * Value;
        }

        /// <summary>
        /// Poisson distribution
        /// </summary>
        /// <param name="expectedValue">expect value</param>
        /// <param name="R">Random Class</param>
        /// <returns>Poisson distribution of expected </returns>
        public static int Poisson(double expectedValue, Random R)
        {
            double dLimit = -expectedValue;
            double dSum = Math.Log(R.NextDouble());

            int Count;
            for (Count = 0; dSum > dLimit; Count++)
            {
                dSum += Math.Log(R.NextDouble());
            }
            return Count;
        }

    }
}
