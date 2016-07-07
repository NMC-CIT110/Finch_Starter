using FinchAPI;
using System;

namespace Resource_Finch_StarterSolution
{
    class Program
    {
        // *************************************************************
        // Application:     Finch Starter Solution
        // Author:          Velis, John E
        // Date Created:    5/20/2016
        // Date Revised:    7/7/2016
        // *************************************************************

        static void Main(string[] args)
        {
            //
            // create a new Finch object
            //
            Finch myFinch;
            myFinch = new Finch();

            //
            // call the connect method
            //
            myFinch.connect();
            
            //
            // begin your code
            //

            //
            //end of your code
            //

            //
            // call the disconnect method
            //
            myFinch.disConnect();
        }
    }
}
