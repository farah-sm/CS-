using System;
namespace BookAHotel
{
	public enum View { SeaView, LandmarkView, MountainView};


    // Once again we use the OOP pillar of inheritance,
    // we will be inheriting from the Rom CLass
    public class DeluxeRoom : Room
	{

        // Below we declare the attributes of this Deluxe Room Class
        // with terrace (the balcony) & visibility (the view)
		private Double balcony;
		private View visibility;


        // Here is the constructor to the Deluxe Room, it takes 
        // in as parameters the (room) number, the size of the room
        // the cost of the room, the terrace & the view
        public DeluxeRoom(int number, int floor, Size size, int cost, Double balcony, View visibility) : base(number, floor, size, cost)
        {
            this.balcony = balcony;
            this.visibility = visibility;

        }


        // This method will return the terrace of the room
        public Double getBalcony()
        {
            return this.balcony;
        }


        // This method will return the visibility  (View) of the room 
        public View getView()
        {
            return this.visibility;
        }



        // This method simply prints the Room details so we can use it as part of the
        // user interface
        // We also utilize the override ability for this method
        public override string infoOfRoom()
        {
            return base.infoOfRoom() + ", RoomType = Deluxe, Balcony size = "
                + this.getBalcony() + "m^2, View = " + this.getView();

        }


        
    }
}

