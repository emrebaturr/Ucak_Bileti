using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcakBileti.Entity
{
    public class Ucus
    {
        public int Id { get; set; }
        public string Nereden { get; set; }
        public string Nereye { get; set; }
        public int YolcuSayisi { get; set; }
        public DateTime GidisTarihi { get; set; }
        public DateTime DonusTarihi { get; set; }
        public decimal Fiyat { get; set; }
        public DateTime Saat { get; set; }
    }
}
