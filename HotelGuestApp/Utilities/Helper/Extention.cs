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

        public enum HotelMenu
        {
            CreateHotel=1, UpdateHotel, RemoveHotel, GetHotel, GetAllHotels, Quit=0
        }
        public enum GuestMenu
        {
            AddGuest=1, UpdateGuest, RemoveGuest, GetGuest, GetAllGuests, Quit=0
        }
        public enum ChoiceEnum
        {
            HotelWorks=1,GuestWorks
        }

        public static void MainMenu1()
        {
            Extention.Print(ConsoleColor.DarkCyan, "Hotel Menu");
            Extention.Print(ConsoleColor.Cyan, "1.Create Hotel\n" +
                "2.Update Hotel\n" +
                "3.Remove Hotel\n" +
                "4.Get Hotel\n" +
                "5.Get All Hotel \n" +
                "0.Quit");
        }
        public static void MainMenu2()
        {
            Extention.Print(ConsoleColor.DarkCyan, "Guest Menu");
            Extention.Print(ConsoleColor.Cyan, "1.Guest Reservation\n" +
                "2.Update Reservation\n" +
                "3.Canceling Reservation\n" +
                "4.Get Guest\n" +
                "5.Get All Guests \n" +
                "0.Quit");
        }
        public static void ChoiceMenu()
        {
            Extention.Print(ConsoleColor.DarkCyan, "Work Places");
            Extention.Print(ConsoleColor.Cyan, "1.Work with Hotels \n" +
                "2.Work with guests");
            Extention.Print(ConsoleColor.Cyan, "Choose Your work place: ");
        }
    }
}
