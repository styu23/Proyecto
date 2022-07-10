using ProyectoWeb.DOMAIN.Core.Entities;

namespace ProyectoWeb.DOMAIN.Core.Interfaces
{
    public interface IPromocionRepository
    {
        Task<bool> Delete(int id_promocion);
        Task<IEnumerable<Promocion>> GetAll();
        Task<bool> Insert(Promocion promocion);
        Task<bool> Update(Promocion promocion);

        Task<Promocion> GetById(int id_promocion);
    }
}