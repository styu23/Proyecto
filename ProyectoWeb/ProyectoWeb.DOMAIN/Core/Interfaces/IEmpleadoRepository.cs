using ProyectoWeb.DOMAIN.Core.Entities;

namespace ProyectoWeb.DOMAIN.Core.Interfaces
{
    public interface IEmpleadoRepository
    {
        Task<bool> Delete(int id_dempleado);
        Task<IEnumerable<Empleado>> GetAll();
        Task<bool> Insert(Empleado empleado);
        Task<bool> Update(Empleado empleado);
        Task GetById(int id_empleado);
    }
}