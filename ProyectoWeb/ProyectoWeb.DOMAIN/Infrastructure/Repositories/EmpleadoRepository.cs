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
    public class EmpleadoRepository : IEmpleadoRepository
    {
        private readonly GymisLifeContext _context;
        public EmpleadoRepository(GymisLifeContext context)
        {
            _context = context;
        }
        //get all empleado
        public async Task<IEnumerable<Empleado>> GetAll()
        {
            return await _context.Empleado.ToListAsync();
        }
        public async Task<Empleado> GetById(int id_empleado)
        {
            return await _context.Empleado.FindAsync(id_empleado);

        }


        //Insertar empleado
        public async Task<bool> Insert(Empleado empleado)
        {
            await _context.Empleado.AddAsync(empleado);
            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }
        //Update empleado
        public async Task<bool> Update(Empleado empleado)
        {
            _context.Empleado.Update(empleado);
            int rows = await _context.SaveChangesAsync();
            return (rows > 0);
        }
        //Delete empleado
        public async Task<bool> Delete(int id_empleado)
        {
            var empleado = await _context.Empleado.FindAsync(id_empleado);
            if (empleado == null)
                return false;
            _context.Empleado.Remove(empleado);
            int rows = await _context.SaveChangesAsync();
            return (rows > 0);
        }

        Task IEmpleadoRepository.GetById(int id_empleado)
        {
            throw new NotImplementedException();
        }
    }
}
