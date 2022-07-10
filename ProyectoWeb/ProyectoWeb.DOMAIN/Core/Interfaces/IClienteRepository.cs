using ProyectoWeb.DOMAIN.Core.Entities;

namespace ProyectoWeb.DOMAIN.Core.Interfaces
{
    public interface IClienteRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<Cliente>> GetAll();
        IEnumerable<Cliente> GetAllBySP();
        Task<Cliente> GetById(int id_dni);
        Task<bool> Insert(Cliente cliente);
        Task<bool> Update(Cliente cliente);
    }
}