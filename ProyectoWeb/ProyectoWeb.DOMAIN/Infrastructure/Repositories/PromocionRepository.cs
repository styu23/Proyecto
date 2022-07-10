using Microsoft.EntityFrameworkCore;
using ProyectoWeb.DOMAIN.Core.Entities;
using ProyectoWeb.DOMAIN.Core.Interfaces;
using ProyectoWeb.DOMAIN.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWeb.DOMAIN.Infrastructure.Repositories
{
    public class PromocionRepository : IPromocionRepository
    {
        private readonly GymisLifeContext _context;
        public PromocionRepository(GymisLifeContext context)
        {
            _context = context;
        }
        //Get all promocion
        public async Task<IEnumerable<Promocion>> GetAll()
        {
            return await _context.Promocion.ToListAsync();
        }

        public async Task<Promocion> GetById(int id_promocion)
        {
            return await _context.Promocion.FindAsync(id_promocion);

        }


        //Insert promocion

        public async Task<bool> Insert(Promocion promocion)
        {
            await _context.Promocion.AddAsync(promocion);
            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        //Update promocion
        public async Task<bool> Update(Promocion promocion)
        {
            _context.Promocion.Update(promocion);
            int rows = await _context.SaveChangesAsync();
            return (rows > 0);
        }
        //delete Promocion
        public async Task<bool> Delete(int id_promocion)
        {
            var promocion = await _context.Promocion.FindAsync(id_promocion);
            if (promocion == null)
                return false;
            _context.Promocion.Remove(promocion);
            int rows = await _context.SaveChangesAsync();
            return (rows > 0);
        }

        
    }
}
