using Business.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Utilities.Helper;

namespace HotelGuestApp.Controllers
{
    public class HotelController
    {
        private HotelService _hotelService;
        public HotelController()
        {
            _hotelService = new HotelService();
        }

        public void CreateHotel()
        {
        createHotel:
            Console.Clear();
            Extention.Print(ConsoleColor.Green, "Hotel Name: ");
            string name = Console.ReadLine();

            Extention.Print(ConsoleColor.Green, "Hotel Size: ");

            int size;

            bool isSize = int.TryParse(Console.ReadLine(), out size);

            if (isSize)
            {
                Hotel hotel = new Hotel
                {
                    Name = name,
                    Capacity = size,
                };

                _hotelService.Create(hotel);
                Extention.Print(ConsoleColor.Green, $"{hotel.Name} created.");
            }
            else
            {
                Extention.Print(ConsoleColor.Red, "Try Again!");
                goto createHotel;
            }

        }

        public void GetAllHotel()
        {
            Console.Clear();
            foreach (var item in _hotelService.GetAll())
            {
                Extention.Print(ConsoleColor.Yellow, $"ID: {item.Id}, Name: {item.Name}");
            }
        }

        public void RemoveHotel()
        {
        removeHotel:
            Console.Clear();
            Extention.Print(ConsoleColor.Green, "Enter ID: ");
            int id;

            bool isID = int.TryParse(Console.ReadLine(), out id);
            if (isID)
            {
                Extention.Print(ConsoleColor.Green, $"{_hotelService.Delete(id).Name}");
            }
            else
            {
                Extention.Print(ConsoleColor.Red, "Try Again!");
                goto removeHotel;
            }
        }

        public void UpdateHotel()
        {
        updateHotel:
            Console.Clear();
            Extention.Print(ConsoleColor.Green, "Enter ID: ");
            int id;



            bool isID = int.TryParse(Console.ReadLine(), out id);
            Extention.Print(ConsoleColor.Green, "Enter new Hotel Name: ");
            string name = Console.ReadLine();
            if (isID)
            {
                Hotel hotel = new Hotel
                {
                    Name = name
                };
                Extention.Print(ConsoleColor.Green, $"Updated {_hotelService.Update(id, hotel).Name}");
            }
            else
            {
                Extention.Print(ConsoleColor.Red, "Try Again!");
                goto updateHotel;
            }
        }

        public void GetHotel()
        {
            Console.Clear();
            Extention.Print(ConsoleColor.Green, "Enter Hotel Name:");
            string name = Console.ReadLine();

            Extention.Print(ConsoleColor.Green, $"{_hotelService.GetHotel(name).Name}");

        }
    }
}
