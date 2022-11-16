using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcakBileti.Entity
{
    public class FlightDetail
    {
        public int Id { get; set; }
        public Flight flight { get; set; }
        public Customer customer { get; set; }
        public int PassengerCount { get; set; } 
        public DateTime FlightDate { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public string SeatNo { get; set; }
    }
}
