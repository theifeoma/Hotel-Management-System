using System;
namespace Hotel
{
	public interface IOverlappable
	{
		bool Overlaps(Booking other);
	}
}
