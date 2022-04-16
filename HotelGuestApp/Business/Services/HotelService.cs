using Business.Interfaces;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Utilities.Helper;

namespace Business.Services
{
    public class HotelService : IHotel
    {
        public static int Count { get; set; } = 1;
        private HotelRepository _hotelRepository;
        public HotelService()
        {
            _hotelRepository = new HotelRepository();
        }
        public Hotel Create(Hotel hotel)
        {
            try
            {                
                hotel.Id = Count;
                _hotelRepository.Create(hotel);
                Count++;
                return hotel;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Hotel Delete(int Id)
        {
            try
            {
                Hotel isExist = _hotelRepository.GetOne(h => h.Id == Id);
                if (isExist == null)
                {
                    return null;
                }
                _hotelRepository.Delete(isExist);
                return isExist;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Hotel> GetAll()
        {
            try
            {
                return _hotelRepository.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Hotel GetHotel(string name)
        {
            try
            {
                return _hotelRepository.GetOne(g => g.Name == name);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Hotel Update(int Id, Hotel hotel)
        {
            try
            {
                Hotel isExsit = _hotelRepository.GetOne(g => g.Id == Id);
                if (isExsit == null)
                {
                    return null;
                }
                isExsit.Name = hotel.Name;
                _hotelRepository.Update(hotel);
                return hotel;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Hotel AddGuest(Guest guest,int id)
        {
            try
            {
                Hotel hotel = _hotelRepository.GetOne(h => h.Id == id);
                if (hotel == null)
                    return null;
                if (hotel.Capacity>0)
                {
                    _hotelRepository.AddGuest(hotel, guest);
                    hotel.Capacity--;
                }
                else
                {
                    Extention.Print(ConsoleColor.Red, "There is not empty room. Please come later");                    
                }
                return hotel;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
