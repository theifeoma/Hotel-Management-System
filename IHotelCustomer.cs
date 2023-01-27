using System;
namespace Hotel
{
	public interface IHotelCustomer
	{
		void ListAvailableRooms(Booking wantedBooking, Size roomSize);
	
		void ListAvailableRooms(Booking wantedBooking, Size roomSize, int maxPrice);
		
		bool BookRoom(int roomNumber, Booking wantedBooking);

    }
}

