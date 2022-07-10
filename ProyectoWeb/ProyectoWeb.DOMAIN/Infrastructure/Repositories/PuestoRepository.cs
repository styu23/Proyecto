using Microsoft.EntityFrameworkCore;
using ProyectoWeb.DOMAIN.Core.Entities;
using ProyectoWeb.DOMAIN.Core.Interfaces;
using ProyectoWeb.DOMAIN.Infrastructure.Data;

namespace ProyectoWeb.DOMAIN.Infrastructure.Repositories
{
    public class PuestoRepository : IPuestoRepository
    {
        private readonly GymisLifeContext _context;
        public PuestoRepository(GymisLifeContext context)
        {
            _context = context;
        }
        //Get all Puesto
        public async Task<IEnumerable<Puesto>> GetAll()
        {
            return await _context.Puesto.ToListAsync();
        }
        //Insert Puesto
        public async Task<bool> Insert(Puesto puesto)
        {
            await _context.Puesto.AddAsync(puesto);
            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        //Update Puesto
        public async Task<bool> Update(Puesto puesto)
        {
            _context.Puesto.Update(puesto);
            int rows = await _context.SaveChangesAsync();
            return (rows > 0);
        }
        //delete Puesto
        public async Task<bool> Delete(int id_puesto)
        {
            var puesto = await _context.Puesto.FindAsync(id_puesto);
            if (puesto == null)
                return false;
            _context.Puesto.Remove(puesto);
            int rows = await _context.SaveChangesAsync();
            return (rows > 0);
        }

        public Task<Puesto> GetById(int id_puesto)
        {
            throw new NotImplementedException();
        }
    }
}
