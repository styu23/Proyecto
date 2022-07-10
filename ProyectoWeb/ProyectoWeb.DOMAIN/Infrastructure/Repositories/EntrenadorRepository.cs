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
    public class EntrenadorRepository : IEntrenadorRepository
    {
        private readonly GymisLifeContext _context;
        public EntrenadorRepository(GymisLifeContext context)
        {
            _context = context;
        }
        //Get all Entrenador
        public async Task<IEnumerable<Entrenador>> GetAll()
        {
            return await _context.Entrenador.ToListAsync();
        }
        //Insert Entrenador
        public async Task<bool> Insert(Entrenador entrenador)
        {
            await _context.Entrenador.AddAsync(entrenador);
            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        //Update entrenador
        public async Task<bool> Update(Entrenador entrenador)
        {
            _context.Entrenador.Update(entrenador);
            int rows = await _context.SaveChangesAsync();
            return (rows > 0);
        }
        //delete entrenador
        public async Task<bool> Delete(int id_entrenador)
        {
            var entrenador = await _context.Entrenador.FindAsync(id_entrenador);
            if (entrenador == null)
                return false;
            _context.Entrenador.Remove(entrenador);
            int rows = await _context.SaveChangesAsync();
            return (rows > 0);
        }

    }
}
