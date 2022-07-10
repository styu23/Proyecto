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
    public class PersonaRepository : IPersonaRepository
    {
        public readonly GymisLifeContext _context;
        public PersonaRepository(GymisLifeContext context)
        {
            _context = context;
        }

        //Get all Persona
        public async Task<IEnumerable<Persona>> GetAll()
        {
            return await _context.Persona.ToListAsync();
        }

        public async Task<Persona> GetById(int id_persona)
        {
            return await _context.Persona.FindAsync(id_persona);

        }

        //Insert Persona
        public async Task<bool> Insert(Persona persona)
        {
            await _context.Persona.AddAsync(persona);
            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        //Update Persona
        public async Task<bool> Update(Persona persona)
        {
            _context.Persona.Update(persona);
            int rows = await _context.SaveChangesAsync();
            return (rows > 0);
        }
        //delete Persona
        public async Task<bool> Delete(int id_persona)
        {
            var persona = await _context.Persona.FindAsync(id_persona);
            if (persona == null)
                return false;
            _context.Persona.Remove(persona);
            int rows = await _context.SaveChangesAsync();
            return (rows > 0);
        }


        

    }
}
