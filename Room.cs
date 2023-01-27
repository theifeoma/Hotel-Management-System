using System;
using System.Diagnostics;
using System.Drawing;

namespace Hotel
{
	public class Room : IComparable<Room>
	{
		private int roomNumber;
		private int roomFloor;
		private Size roomSize;
        private int roomPrice;
        public List<Booking> bookings { get; set; }

        public Room(int number, int floor, Size roomSize, int price)
		{
			this.roomNumber = number;
			this.roomFloor = floor;
			this.roomSize = roomSize;
			this.roomPrice = price;
            bookings = new List<Booking>();
        }

        public void SetRoomNumber(int roomNumber)
        {
            this.roomNumber = roomNumber;
        }

        public void SetRoomFloor(int roomFloor)
        {
            this.roomFloor = roomFloor;
        }

        public void SetRoomSize(Size roomSize)
        {
            this.roomSize = roomSize;
        }

        public void SetRoomPrice(int roomPrice)
        {
            this.roomPrice = roomPrice;
        }

        public int GetRoomNumber()
		{
			return roomNumber;
		}

		public int GetRoomFloor()
		{
			return roomFloor;
		}

		public Size GetRoomSize()
		{
			return roomSize;
		}

		public int GetRoomPrice()
		{
			return roomPrice;
		}

        public int CompareTo(Room other)
        {
            return GetRoomPrice() - other.GetRoomPrice();
        }

		public bool IsAvailable(Booking wantedBooking)
		{
            //check if room has been booked using IOverlappable
            {
                return !bookings.Any(b => b.Overlaps(wantedBooking));
            }
        }


        public override string ToString()
        {
            return $"Room Number: {GetRoomNumber()}\n" +
                $"Room Floor: {GetRoomFloor()}\n" +
                $"Room Size: {GetRoomSize()}\n" +
                $"Room Price: {GetRoomPrice()}";
        }

  //      public virtual void Display()
		//{
  //          Console.WriteLine($"Room Number: " + GetRoomNumber());
  //          Console.WriteLine($"Room Floor: " + GetRoomFloor());
  //          Console.WriteLine($"Room Size: " + GetRoomSize());
  //          Console.WriteLine($"Room Price: " + GetRoomPrice());
  //      }



	}
}

