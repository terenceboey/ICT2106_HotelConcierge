using System;
using System.ComponentModel.DataAnnotations;

namespace _2106_Project.Domain.Models
{
    public class Hotel
    {
        [Key]
        public Guid hotel_id { get; set; }   
        public string HotelName { get; set; }
                    
    }
}
