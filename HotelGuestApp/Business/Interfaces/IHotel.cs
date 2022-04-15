using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IHotel
    {
        Hotel Create(Hotel hotel);
        Hotel Update(int Id, Hotel hotel);
        Hotel Delete(int Id);
        Hotel GetHotel(string name);
        List<Hotel> GetAll();
    }
}
