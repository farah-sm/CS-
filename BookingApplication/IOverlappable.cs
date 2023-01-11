using System;
namespace BookAHotel
{
	public interface IOverlappable
	{

        // Here this method is checking whether two Booking objects overlap
        bool Overlap(Booking other);

    }
}

