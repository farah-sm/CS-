using System.Diagnostics.Metrics;
using System;

namespace BookAHotel
{
	public class Booking : IOverlappable
    {

        // Here is the attributes to the Hotel room reservation
		DateTime inCheck;
        DateTime outCheck;

        // Here is the constructor to the Hotel room reservation, it takes 
        // in as parameters the dates the user will check in and check out
        public Booking(DateTime inCheck, DateTime outCheck)
		{
            this.inCheck = inCheck;
            this.outCheck = outCheck;

        }


        

        // This method will return the date the user checked in
        public DateTime getOutCheck()
        {
            return outCheck.Date;
        }

        // This method will return the date the user checked out
        public DateTime getInCheck()
        {
            return inCheck.Date;
        }

        // This method will check if the dates match up by implementing a boolean
        // it checks if the dates checked out is greater than the dates checked in
        // it returns the relevant true or false.
        public bool Overlap(Booking other)
        {


            if (other.getOutCheck() > this.getInCheck() && other.getInCheck() < this.getOutCheck())
            {
                return true;
            }
            return false;


        }


        // This method simply prints the dates so we can use it as part of the
        // user interface
        public String infoPrint()
        {
            return "Date checked In: " + this.getInCheck() + ",    Date Checked Out: " + this.getOutCheck();


        }

    }
}

