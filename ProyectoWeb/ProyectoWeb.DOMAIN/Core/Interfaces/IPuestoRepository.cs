using ProyectoWeb.DOMAIN.Core.Entities;

namespace ProyectoWeb.DOMAIN.Core.Interfaces
{
    public interface IPuestoRepository
    {
        Task<bool> Delete(int id_puesto);
        Task<IEnumerable<Puesto>> GetAll();
        Task<bool> Insert(Puesto puesto);
        Task<bool> Update(Puesto puesto);

        Task<Puesto> GetById(int id_puesto);
    }
}