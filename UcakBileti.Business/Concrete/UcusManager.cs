using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcakBileti.Business.Abstract;
using UcakBileti.Data.Abstract;
using UcakBileti.Entity;

namespace UcakBileti.Business.Concrete
{
    public class UcusManager : IUcusService
    {
        private IUcusRepository _ucusRepository;
        public UcusManager(IUcusRepository ucusRepository)
        {
            _ucusRepository = ucusRepository;
        }
        public async Task<Ucus> CreateUcus(Ucus ucus)
        {
            return await _ucusRepository.CreateUcus(ucus);
        }

        public async Task DeleteUcus(int Id)
        {
            await _ucusRepository.DeleteUcus(Id);
        }

        public List<Ucus> GetAll()
        {
            return _ucusRepository.GetAll();
        }

        public async Task<Ucus> GetUcusById(int Id)
        {
            return await _ucusRepository.GetUcusById(Id);
        }

        public async Task<Ucus> GetUcusGidisDonus(DateTime Gidis, DateTime Donus, string Nereden, string Nereye)
        {
            return await _ucusRepository.GetUcusGidisDonus(Gidis, Donus, Nereden, Nereye);  
        }

        public async Task<Ucus> GetUcusTekYon(DateTime Gidis, string Nereden, string Nereye)
        {
            return await _ucusRepository.GetUcusTekYon(Gidis, Nereden, Nereye);
        }

        public async Task<Ucus> UpdateUcus(Ucus ucus)
        {
            return await _ucusRepository.UpdateUcus(ucus);
        }
    }
}
