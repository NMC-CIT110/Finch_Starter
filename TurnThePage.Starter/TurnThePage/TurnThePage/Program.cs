using FinchAPI;
using System;

namespace TurnThePage
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a new Finch object
            Finch myFinch;
            myFinch = new Finch();

            //call the connect method
            myFinch.connect();
            
            //your code goes here


            //end of your code

            //always clean up after yourself
            myFinch.disConnect();
        }
    }
}
