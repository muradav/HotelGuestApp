using DataAccess.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class HotelRepository : IRepository<Hotel>
    {
        public bool Create(Hotel entity)
        {
            try
            {
                DataContext.Hotels.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Hotel entity)
        {
            try
            {
                DataContext.Hotels.Remove(entity);
                return true;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Hotel> GetAll(Predicate<Hotel> filter = null)
        {
            try
            {
                return filter == null ? DataContext.Hotels :
                                DataContext.Hotels.FindAll(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Hotel GetOne(Predicate<Hotel> filter = null)
        {
            try
            {
                return filter == null ? DataContext.Hotels[0] :
                DataContext.Hotels.Find(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(Hotel entity)
        {
            Hotel isExist = GetOne(g => g.Id == entity.Id);
            isExist = entity;
            return true;
        }

        public void AddGuest(Hotel hotel,Guest guest)
        {
            try
            {
                hotel.guests.Add(guest);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
