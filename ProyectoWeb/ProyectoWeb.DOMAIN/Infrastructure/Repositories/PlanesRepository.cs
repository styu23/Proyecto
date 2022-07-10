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
    public class PlanesRepository : IPlanesRepository
    {

        private readonly GymisLifeContext _context;
        public PlanesRepository(GymisLifeContext context)
        {
            _context = context;
        }
        //Get all planes
        public async Task<IEnumerable<Planes>> GetAll()
        {
            return await _context.Planes.ToListAsync();
        }

        public async Task<Planes> GetById(int IdPlanes)
        {
            return await _context.Planes.FindAsync(IdPlanes);

        }

        //Insert Planes
        public async Task<bool> Insert(Planes planes)
        {
            await _context.Planes.AddAsync(planes);
            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        //Update Planes
        public async Task<bool> Update(Planes planes)
        {
            _context.Planes.Update(planes);
            int rows = await _context.SaveChangesAsync();
            return (rows > 0);
        }
        //delete entrenador
        public async Task<bool> Delete(int IdPlanes)
        {
            var planes = await _context.Planes.FindAsync(IdPlanes);
            if (planes == null)
                return false;
            _context.Planes.Remove(planes);
            int rows = await _context.SaveChangesAsync();
            return (rows > 0);
        }

        
    }
}
