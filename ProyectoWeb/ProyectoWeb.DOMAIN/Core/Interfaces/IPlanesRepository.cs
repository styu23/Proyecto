using ProyectoWeb.DOMAIN.Core.Entities;

namespace ProyectoWeb.DOMAIN.Core.Interfaces
{
    public interface IPlanesRepository
    {
        Task<bool> Delete(int id_planes);
        Task<IEnumerable<Planes>> GetAll();
        Task<bool> Insert(Planes planes);
        Task<bool> Update(Planes planes);

        Task<Planes> GetById(int id_planes);
    }
}