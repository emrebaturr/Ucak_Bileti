using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcakBileti.Entity
{
    public class Flight
    {
        public int Id { get; set; }
        public string WhereFrom { get; set; }
        public string ToWhere { get; set; }
        public DateTime DepartureDate { get; set; }
        public decimal Price { get; set; }
        public int SeatCount { get; set; }
        public string Company { get; set; }
    }
}
