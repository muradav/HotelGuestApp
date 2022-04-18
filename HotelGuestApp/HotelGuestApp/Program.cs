using HotelGuestApp.Controllers;
using System;
using Utilities.Helper;

namespace HotelGuestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            
        choiceMenu:
            Extention.Print(ConsoleColor.Magenta, "Welcome!");
            Extention.ChoiceMenu();
            int input = int.Parse(Console.ReadLine());
            //Console.ReadLine();
            //Console.Clear();
            //Extention.Print(ConsoleColor.DarkYellow, "For continue press Enter");

            do
            {
                HotelController hotelController = new HotelController();
                GuestController guestController = new GuestController();
                
                switch (input)
                {
                   

                    case (int)Extention.ChoiceEnum.HotelWorks:
                        //Console.ReadLine();
                        //Console.Clear();
                        Extention.MainMenu1();
                        int input2 = int.Parse(Console.ReadLine());                        
                        switch (input2)
                        {
                            case (int)Extention.HotelMenu.CreateHotel:
                                Console.Clear();
                                hotelController.CreateHotel();
                                break;

                            case (int)Extention.HotelMenu.UpdateHotel:
                                Console.Clear();
                                hotelController.UpdateHotel();
                                break;

                            case (int)Extention.HotelMenu.AddGuestHotel:
                                Console.Clear();
                                hotelController.AddGuest();
                                break;

                            case (int)Extention.HotelMenu.ShowGuests:
                                Console.Clear();
                                hotelController.ShowGuestByHotel();
                                break;

                            case (int)Extention.HotelMenu.RemoveHotel:
                                Console.Clear();
                                hotelController.RemoveHotel();
                                break;

                            case (int)Extention.HotelMenu.GetHotel:
                                Console.Clear();
                                hotelController.GetHotel();
                                break;

                            case (int)Extention.HotelMenu.GetAllHotels:
                                Console.Clear();
                                hotelController.GetAllHotel();
                                break;
                            case (int)Extention.HotelMenu.BackToMain:
                                Console.Clear();
                                goto choiceMenu;

                        }
                        break;
                    case (int)Extention.ChoiceEnum.GuestWorks:
                        //Console.ReadLine();
                        //Console.Clear();
                        Extention.MainMenu2();
                        int input3 = int.Parse(Console.ReadLine());
                        switch (input3)
                        {
                            case (int)Extention.GuestMenu.AddGuest:
                                Console.Clear();
                                guestController.AddGuest();
                                break;

                            case (int)Extention.GuestMenu.UpdateGuest:
                                Console.Clear();
                                guestController.UpdateGuest();
                                break;

                            case (int)Extention.GuestMenu.RemoveGuest:
                                Console.Clear();
                                guestController.RemoveGuest();
                                break;

                            case (int)Extention.GuestMenu.GetGuest:
                                Console.Clear();
                                guestController.GetGuest();
                                break;

                            case (int)Extention.GuestMenu.GetAllGuests:
                                Console.Clear();
                                guestController.GetAllGuest();
                                break;

                            case (int)Extention.GuestMenu.BackToMain:
                                Console.Clear();
                                goto choiceMenu;
                        }
                        break;

                    case (int)Extention.ChoiceEnum.Quit:
                        break;

                }
            } while (input!=0);

        }
    }
}
