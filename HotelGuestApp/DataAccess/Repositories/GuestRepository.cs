using DataAccess.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class GuestRepository : IRepository<Guest>
    {
        public bool Create(Guest entity)
        {
            try
            {
                DataContext.Guests.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Guest entity)
        {
            try
            {
                DataContext.Guests.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Guest> GetAll(Predicate<Guest> filter = null)
        {
            try
            {
                return filter == null ? DataContext.Guests :
                DataContext.Guests.FindAll(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Guest GetOne(Predicate<Guest> filter = null)
        {
            try
            {
                return filter == null ? DataContext.Guests[0] :
                DataContext.Guests.Find(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(Guest entity)
        {
            try
            {
                Guest isExist = GetOne(s => s.Id == entity.Id);
                isExist = entity;
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
