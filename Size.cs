using System;
namespace Hotel
{
	public class Size
	{
		private string roomSize;

		public Size(string roomSize)
		{
			this.roomSize = roomSize;
		}

		public void SetSize(string roomSize)
		{
            this.roomSize = roomSize;
        }

		public string GetSize()
		{
			return roomSize;
		}

		public override string ToString()
		{
			return $"Size: {roomSize}";
		}
	}
}

