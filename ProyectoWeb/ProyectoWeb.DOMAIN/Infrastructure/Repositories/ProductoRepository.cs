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
    public class ProductoRepository : IProductoRepository
    {
        private readonly GymisLifeContext _context;
        public ProductoRepository(GymisLifeContext context)
        {
            _context = context;
        }
        //Get all producto
        public async Task<IEnumerable<Producto>> GetAll()
        {
            return await _context.Producto.ToListAsync();
        }
        //Insert  producto
        public async Task<bool> Insert(Producto producto)
        {
            await _context.Producto.AddAsync(producto);
            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        //Update  producto
        public async Task<bool> Update(Producto producto)
        {
            _context.Producto.Update(producto);
            int rows = await _context.SaveChangesAsync();
            return (rows > 0);
        }
        //delete  producto
        public async Task<bool> Delete(int id_producto)
        {
            var producto = await _context.Producto.FindAsync(id_producto);
            if (producto == null)
                return false;
            _context.Producto.Remove(producto);
            int rows = await _context.SaveChangesAsync();
            return (rows > 0);
        }

        public Task<Producto> GetById(int id_producto)
        {
            throw new NotImplementedException();
        }
    }
}
