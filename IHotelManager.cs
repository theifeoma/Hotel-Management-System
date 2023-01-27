using System;

namespace Hotel
{

	public interface IHotelManager
	{

		bool AddRoom(Room room);

		bool DeleteRoom(int roomNumber);

		void ListRooms();

		void ListRoomsOrderedByPrice();

		void GenerateReport(string fileName);
	}
}
