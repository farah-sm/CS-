using System;
namespace BookAHotel
{
	public interface IHotelManager
	{
        // Here the Manager is able to add a new room to the booking system.
        // The system does not allow duplicate entries
        bool AddRoom(Room room);


        // Here the Manager is able to to delete a room identified by roomNumber from the system.
        // This method also displays a message with the information of the
        // room that has been deleted
        bool DeleteRoom(int roomNumber);


        // Here the manager is able to print all the rooms in the system; for each room,
        // information specific to the type of room has to be displayed,
        // together with the associated bookings.
        void ListRooms();



        // Similar to ListRooms, this function is ordered in descending order according
        // to the room price per night
        void ListRoomsOrderedByPrice();



        // Here the manager is ablet to save in a text file the information on
        // all the rooms existing in the system, together with their complete
        // related information.
        void GenerateReport(string fileName);

    }
}