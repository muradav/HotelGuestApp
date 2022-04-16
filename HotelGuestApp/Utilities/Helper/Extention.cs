using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities.Helper
{
    public class Extention
    {
        public static void Print(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public enum Menu
        {
            CreateHotel=1, UpdateHotel, RemoveHotel, GetHotel, GetAllHotels,
            AddGuest, UpdateGuest, RemoveGuest, GetGuest, GetAllGuests, Quit=0
        }

        public static void MainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Menu");
            Console.WriteLine("1. Create Hotel\n" +
                "2.  Update Hotel\n" +
                "3.  Remove Hotel\n" +
                "4.  Get Hotel\n" +
                "5.  Get All Hotel\n" +
                "6.  Guest Reservation\n" +
                "7.  Update Reservation\n" +
                "8.  Canceling Reservation\n" +
                "9.  Get Guest\n" +
                "10. Get All Guests\n" +
                "0.  Quit");
            Console.ResetColor();
        }
    }
}
