using System;
using Hotel;

WestminsterHotel hotel = new WestminsterHotel();

Size size1 = new Size("single");
Size size2 = new Size("double");
Size size3 = new Size("triple");


Room room1 = new Standard(1, 1, size1, 38, 1);
Room room2 = new Standard(2, 2, size2, 50, 2);
Room room3 = new Standard(3, 1, size3, 100, 2);
Room room4 = new Deluxe(4, 2, size1, 138, 50, "mountainview");
Room room5 = new Deluxe(5, 1, size2, 150, 75, "seaview");
Room room6 = new Deluxe(6, 2, size3, 200, 100, "lakeview");
Room room7 = new Deluxe(7, 1, size2, 150, 75, "Mountainview");
Room room8 = new Deluxe(8, 2, size3, 200, 100, "lakeview");
Room room9 = new Standard(9, 1, size1, 38, 1);

hotel.AddRoom(room1);
hotel.AddRoom(room2);
hotel.AddRoom(room3);
hotel.AddRoom(room4);
hotel.AddRoom(room5);
hotel.AddRoom(room6);
hotel.AddRoom(room7);
hotel.AddRoom(room8);
hotel.AddRoom(room9);


//room4.ToString();

while (true)
{

    Console.WriteLine("WELCOME TO WESTMINSTER HOTEL");
    Console.WriteLine("CUSTOMER MENU");
    Console.WriteLine("FOLLOW THE NUMBER PROMPTS");
    Console.WriteLine("1. List Available Rooms by Size");
    Console.WriteLine("2. List Available Rooms by Size and Price");
    Console.WriteLine("3. Book Room");
    Console.WriteLine("4. ADMIN MENU");
    Console.WriteLine("5. EXIT");
    Console.WriteLine();
    Console.WriteLine("What would you like to do today? ");
    int customeroption = Convert.ToInt32(Console.ReadLine());

    switch (customeroption)
    {
        case 1:
            Console.WriteLine("What day would you like to checkin? {yyyy, mm, dd}");
            DateTime customercheckin = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("What day would you like to checkout? {yyyy, mm, dd}");
            DateTime customercheckout = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("What room size would you like: Single, Double or Triple");
            string sizeinput =Console.ReadLine().ToLower();
            Size customersize = new Size(sizeinput);
            //maybe add test case for wrong input

            //Size customersize = Convert.ToInt32(Console.ReadLine());
            Booking wantedBooking = new Booking(customercheckin, customercheckout);
            hotel.ListAvailableRooms(wantedBooking, customersize);
            break;

        case 2:
            Console.WriteLine("What day would you like to checkin? {yyyy, mm, dd}");
            DateTime customercheckinn = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("What day would you like to checkout? {yyyy, mm, dd}");
            DateTime customercheckoutt = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("What room size would you like: Single, Double or Triple");
            string sizeinputt = Console.ReadLine().ToLower();
            Size customersizee = new Size(sizeinputt);
            //maybe add test case for wrong input

            Console.WriteLine("What is the maximum price you would like to pay? ");
            int customerprice = Convert.ToInt32(Console.ReadLine());
            //Size customersize = Convert.ToInt32(Console.ReadLine());
            Booking wantedBookingg = new Booking(customercheckinn, customercheckoutt);

            hotel.ListAvailableRooms(wantedBookingg, customersizee, customerprice);
            break;

        case 3:
            hotel.ListRooms();
            Console.WriteLine("What room number would you like? ");
            int customerroomnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What day would you like to checkin? {yyyy, mm, dd}");
            DateTime customercheckinnn = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("What day would you like to checkout? {yyyy, mm, dd}");
            DateTime customercheckouttt = DateTime.Parse(Console.ReadLine());
            Booking customerbooking = new Booking(customercheckinnn, customercheckouttt);
            hotel.BookRoom(customerroomnumber, customerbooking);
            break;

        case 4:
            Console.WriteLine("WELCOME TO WESTMINSTER HOTEL");
            Console.WriteLine("ADMIN MENU");
            Console.WriteLine("FOLLOW THE NUMBER PROMPTS");
            Console.WriteLine("1. Add Room");
            Console.WriteLine("2. Delete Room");
            Console.WriteLine("3. List Rooms");
            Console.WriteLine("4. List Rooms by Price");
            Console.WriteLine("5. Generate Room(s) Report");
            Console.WriteLine("6. CUSTOMER MENU");
            Console.WriteLine("7. EXIT");
            Console.WriteLine();
            Console.WriteLine("What would you like to do today? ");
            int adminoption = Convert.ToInt32(Console.ReadLine());
            

            switch (adminoption)
            {
                case 1:

                    Console.WriteLine("What room number? ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("What Floor? 1 or 2 ");
                    int floor = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("What room size would you like: Single, Double or Triple");
                    string sizeinputtt = Console.ReadLine().ToLower();
                    Size adminroomsize = new Size(sizeinputtt);
                    //maybe add test case for wrong input

                    Console.WriteLine("What is the price of the room? ");
                    int adminprice = Convert.ToInt32(Console.ReadLine());
                    Room newrroom = new Room(number, floor, adminroomsize, adminprice);
                    hotel.AddRoom(newrroom);
                    break;

                case 2:

                    Console.WriteLine("What room number would you like to delete? ");
                    int adminroomnumber = Convert.ToInt32(Console.ReadLine());
                    hotel.DeleteRoom(adminroomnumber);
                    break;

                case 3:
                    hotel.ListRooms();
                    break;

                case 4:
                    hotel.ListRoomsOrderedByPrice();
                    break;

                case 5:
                    Console.WriteLine("What filename would you like to save report as? ");
                    string adminfilename = Convert.ToString(Console.ReadLine());
                    hotel.GenerateReport(adminfilename);
                    break;

                case 6:
                    break;

                case 7:
                    return;

            }
            break;

        case 5:
            return;
    }
}
