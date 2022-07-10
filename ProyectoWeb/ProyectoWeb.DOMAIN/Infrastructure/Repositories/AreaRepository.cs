using Microsoft.EntityFrameworkCore;
using ProyectoWeb.DOMAIN.Core.Entities;
using ProyectoWeb.DOMAIN.Core.Interfaces;
using ProyectoWeb.DOMAIN.Infrastructure.Data;

namespace ProyectoWeb.DOMAIN.Infrastructure.Repositories
{
    public class AreaRepository : IAreaRepository
    {
        private readonly GymisLifeContext _context;
        public AreaRepository(GymisLifeContext context)
        {
            _context = context;
        }
        //GET ALL AREA
        public async Task<IEnumerable<Areas>> GetAll()
        {
            return await _context.Areas.ToListAsync();
        }

        //Get Areas By ID
        public async Task<Areas> GetById(int IdAreas)
        {
            return await _context.Areas.FindAsync(IdAreas);
        }



        //INSERT AREA
        public async Task<bool> Insert(Areas areas)
        {
            await _context.Areas.AddAsync(areas);
            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }
        //update area
        public async Task<bool> Update(Areas areas)
        {
            _context.Areas.Update(areas);
            int rows = await _context.SaveChangesAsync();
            return (rows > 0);
        }
        //delete area
        public async Task<bool> Delete(int id_puesto)
        {
            var area = await _context.Areas.FindAsync(id_puesto);
            if (area == null)
                return false;

            _context.Areas.Remove(area);
            int rows = await _context.SaveChangesAsync();
            return (rows > 0);
        }

        public IEnumerable<Areas> GetAllBySP()
        {
            throw new NotImplementedException();
        }
    }
}
