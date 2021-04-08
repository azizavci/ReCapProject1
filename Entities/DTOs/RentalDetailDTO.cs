﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDTO:IDto
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string CustomerName { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime? ReturnDate { get; set; }


    }
}
