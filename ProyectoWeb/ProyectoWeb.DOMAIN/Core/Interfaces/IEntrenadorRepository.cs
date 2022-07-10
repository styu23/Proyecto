using ProyectoWeb.DOMAIN.Core.Entities;

namespace ProyectoWeb.DOMAIN.Core.Interfaces
{
    public interface IEntrenadorRepository
    {
        Task<bool> Delete(int id_entrenador);
        Task<IEnumerable<Entrenador>> GetAll();
        Task<bool> Insert(Entrenador entrenador);
        Task<bool> Update(Entrenador entrenador);
    }
}