using System;

namespace Hotel
{
	public class Booking : IOverlappable
	{
		private DateTime checkIn;
		private DateTime checkOut;
		private int roomNumber;

		public Booking(DateTime checkIn, DateTime checkOut)
		{
			this.checkIn = checkIn;
			this.checkOut = checkOut;
		}

        public Booking(int roomNumber,DateTime checkIn, DateTime checkOut)
        {
            this.roomNumber = roomNumber;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
        }

        public void SetRoomNumber(int roomNumber)
        {
            this.roomNumber = roomNumber;
        }

        public int GetRoomNumber()
        {
            return roomNumber;
        }

        public DateTime GetCheckIn()
		{
			return checkIn;
		}

        public DateTime GetCheckOut()
        {
            return checkOut;
        }


		public bool Overlaps(Booking other)
		{
			//checks for if check in is less than the current booking check out and if current check booking check in is less than check out
            return checkIn < other.checkOut && other.checkIn < checkOut;
        }

        public void Display()
        {
            Console.WriteLine($"Check In Date: " + GetCheckIn());
            Console.WriteLine($"Check Out Date: " + GetCheckOut());
            //return $"{roomNumber} {checkIn} {checkOut}";
        }

    }
}

