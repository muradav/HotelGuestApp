using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IGuest
    {
        Guest Create(Guest guest);
        Guest Update(int Id, Guest guest);
        Guest Delete(int Id);
        Guest GetGuest(string name);
        List<Guest> GetAll();
    }
}
