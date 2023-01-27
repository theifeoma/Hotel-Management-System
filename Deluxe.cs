using System;
namespace Hotel
{
	public class Deluxe : Room
	{
		private int balconySize;
		private string view;

		public Deluxe(int number, int floor, Size roomSize, int price, int balconySize, string view)
			:base(number, floor, roomSize, price)
		{
			this.balconySize = balconySize;
			this.view = view;
		}

		public void SetBalconySize(int balconySize)
		{
            this.balconySize = balconySize;
        }

		public void SetView(string view)
		{
            this.view = view;
        }

		public int GetBalconySize()
		{
			return balconySize;
		}

		public string GetView()
		{
			return view;
		}

        public override string ToString()
        {
            return $"Balcony size: {GetBalconySize()}\n" +
				$"View: {GetView()}";
        }

   //     public override void Display()
   //     {
			//base.Display();
   //         Console.WriteLine($"Room Balcony Size: " + GetBalconySize());
			//Console.WriteLine($"Room View: " + GetView());
   //     }
    }
}

