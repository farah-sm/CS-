using System;
using System.Drawing;

namespace BookAHotel
{
	public interface IHotelCustomer
	{
		// Here we create the interface method without with the functionality
        // of Listing all available Rooms, taking the wanted booking and the room size as parameters
		void ListAvailableRooms(Booking wantedBooking, Size roomSize);

        // Here again we create the interface method without the functionality
        // of Listing all available Rooms, taking the wanted booking and the room size as parameters
        // as well as the maximum price. We also deemonstrate the use of method overloading
        // with the same naming convention for two methods

        void ListAvailableRooms(Booking wantedBooking, Size roomSize, int maxPrice);

        // Here we create the interface method without declring the 
        bool BookRoom(int roomNumber, Booking wantedBooking);


    }
}

