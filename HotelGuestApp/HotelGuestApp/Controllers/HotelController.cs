﻿using Business.Services;
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
        private GuestController _guestService;
        public List<Guest> guest { get; set; }
        public HotelController()
        {
            _hotelService = new HotelService();
            guest=new List<Guest>();
            _guestService = new GuestController();

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
                //Extention.Print(ConsoleColor.DarkYellow, "For continue press Enter");
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
                Extention.Print(ConsoleColor.Yellow, $"ID: {item.Id} \n" +
                    $"Name: {item.Name} \n" +
                    $"Empty Room: {item.Capacity}");
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
                Extention.Print(ConsoleColor.Green, $"Updated Hotel Name: {_hotelService.Update(id, hotel).Name}");
            }
            else
            {
                Extention.Print(ConsoleColor.Red, "Try Again!");
                goto updateHotel;
            }
        }

        public Hotel GetHotel()
        {
            Console.Clear();
            Extention.Print(ConsoleColor.Green, "Enter Hotel Name:");
            string name = Console.ReadLine();
            Hotel hotel = _hotelService.GetHotel(name);
            Extention.Print(ConsoleColor.Green, $"ID: {hotel.Id} \n" +
                $"Name: {hotel.Name} \n" +
                $"Empty Room: {hotel.Capacity}");
            return _hotelService.GetHotel(name);

        }
        public void AddGuest()
        {
            Console.Clear();
            //string name = Console.ReadLine();
            Hotel hotel = GetHotel();
            //int id = int.Parse(Console.ReadLine()); 
            Guest guest = _guestService.GetGuest();
            _hotelService.AddGuest(guest,hotel.Id);
            //Extention.Print(Console)
        }
        public void ShowGuestByHotel()
        {
            Console.Clear();
            Hotel hotel = GetHotel();
            foreach (var item in hotel.guests)
            {
                Console.WriteLine(item);
            }
        }

    }
}
