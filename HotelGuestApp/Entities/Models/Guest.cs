using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Guest:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime ReservationTime { get; set; }
        public int HotelId { get; set; }


        public Guest()
        {
            ReservationTime=DateTime.Now;
        }

        public override string ToString()
        {
            return $"Id: {Id} \n" +
                $"Name: {Name} \n" +
                $"Surname: {Surname} \n" +
                $"Phone Number: {PhoneNumber} \n" +
                $"Email: {Email} \n" +
                $"Reservation time: {ReservationTime}";
        }



    }
}
