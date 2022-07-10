using ProyectoWeb.DOMAIN.Core.Entities;

namespace ProyectoWeb.DOMAIN.Core.Interfaces
{
    public interface IProductoRepository
    {
        Task<bool> Delete(int id_producto);
        Task<IEnumerable<Producto>> GetAll();
        Task<bool> Insert(Producto producto);
        Task<bool> Update(Producto producto);

        Task<Producto> GetById(int id_producto);
    }
}