using System;
namespace Hotel
{
    public class WestminsterHotel : IHotelCustomer, IHotelManager
    {
        private Dictionary<int, Booking> allbookings;
        private Dictionary<int, Room> allrooms;


        public WestminsterHotel()
        {
            allrooms = new Dictionary<int, Room>();
            allbookings = new Dictionary<int, Booking>();
        }

        public bool AddRoom(Room room)
        {
            //check if there is no duplicate before adding 

            if (!allrooms.ContainsKey(room.GetRoomNumber()))
            {
                return false;
            }

            //adds to the room dictionary the key and value
            else
                allrooms.Add(room.GetRoomNumber(), room);
                return true;
        }

        public bool DeleteRoom(int roomNumber)
        {
            //check if room dictionary 5before removing
            if (!allrooms.ContainsKey(roomNumber))
            {
                //to show that room does not exist and was not deleted
                return false;
            }

            Room room = allrooms[roomNumber];
            allrooms.Remove(roomNumber);
            Console.WriteLine($"Room {roomNumber} has been deleted.");
            return true;
        }

        public void ListRooms()
        {
            //loops through roomkeys and lists all rooms
            foreach (int roomNumber in allrooms.Keys)
            {
                Console.WriteLine(allrooms[roomNumber].ToString());
            }
        }

        public void ListRoomsOrderedByPrice()
        {
            //loops through all values and orders room by price?
            var orderedRooms = from room in allrooms.Values
                                orderby room.GetRoomPrice()
                                select room;

            //not sure this might work. loops through ordered room and lists all rooms and prices, not sure if it is ordered
            foreach (Room room in orderedRooms)
            {
                Console.WriteLine($"Number: {room.GetRoomNumber}");
                Console.WriteLine($"Price: {room.GetRoomPrice}");
            }
        }

        public void GenerateReport(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Room room in allrooms.Values)
                {
                    writer.WriteLine($"Number: {room.GetRoomNumber()}");
                    writer.WriteLine($"Size: {room.GetRoomSize()}");
                    writer.WriteLine($"Price: {room.GetRoomPrice()}");
                    writer.WriteLine("Bookings: ");

                    foreach (Booking booking in allbookings.Values)
                    {
                        writer.WriteLine($"{booking.GetCheckIn:dd/MM/yyyy} - {booking.GetCheckOut:dd/MM/yyyy}");
                    }

                    writer.WriteLine();
                }
            }
        }

        public void ListAvailableRooms(Booking wantedBooking, Size roomSize)
        {
            //loops through the room dictionary values, checks if room has not been booked and is the current room size specified
            foreach (Room room in allrooms.Values)
            {
                if (room.GetRoomSize() == roomSize && room.IsAvailable(wantedBooking))
                {
                    Console.WriteLine($"Number: {room.GetRoomNumber}");
                    Console.WriteLine($"Size: {room.GetRoomSize}");
                }
            }
        }

        public void ListAvailableRooms(Booking wantedBooking, Size roomSize, int maxPrice)
        {
            var availableRooms = from room in allrooms.Values
                                 where room.GetRoomSize() == roomSize &&
                                       room.GetRoomPrice() <= maxPrice &&
                                       room.IsAvailable(wantedBooking)
                                 orderby room.GetRoomPrice()
                                 select room;

            foreach (Room room in availableRooms)
            {
                Console.WriteLine($"Number: {room.GetRoomNumber}");
                Console.WriteLine($"Size: {room.GetRoomSize}");
                Console.WriteLine($"Price: {room.GetRoomPrice}");
            }
        }

        public bool BookRoom(int roomNumber, Booking wantedBooking)
        {
            // if the wantedbooking overlaps with any bookings in system then throw error else add
            // CORRECT THIS!!!!!!
            //looping through booking with roomnumber
            if (!allbookings.ContainsKey(wantedBooking.GetRoomNumber()))
            { 
                    return false;
            }

            Room room = allrooms[roomNumber];
            if (!room.IsAvailable(wantedBooking))
            {
                return false;
            }

            allbookings.Add(room.GetRoomNumber(), wantedBooking);
            return true;

           
        }

        //maybe an alternative for BookRoom
        public bool AddBooking(Booking other)
        {
            //check if there is no duplicate before adding 

            if (allbookings.ContainsKey(other.GetRoomNumber()))
            {
                return false;
            }

            //adds to the booking dictionary the key and value
            else
                allbookings.Add(other.GetRoomNumber(), other);
            return true;
        }
    }
    }


