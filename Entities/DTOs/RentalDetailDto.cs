using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDto:IDto
    {
        public int Id { get; set; }
        public string CarName { get; set; }
        public string ColorName { get; set; }
        public string CustomerName { get; set; }
        public int DailyPrice { get; set; }
        public string ModelYear { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
