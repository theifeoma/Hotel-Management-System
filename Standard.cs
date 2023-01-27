using System;
using System.Diagnostics;
using System.Drawing;

namespace Hotel
{
	public class Standard : Room
    {
        private int window;

        public Standard(int number, int floor, Size roomSize, int price, int window)
			:base(number, floor, roomSize, price)
		{
			this.window = window;
		}

		public int GetRoomWindow()
		{
			return window;
		}
        public override string ToString()
        {
            return $"Window: {GetRoomWindow()}";
        }

   //     public override void Display()
   //     {
			//base.Display();
   //         Console.WriteLine($"Room Windows: " + GetRoomWindow());
   //     }
    }

}

