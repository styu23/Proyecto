using ProyectoWeb.DOMAIN.Core.Entities;

namespace ProyectoWeb.DOMAIN.Core.Interfaces
{
    public interface IPersonaRepository
    {
        Task<bool> Delete(int id_persona);
        Task<IEnumerable<Persona>> GetAll();
        Task<bool> Insert(Persona persona);
        Task<bool> Update(Persona persona);

        Task<Persona> GetById(int id_persona);
    }
}