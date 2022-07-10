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
    public class ClienteRepository : IClienteRepository
    {
        private readonly GymisLifeContext _context;

        public ClienteRepository(GymisLifeContext context)
        {
            _context = context;
        }

        // gett all clientes 

        public async Task<IEnumerable<Cliente>> GetAll()
        {
            return await _context.Cliente.ToListAsync();

        }

        //Get cliente By ID

        public async Task<Cliente> GetById(int id_dni)
        {
            return await _context.Cliente.FindAsync(id_dni);

        }

        //Get all cliente by stored procedure
        public IEnumerable<Cliente> GetAllBySP()
        {

            return _context.Cliente.FromSqlInterpolated($"EXECUTE dbo.GET_Cliente").ToList();
        }


        //insertar cliente

        public async Task<bool> Insert(Cliente cliente)
        {
            await _context.Cliente.AddAsync(cliente);
            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        //update cliente

        public async Task<bool> Update(Cliente cliente)
        {
            _context.Cliente.Update(cliente);
            int rows = await _context.SaveChangesAsync();
            return rows > 0;

        }

        //delete cliente
        public async Task<bool> Delete(int id)
        {
            var cliente = await _context.Cliente.FindAsync(id);
            //validar si es nulo

            if (cliente == null)
                return false;

            _context.Cliente.Remove(cliente);
            int rows = await _context.SaveChangesAsync();
            return (rows > 0);
        }

        
    }
}
