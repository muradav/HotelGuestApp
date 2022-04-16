using HotelGuestApp.Controllers;
using System;
using Utilities.Helper;

namespace HotelGuestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Extention.Print(ConsoleColor.Magenta, "Welcome!");
        choiceMenu:
            Console.Clear();
            Extention.ChoiceMenu();
            int input = int.Parse(Console.ReadLine());

            do
            {
                HotelController hotelController = new HotelController();
                GuestController guestController = new GuestController();
                //Extention.MainMenu();           

                switch (input)
                {


                    case (int)Extention.ChoiceEnum.HotelWorks:
                        Console.Clear();
                        Extention.MainMenu1();
                        int input2 = int.Parse(Console.ReadLine());
                        switch (input2)
                        {
                            case (int)Extention.HotelMenu.CreateHotel:
                                hotelController.CreateHotel();
                                break;

                            case (int)Extention.HotelMenu.UpdateHotel:
                                hotelController.UpdateHotel();
                                break;

                            case (int)Extention.HotelMenu.RemoveHotel:
                                hotelController.RemoveHotel();
                                break;

                            case (int)Extention.HotelMenu.GetHotel:
                                hotelController.GetHotel();
                                break;

                            case (int)Extention.HotelMenu.GetAllHotels:
                                hotelController.GetAllHotel();
                                break;
                            case (int)Extention.HotelMenu.Quit:
                                goto choiceMenu;

                        }
                        break;
                    case (int)Extention.ChoiceEnum.GuestWorks:
                        Console.Clear();
                        Extention.MainMenu2();
                        int input3 = int.Parse(Console.ReadLine());
                        switch (input3)
                        {
                            case (int)Extention.GuestMenu.AddGuest:
                                guestController.AddGuest();
                                break;

                            case (int)Extention.GuestMenu.UpdateGuest:
                                guestController.UpdateGuest();
                                break;

                            case (int)Extention.GuestMenu.RemoveGuest:
                                guestController.RemoveGuest();
                                break;

                            case (int)Extention.GuestMenu.GetGuest:
                                guestController.GetGuest();
                                break;

                            case (int)Extention.GuestMenu.GetAllGuests:
                                guestController.GetAllGuest();
                                break;

                            case (int)Extention.GuestMenu.Quit:
                                goto choiceMenu;
                        }
                        break;

                }
            } while (input!=0);

        }
    }
}
