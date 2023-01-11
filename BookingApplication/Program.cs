using System.Linq.Expressions;
using System.Numerics;
using System.Drawing;
using System.Linq.Expressions;
using System.Numerics;
using System.Globalization;

namespace BookAHotel
{
    public static class BookAHotelRoom
    {
        public static void Main(String[] args)
        {
            // Here the insatntiation of the hotel takes place
            WestminsterHotel guestHouse = new WestminsterHotel();

            // The value of the variable exited is hard coded as false
            bool customerInterface = true;


            // This is the "name" variable being declared
            string name;

            // Here we welcome the user to the application
            Console.Write("Hello, Welcome to our Booking application. \nWhat's your name: ");
            // Here we store the value of the name the user stores 
            name = Console.ReadLine();


            // Here we design the User Interface with a series of questions to the user
            
            while (customerInterface == true)
            {
                // Here we have a number of questions that are used to navigate the users needs
                Console.WriteLine("\n");
                Console.WriteLine("★━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━★");
                Console.WriteLine($"\nReally nice to have you {name}, Welcome to our booking application");
                Console.WriteLine($"{name}'s App: \n");
                Console.WriteLine("1. All Available Rooms");
                Console.WriteLine("2. All Available Rooms with their Relevant Costs");
                Console.WriteLine("3. Book a hotel room");
                Console.WriteLine("4. Administrator Access");
                Console.WriteLine("5. Leave\n");
                Console.WriteLine("Please select an option (enter only the relevant number that coincides with your selection):\n");
                int option = Convert.ToInt32(Console.ReadLine());

                // below we implement switch statements
                switch (option)
                {

                    case 1:
                        // if user selects 1 we redirect the user to the queryForSize method
                        // which lists all of the available rooms
                        Size size = queryForSize();
                        Booking booking = queryForBooking();

                        if (booking == null)
                        {
                            continue;
                        }


                        Console.WriteLine("Rooms available:");
                        guestHouse.ListAvailableRooms(booking, size);
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        // if user selects 2 we redirect the user to the queryForBooking method
                        // which lists all of the available rooms with their relevant costs
                        size = queryForSize();
                         booking = queryForBooking();

                        if (booking == null)
                        {
                            continue;
                        }

                        Console.WriteLine("Type your maximum desired cost:\n");
                        int maxPrice = Convert.ToInt32(Console.ReadLine());


                        Console.WriteLine("Rooms available:");
                        guestHouse.ListAvailableRooms(booking, size, maxPrice);
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        // if user selects 3 we redirect the user to the BookRoom method
                        // which takes the user to book a room
                        Console.WriteLine("Type the number of the desired room you would like to book:\n");
                        int roomNo = Convert.ToInt32(Console.ReadLine());

                        booking = queryForBooking();

                        if (booking == null)
                        {
                            continue;
                        }

                        guestHouse.BookRoom(roomNo, booking);
                        break;
                    // Need to fix this case
                    case 4:
                        // if user selects 4 we redirect the user to the managerMenu method
                        // which takes the user to the administrater User interface
                        managerMenu(guestHouse);
                        break;
                        
                    case 5:
                        // if the user selects 5, the program closes
                        Console.WriteLine($"Good-Bye {name}!");
                        return;
                        
                }

            }
            
        }

        // Here we have the managerial menu, where the options are different to the
        // user interface
        public static void managerMenu(WestminsterHotel guestHouse)
        {
            int adminInterface = 1;
            
                do
                {
                    Console.WriteLine("Managerial Menu: \n");
                    Console.WriteLine("1. To add a room");
                    Console.WriteLine("2. Deletion of a Room");
                    Console.WriteLine("3. To list all rooms");
                    Console.WriteLine("4. To List all rooms including their prices");
                    Console.WriteLine("5. To compile a report");
                    Console.WriteLine("6. Return back to the Customer Users Interface\n");
                    Console.WriteLine("Be sure to select an option (only enter the number):\n");
                    int option = Convert.ToInt32(Console.ReadLine());

                    if (option == 1)
                    {
                        // if user selects 1 we redirect the admin to input
                        // further detalis in order to assist in adding a room
                        Console.WriteLine("Enter the number of the room:\n");
                        int roomNo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter the floor number of the room:\n");
                        int roomFloor = Convert.ToInt32(Console.ReadLine());

                        Size size = queryForSize();

                        Console.WriteLine("Enter the cost of the Room (only digits):\n");
                        int cost = Convert.ToInt32(Console.ReadLine());

                        bool appendedRoom = false;


                        // more from the UI
                        Console.WriteLine(" Select the type of room (enter only the number):\n");
                        Console.WriteLine("1. Standard Room");
                        Console.WriteLine("2. Deluxe Room");
                        int typeOfRoom = Convert.ToInt32(Console.ReadLine());

                        // If statement if the user selects "Standard Room (option 1)"
                        if (typeOfRoom == 1)
                        {
                            Console.WriteLine("Enter the number of windows (with a minimum of 1):\n");
                            int windows = Convert.ToInt32(Console.ReadLine());
                            if (windows < 1)
                            {
                                Console.WriteLine("Enter atleast 1");
                                break;
                            }
                            Room standardRoom = new StandardRoom(roomNo, roomFloor, size, cost, windows);

                            appendedRoom = guestHouse.AddRoom(standardRoom);
                        }
                        // If statement if the user selects "Deluxe Room (option 2)"
                        else if (typeOfRoom == 2)
                        {

                            Console.WriteLine("Enter the Square meter of the balcony:\n");
                            Double balcony = Convert.ToDouble(Console.ReadLine());
                            View visibility = askForView();

                            Room deluxeRoom = new DeluxeRoom(roomNo, roomFloor, size, cost, balcony, visibility);

                            appendedRoom = guestHouse.AddRoom(deluxeRoom);

                        }
                        // If the user inputs any option other than the 1 or 2,
                        // we will return them back to the option
                        else
                        {
                            Console.WriteLine("Enter either '1' or '2'.\n");
                            break;
                        }

                        if (appendedRoom)
                        {
                            Console.WriteLine("Well done, you have added a room\n");
                        }
                        else
                        {
                            Console.WriteLine("Duplicate found. Room not added.\n");
                        }
                        break;

                    }
                    else if (option == 2)
                    {
                        // if the admin selects 2 we redirect the admin to input
                        // further detalis in order to assist in deleting a room
                        Console.WriteLine("Enter your room number:\n");
                        int roomToDelete = Convert.ToInt32(Console.ReadLine());

                        if (guestHouse.DeleteRoom(roomToDelete))
                        {
                            Console.WriteLine("Great Job! Room has successfully been deleted! \n");
                        }
                        else
                        {
                            Console.WriteLine("Unfortunately your room has not been made. \n");
                        }
                        break;
                    }
                    else if (option == 3)
                    {
                        // if the admin selects 3 we display all available rooms
                        guestHouse.ListRooms();
                        break;
                    }
                    else if (option == 4)
                    {
                        // if the admin selects 3 we display all available rooms with their relevant costs
                        guestHouse.ListRoomsOrderedByPrice();
                        break;
                    }
                    else if (option == 5)
                    {
                        // if the admin selects 5 we redirect the admin to input
                        // a name to save the file as a report
                        Console.WriteLine("Enter a name to save this as a file:\n");
                        String filename = Console.ReadLine();
                        guestHouse.GenerateReport(filename);
                        break;
                    }
                    else if (option == 6)
                    {
                        // if the admin selects 6 we redirect the admin to input
                        // further detalis in order to assist in deleting a room
                        adminInterface = 2;
                        break;
                    }
                    else
                    {
                        // This option is displayed by default if the admin does not
                        // select the correct options
                        Console.WriteLine("Only enter an option ranging from 1-6");
                        break;
                    }

                }
                // condition for do while loop
                while (adminInterface == 1);

        }

        // Here is the method for querying the size of the room
        public static Size queryForSize()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Size of the Room:");
            Console.WriteLine("1. Single Bed");
            Console.WriteLine("2. Double Bed");
            Console.WriteLine("3. Triple Bed\n");
            Console.WriteLine("Select an option (enter only the number):\n");
            int numberOfSize = Convert.ToInt32(Console.ReadLine());
            Size size = Size.Single;

            // switch statement that navigates the user to the relevant option
            switch (numberOfSize)
            {
                case 2:
                    size = Size.Double;
                    break;
                case 3:
                    size = Size.Triple;
                    break;
            }
            return size;


        }

        // Here is the method for querying reservation (booking) dates
        public static Booking queryForBooking()
        {
            DateTime dateCheckIn = requestDate("Enter your preferred check-in date (in format DD/MM/YYYY):");
            DateTime dateCheckOut = requestDate("Hey you've input the date iin the wrong format. Now enter your check-out as: DD/MM/YYYY:");
            Console.WriteLine("\n");
            // Here we check to see if the checkout date is earlier than the check in date, causing an error 

            switch (dateCheckOut <= dateCheckIn)
            {
                case true:
                    Console.WriteLine("Please enter a check-out date that is later than the check-in date.\n");
                    break;
            }

            return new Booking(dateCheckIn, dateCheckOut);

        }

        // Here is the method for organising the date
        public static DateTime requestDate(String memo)
        {
            Console.WriteLine("\n");
            Console.WriteLine(memo);
            String stringDate = Console.ReadLine() ?? "Empty";
            DateTime parsedDate = DateTime.Parse(stringDate, new CultureInfo("en-GB"));
            return parsedDate;

        }

        // Here is the method for requesting from the user which type of view they would like
        public static View askForView()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Field of Vision (View):");
            Console.WriteLine("1. Sea View");
            Console.WriteLine("2. Landmark View");
            Console.WriteLine("3. Mountain View\n");
            Console.WriteLine("Select an option (enter only the number):\n");
            int numberOfView = Convert.ToInt32(Console.ReadLine());
            View visibiility = View.SeaView;


            // switch statement that navigates the user to the relevant option
            switch (numberOfView)
            {

                case 2:
                    visibiility = View.LandmarkView;
                    break;
                case 3:
                    visibiility = View.MountainView;
                    break;

            }
            return visibiility;

            

        }
    }
}
