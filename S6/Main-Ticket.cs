using System;
using System.Net.Sockets;

namespace TicketsProject
{
    class Tickets
    {
        static void Main(string[] args)
        {
            Ticket t1 = new Ticket();
            Console.WriteLine("Ticket number: " + t1.GetTicketNumber());
            Console.WriteLine("Tickets sold: " + t1.GetNumberSold());
            Ticket t2 = new Ticket();
            Console.WriteLine("Ticket number: " + t2.GetTicketNumber());
            Console.WriteLine("Tickets sold: " + t2.GetNumberSold());
            Console.WriteLine("Ticket number: " + t1.GetTicketNumber());
            Console.WriteLine("Tickets sold: " + t1.GetNumberSold());
            Ticket t3 = new Ticket();
            t3.PrintInfo();
        }
    }
}
