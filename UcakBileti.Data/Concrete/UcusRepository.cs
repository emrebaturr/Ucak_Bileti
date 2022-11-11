using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcakBileti.Data.Abstract;
using UcakBileti.Entity;

namespace UcakBileti.Data.Concrete
{
    public class UcusRepository : IUcusRepository
    {
        public async Task<Ucus> CreateUcus(Ucus ucus)
        {
            using (var ucusDbContext = new UcusDbContext())
            {
                ucusDbContext.Ucuslar.Add(ucus);
                await ucusDbContext.SaveChangesAsync();
                return ucus;
            }
        }

        public async Task DeleteUcus(int Id)
        {
            using (var ucusDbContext = new UcusDbContext())
            {
                var ucus = await GetUcusById(Id);
                ucusDbContext.Ucuslar.Remove(ucus);
                await ucusDbContext.SaveChangesAsync();
            }
        }

        public List<Ucus> GetAll()
        {
            using (var ucusDbContext = new UcusDbContext())
            {
                return ucusDbContext.Ucuslar.ToList();
            }
        }

        public async Task<Ucus> GetUcusById(int Id)
        {
            using(var ucusDbContext = new UcusDbContext())
            {
                return await ucusDbContext.Ucuslar.FindAsync(Id);
            }
        }

        public async Task<Ucus> GetUcusGidisDonus(DateTime Gidis, DateTime Donus, string Nereden, string Nereye)
        {
            using(var ucusDbContext = new UcusDbContext()) 
            {
                return await ucusDbContext.Ucuslar.Where(u => u.GidisTarihi == Gidis && u.DonusTarihi == Donus && u.Nereden == Nereden && u.Nereye == Nereye).FirstOrDefaultAsync();
            }
        }

        public async Task<Ucus> GetUcusTekYon(DateTime GidisTarihi, string Nereden, string Nereye)
        {
            using (var ucusDbContext = new UcusDbContext()) 
            {
                return await ucusDbContext.Ucuslar.Where(u => u.GidisTarihi == GidisTarihi && u.Nereden == Nereden && u.Nereye == Nereye).FirstOrDefaultAsync();
            }
        }

        public async Task<Ucus> UpdateUcus(Ucus ucus)
        {
            using(var ucusDbContext =new UcusDbContext())
            {
                ucusDbContext.Ucuslar.Update(ucus);
                await ucusDbContext.SaveChangesAsync();
                return ucus;
            }
        }
    }
}
