using ProyectoWeb.DOMAIN.Core.Entities;

namespace ProyectoWeb.DOMAIN.Core.Interfaces
{
    public interface IAreaRepository
    {
        Task<bool> Delete(int id_puesto);
        Task<IEnumerable<Areas>> GetAll();
        Task<bool> Insert(Areas areas);
        Task<bool> Update(Areas areas);
       
        Task<Areas> GetById(int IdAreas);

    }
}