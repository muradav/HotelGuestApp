using HotelGuestApp.Controllers;
using System;
using Utilities.Helper;

namespace HotelGuestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Extention.Print(ConsoleColor.DarkCyan, "Welcome!");
            while (true)
            {
                HotelController hotelController = new HotelController();
                GuestController guestController = new GuestController();
                Extention.MainMenu();

                int input;

                bool IsNum = int.TryParse(Console.ReadLine(), out input);

                if (IsNum && input < 11 && input > 0)
                {
                    switch (input)
                    {
                        case (int)Extention.Menu.CreateHotel:
                            hotelController.CreateHotel();
                            break;

                        case (int)Extention.Menu.UpdateHotel:
                            hotelController.UpdateHotel();
                            break;

                        case (int)Extention.Menu.RemoveHotel:
                            hotelController.RemoveHotel();
                            break;

                        case (int)Extention.Menu.GetHotel:
                            hotelController.GetHotel();
                            break;

                        case (int)Extention.Menu.GetAllHotels:
                            hotelController.GetAllHotel();
                            break;

                        case (int)Extention.Menu.AddGuest:
                            guestController.AddGuest();
                            break;

                        case (int)Extention.Menu.UpdateGuest:
                            guestController.UpdateGuest();
                            break;

                        case (int)Extention.Menu.RemoveGuest:
                            guestController.RemoveGuest();
                            break;

                        case (int)Extention.Menu.GetGuest:
                            guestController.GetGuest();
                            break;

                        case (int)Extention.Menu.GetAllGuests:
                            guestController.GetAllGuest();
                            break;

                        case (int)Extention.Menu.Quit:
                            break;
                           

                    }
                }

            }

        }
    }
}
