using System;
namespace BookAHotel
{
	public class StandardRoom : Room
	{

        // Here we declare our attribute, we have integar of the number of windows
		private int windows;


        // Here we have in place our Standard Room Constructor so that these can be called from a different class.
        public StandardRoom(int number, int floor, Size size, int cost, int windows) : base(number, floor, size, cost)
        {
            this.windows = windows;

        }


        // This method simply prints the Room details so we can use it as part of the
        // user interface
        // We also utilize the override ability for this method
        public override string infoOfRoom()
        {
            return base.infoOfRoom() + ", RoomType = Standard, Windows = " + this.getWindows();

        }


        // This method will return the number of windows in the given room  
        public int getWindows()
        {
            return this.windows;
        }

    }
}

