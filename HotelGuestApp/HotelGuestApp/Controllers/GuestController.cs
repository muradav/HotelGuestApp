using Business.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Utilities.Helper;

namespace HotelGuestApp.Controllers
{
    public class GuestController
    {
        private GuestService _guestService;

        public GuestController()
        {
            _guestService = new GuestService();
        }

        public void AddGuest()
        {

            Extention.Print(ConsoleColor.Green, "Enter Guest Name: ");
            string name = Console.ReadLine();

            Extention.Print(ConsoleColor.Green, "Enter Guest Surname: ");
            string surname = Console.ReadLine();

            Extention.Print(ConsoleColor.Green, "Enter Guest Phone Number: ");
            int phoneNumber = int.Parse(Console.ReadLine());

            Extention.Print(ConsoleColor.Green, "Enter Guest Email: ");
            string email = Console.ReadLine();

            Guest guest = new Guest
            {
                Name = name,
                Surname = surname,
                PhoneNumber = phoneNumber,
                Email = email
            };

            _guestService.Create(guest);
            Extention.Print(ConsoleColor.Green, $"Guest {guest.Name} {guest.Surname} reserved successfully.");

        }

        public void UpdateGuest()
        {
        updateGuest:
            Console.Clear();
            Extention.Print(ConsoleColor.Green, "Enter Guest ID: ");

            int id;

            bool IsId = int.TryParse(Console.ReadLine(), out id);

            Extention.Print(ConsoleColor.Green, "Enter Guest Name: ");
            string name = Console.ReadLine();

            Extention.Print(ConsoleColor.Green, "Enter Guest Surname: ");
            string surname = Console.ReadLine();

            Extention.Print(ConsoleColor.Green, "Enter Guest Phone Number: ");
            int phoneNumber = int.Parse(Console.ReadLine());

            Extention.Print(ConsoleColor.Green, "Enter Guest Email: ");
            string email = Console.ReadLine();

            if (IsId)
            {
                Guest guest = new Guest
                {
                    Name = name,
                    Surname = surname,
                    PhoneNumber = phoneNumber,
                    Email = email
                };
                _guestService.Update(id, guest);
                Extention.Print(ConsoleColor.Green, $"Reservation Updated!");

            }
            else
            {
                Extention.Print(ConsoleColor.Red, "Try Again!");
                goto updateGuest;
            }
        }

        public void RemoveGuest()
        {
        removeGuest:
            Console.Clear();
            Extention.Print(ConsoleColor.Green, "Enter Guest ID: ");
            int id;

            bool IsId = int.TryParse(Console.ReadLine(), out id);
            if (IsId)
            {
                Extention.Print(ConsoleColor.Green, $"{_guestService.Delete(id).Name}");
            }
            else
            {
                Extention.Print(ConsoleColor.Red, "Try Again!");
                goto removeGuest;
            }
        }


        public Guest GetGuest()
        {
            Console.Clear();
            Extention.Print(ConsoleColor.Green, "Enter Guest ID: ");
            int id = int.Parse(Console.ReadLine());
            Guest guest = _guestService.GetGuest(id);
            Extention.Print(ConsoleColor.Green, $"Id: {guest.Id} \n" +
                $"Name: {guest.Name} \n" +
                $"Surname: {guest.Surname} \n" +
                $"Phone Number: {guest.PhoneNumber} \n" +
                $"Email: {guest.Email} \n" +
                $"Reservation time: {guest.ReservationTime}");
            return _guestService.GetGuest(id);
        }

        public void GetAllGuest()
        {
            Console.Clear();
            foreach (var item in _guestService.GetAll())
            {
                Extention.Print(ConsoleColor.Yellow, $"ID: {item.Id} \n" +
                    $"Name: {item.Name} \n" +
                    $"Surname: {item.Surname} \n" +
                    $"Phone Number: {item.PhoneNumber} \n" +
                    $"Email: {item.Email} \n" +
                    $"Reservation time: {item.ReservationTime}");
            }
        }
    }
}
