using ProyectoWeb.DOMAIN.Core.Entities;

namespace ProyectoWeb.DOMAIN.Core.Interfaces
{
    public interface IProveedorRepository
    {
        Task<bool> Delete(int id_proveedor);
        Task<IEnumerable<Proveedor>> GetAll();
        Task<bool> Insert(Proveedor proveedor);
        Task<bool> Update(Proveedor proveedor);

       
        Task<Proveedor> GetById(int id_proveedor);
    }
}