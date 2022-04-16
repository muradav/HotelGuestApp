using Business.Interfaces;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services
{
    public class GuestService : IGuest
    {
        public static int Count { get; set; } = 1;
        private GuestRepository _guestRepository;
        public GuestService()
        {
            _guestRepository=new GuestRepository();
        }
        public Guest Create(Guest guest)
        {
            try
            {
                guest.Id = Count;
                _guestRepository.Create(guest);
                Count++;
                return guest;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Guest Delete(int Id)
        {
            try
            {
                Guest isExist = _guestRepository.GetOne(g => g.Id == Id);
                if (isExist == null)
                {
                    return null;
                }
                _guestRepository.Delete(isExist);
                return isExist;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Guest> GetAll()
        {
            try
            {
                return _guestRepository.GetAll();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Guest GetGuest(int id)
        {
            try
            {
                return _guestRepository.GetOne(g => g.Id == id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Guest Update(int Id, Guest guest)
        {
            try
            {
                Guest isExsit = _guestRepository.GetOne(g => g.Id == Id);
                if (isExsit == null)
                {
                    return null;
                }
                isExsit.Name = guest.Name;
                _guestRepository.Update(guest);
                return guest;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
