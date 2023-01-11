using System;
namespace BookAHotel
{

    // Here we implement the use of enum
    public enum Size
    {
        Single = 0,
        Double = 1,
        Triple = 2
    };

    public class Room : IComparable
    {
        //Attributes of the room
        private List<Booking> booking;
        private int number;
        private int floor;
        private Size size;
        private int cost;

        // This method simply prints the Room details so we can use it as part of the
        // user interface
        public virtual String infoOfRoom()
        {
            String details = "Room Number " + this.getNumber()
                + ", Floor Number" + this.getFloor() + ", Size of the Room = "
                + this.getSize() + ", Cost (per night) = "
                + this.getCost();
            
            return details;
            
        }

        // Below is the constructor for the instantiation of the rooms
        public Room(int number, int floor, Size size, int cost)
        {
            this.number = number;
            this.cost = cost;
            this.floor = floor;
            this.size = size;


            booking = new List<Booking>();
        }

        // This method returns information of the booking
        public String bookingInfoString()
        {
            String infoOfBooking = "Bookings Count: " + this.booking.Count + "\n";
            int counter = 1;

            for (int i = 0; i < booking.Count; i++)
            {
                Booking? booking = this.booking[i];
                infoOfBooking = infoOfBooking + "Booking number " + counter + " =>    " +
                    booking.infoPrint() + "\n";

                counter++;
            }

            return infoOfBooking;

        }
        // Here method initially checks for overlapping booking,
        // if not then proceeds to add booking
        public bool addBooking(Booking wantedBooking)
        {
            if (this.checkIfBookingOverlaps(wantedBooking))
            {
                Console.WriteLine("Sorry overlapped booking... Room not booked");
                return false;
            }

            booking.Add(wantedBooking);
            Console.WriteLine("Room No " + this.getNumber() +
                " from " + wantedBooking.getInCheck()
                + " until " + wantedBooking.getOutCheck() + "\n");
            
            return true;
        }


        // This method we check for overlapping booking
        public bool checkIfBookingOverlaps(Booking wantedBooking)
        {
            for (int i = 0; i < booking.Count; i++)
            {
                Booking? booking = this.booking[i];
                if (wantedBooking.Overlap(booking))
                {
                    return true;
                }
            }
            return false;
        }

        // This method displays the number
		public int getNumber()
		{
			return this.number;
		}

        // This method displays the price of the room
        public int getCost()
        {
            return this.cost;
        }

        // This method displays the floor of the room
        public int getFloor()
        {
            return this.floor;
        }

        // This method displays the size of the room
        public Size getSize()
        {
            return this.size;
        }

      
        public int CompareTo(object? obj)
        {
            Room? room = obj as Room;
            return room.getCost().CompareTo(this.getCost());
        }


        public int CompareTo(Room other)
        {
            return other.getCost().CompareTo(this.getCost());
        }

        


    }
}

