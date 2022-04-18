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
            CreateHotel=1, UpdateHotel, RemoveHotel, AddGuestHotel, ShowGuests, GetHotel, GetAllHotels, BackToMain=0
        }
        public enum GuestMenu
        {
            AddGuest=1, UpdateGuest, RemoveGuest, GetGuest, GetAllGuests, BackToMain=0
        }
        public enum ChoiceEnum
        {
            HotelWorks=1,GuestWorks,Quit=0
        }

        public static void MainMenu1()
        {
            Print(ConsoleColor.DarkCyan, "Hotel Menu");
            Print(ConsoleColor.Cyan, "1.Create Hotel\n" +
                "2.Update Hotel\n" +
                "3.Remove Hotel\n" +
                "4.Add Guest to Hotel \n" +
                "5.Show Guest By Hotel \n" +
                "6.Get Hotel\n" +
                "7.Get All Hotel \n" +
                "0.Back to Main Menu");
            Print(ConsoleColor.Cyan, "Please enter your choice");
        }
        public static void MainMenu2()
        {
            Print(ConsoleColor.DarkCyan, "Guest Menu");
            Print(ConsoleColor.Cyan, "1.Guest Reservation\n" +
                "2.Update Reservation\n" +
                "3.Canceling Reservation\n" +
                "4.Get Guest\n" +
                "5.Get All Guests \n" +
                "0.Back to Main Menu");
            Print(ConsoleColor.Cyan, "Please enter your choice");
        }
        public static void ChoiceMenu()
        {
            Print(ConsoleColor.DarkCyan, "Work Places");
            Print(ConsoleColor.Cyan, "1.Work with Hotels \n" +
                "2.Work with guests \n" +
                "3.Quit");
            Print(ConsoleColor.Cyan, "Choose Your work place: ");            
        }
    }
}
