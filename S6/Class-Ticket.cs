using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsProject
{
     class Ticket
    {
        private int ticketNumber;
        private static int ticketsSold = 0;


        public Ticket()
        {
            ticketsSold++;


            ticketNumber = ticketsSold;

        }

       public int GetNumberSold()
        {
            return ticketsSold;
        }

        public int GetTicketNumber()
        {
            return ticketNumber; 
        }

        public void PrintInfo()
        {
            Console.Write($"Ticket Number: {ticketNumber}");
            Console.Write($"Ticket Number: {ticketsSold}");
        }

    }
}
