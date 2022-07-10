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
    public class ProveedorRepository : IProveedorRepository
    {
        private readonly GymisLifeContext _context;
        public ProveedorRepository(GymisLifeContext context)
        {
            _context = context;
        }
        //Get all Proveedor
        public async Task<IEnumerable<Proveedor>> GetAll()
        {
            return await _context.Proveedor.ToListAsync();
        }



        public async Task<Proveedor> GetById(int id_proveedor)
        {
            return await _context.Proveedor.FindAsync(id_proveedor);
            
        }

        //Insert Proveedor
        public async Task<bool> Insert(Proveedor proveedor)
        {
            await _context.Proveedor.AddAsync(proveedor);
            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        //Update Proveedor
        public async Task<bool> Update(Proveedor proveedor)
        {
            _context.Proveedor.Update(proveedor);
            int rows = await _context.SaveChangesAsync();
            return (rows > 0);
        }
        //delete Proveedor
        public async Task<bool> Delete(int id_proveedor)
        {
            var proveedor = await _context.Proveedor.FindAsync(id_proveedor);
            if (proveedor == null)
                return false;
            _context.Proveedor.Remove(proveedor);
            int rows = await _context.SaveChangesAsync();
            return (rows > 0);
        }

      
    }
}
