using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class DataContext
    {
        public static List<Hotel> Hotels { get; set; }
        public static List<Guest> Guests { get; set; }

        static DataContext()
        {
            Hotels= new List<Hotel>();
            Guests= new List<Guest>();
        }
    }
}
