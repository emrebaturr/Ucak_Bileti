using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcakBileti.Entity;

namespace UcakBileti.Business.Abstract
{
    public interface IUcusService
    {
        List<Ucus> GetAll();
        Task<Ucus> GetUcusById(int Id);
        Task<Ucus> CreateUcus(Ucus ucus);
        Task<Ucus> UpdateUcus(Ucus ucus);
        Task DeleteUcus(int Id);
        Task<Ucus> GetUcusGidisDonus(DateTime Gidis, DateTime Donus, string Nereden, string Nereye);
        Task<Ucus> GetUcusTekYon(DateTime Gidis, string Nereden, string Nereye);
    }
}
