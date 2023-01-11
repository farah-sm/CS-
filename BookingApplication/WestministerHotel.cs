using System;
using System.Collections.Generic;
using System.Drawing;

namespace BookAHotel
{
	public class WestminsterHotel : IHotelManager, IHotelCustomer
    {
        // Key is Room Number and value is the Room object.
        private Dictionary<int, Room> roomsDict;


        // Here the user is able to book a new room to the booking system.
        // The system does not allow duplicate entries therefore runs a check initally
        public bool BookRoom(int roomNumber, Booking wantedBooking)
        {
            if (!roomsDict.ContainsKey(roomNumber))
            {
                return false;
            }

            Room room = roomsDict[roomNumber];

            return room.addBooking(wantedBooking);


        }

        // Here the Manager is able to add a new room to the booking system.
        // The system does not allow duplicate entries
        public bool AddRoom(Room room)
        {


            if (!roomsDict.ContainsKey(room.getNumber()))
            {
                roomsDict.Add(room.getNumber(), room);
                return true;
            }
            return false;

        }


        // Here the Manager is able to to delete a room identified by roomNumber from the system.
        // This method also displays a message with the information of the
        // room that has been deleted
        public bool DeleteRoom(int roomNumber)
        {
            return roomsDict.Remove(roomNumber);
        }



        //Herre is where the room objects are being instanciated
        public WestminsterHotel()
        {
            roomsDict = new Dictionary<int, Room>();

            this.AddRoom(new StandardRoom(1, 1, Size.Single, 15, 10));
            this.AddRoom(new StandardRoom(2, 1, Size.Double, 20, 5));
            this.AddRoom(new DeluxeRoom(3, 2, Size.Double, 25, 5.5, View.SeaView));
            this.AddRoom(new DeluxeRoom(4, 2, Size.Triple, 35, 10.2, View.MountainView));

        }


        // Similar to ListRooms, this function is ordered in descending order according
        // to the room price per night
        public void ListAvailableRooms(Booking wantedBooking, Size roomSize, int maxPrice)
        {
            List<Room> roomsList = roomsDict.Values.ToList();
            // Sorts Ascending.
            roomsList.Sort((x, y) => x.getCost().CompareTo(y.getCost()));

            for (int i = 0; i < roomsList.Count; i++)
            {
                Room room = roomsList[i];
                if (room.getSize() != roomSize || room.getCost() >= maxPrice || room.checkIfBookingOverlaps(wantedBooking))
                {
                    continue;
                }
                Console.WriteLine(room.infoOfRoom());
            }
        }


        // Here the manager is able to print all the rooms in the system; for each room,
        // information specific to the type of room has to be displayed,
        // together with the associated bookings.
        public void ListAvailableRooms(Booking wantedBooking, Size roomSize)
        {
            List<Room> roomsList = roomsDict.Values.ToList();
            int counter = 0;
            for (int i = 0; i < roomsList.Count; i++)
            {
                Room room = roomsList[i];
                if (room.getSize() != roomSize || room.checkIfBookingOverlaps(wantedBooking))
                {
                    continue;
                }
                Console.WriteLine(room.infoOfRoom());
                counter=counter+1;
            }

            switch (counter)
            {
                case 0:
                Console.WriteLine("Rooms are unavailable.");
                break;
            }

        }

        
        // Similar to ListRooms, this function is ordered in descending order according
        // to the room price per night
        public void ListRoomsOrderedByPrice()
        {
            List<Room> roomsList = roomsDict.Values.ToList();
            roomsList.Sort();

            for (int i = 0; i < roomsList.Count; i++)
            {
                Room room = roomsList[i];
                Console.WriteLine(room.infoOfRoom());
                Console.WriteLine(room.bookingInfoString());
            }

        }


        // Here the manager is able to save in a text file the information on
        // all the rooms existing in the system, together with their complete
        // related information.
        public void GenerateReport(string fileName)
        {
            List<Room> roomsList = roomsDict.Values.ToList();

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            Console.WriteLine(path);

            fileName = path + "/" + fileName + ".txt";

            using (StreamWriter sw = File.AppendText(fileName))
            {

                //for(int i=0; i > roomsList.Count; i++ )
                //{
                //    sw.WriteLine(i.infoOfRoom());
                //    sw.WriteLine(i.bookingInfoString());
                //}

                for (int i = 0; i < roomsList.Count; i++)
                {
                    Room? room = roomsList[i];
                    sw.WriteLine(room.infoOfRoom());
                    sw.WriteLine(room.bookingInfoString());
                }
            }
        }


        // Here the manager is able to print all the rooms in the system; for each room,
        // information specific to the type of room has to be displayed,
        // together with the associated bookings.
        public void ListRooms()
        {
            List<Room> roomsList = roomsDict.Values.ToList();

            for (int i = 0; i < roomsList.Count; i++)
            {
                Room? room = roomsList[i];
                Console.WriteLine(room.infoOfRoom());
                Console.WriteLine(room.bookingInfoString());
            }
        }

        

    }
}

