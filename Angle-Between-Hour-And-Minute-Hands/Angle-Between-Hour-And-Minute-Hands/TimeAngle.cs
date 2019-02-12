using System;

namespace Angle_Between_Hour_And_Minute_Hands
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //The following calls on the method and finds the difference between
            //the angles of the hands at 01:15
            Console.WriteLine(TimeAngle(1, 15));
            //we include the readykey value to keep the console window open after 
            //our program runs.
            Console.ReadKey();
        }
        public static int TimeAngle(int hr, int min)

        {
            //First we list all of the varriables that we will be using
            //The value of the hour and minutes will be determined by their actual value, 
            //not their position on the clock
            int x = hr, y = min, hAngle = (x * 30), mAngle = (y * 6), angleDiff;
            // We assign hAngle and mAngles because each of the possible values on the clock 
            // provide an angle measured off of the "Zero hour" at 12. 
            angleDiff = (hAngle > mAngle) ? hAngle - mAngle : mAngle - hAngle;
            // we use a boolean to determine which value will be subtracted from the other
            //because we do not want a negative angle. 
            return angleDiff;
            //we then return the difference between the angles. 


        }

        // Below is the code without comments in between lines.
     
        //  public static int TimeAngle(int hr, int min)
        //  {
        //      int x = hr, y = min, hAngle = (x * 30), mAngle = (y * 6), angleDiff;
        //      angleDiff = (hAngle > mAngle) ? hAngle - mAngle : mAngle - hAngle;
        //      return angleDiff;
        //  }
    }
}
