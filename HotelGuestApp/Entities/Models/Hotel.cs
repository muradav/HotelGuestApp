﻿using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Hotel:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Guest> guests;
        public Hotel()
        {
            guests = new List<Guest>();
        }
        
    }
}
