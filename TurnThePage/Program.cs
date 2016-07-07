using FinchAPI;
using System;

namespace Resource_Finch_StarterSolution
{
    class Program
    {
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
