using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoWeb.DOMAIN.Core.Entities;
using ProyectoWeb.DOMAIN.Core.Interfaces;

namespace ProyectoWeb.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProveedorController : ControllerBase
    {

        private readonly IProveedorRepository _proveedorRepository;
        public ProveedorController(IProveedorRepository proveedorRepository)
        {
            _proveedorRepository = proveedorRepository;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var proveedor = _proveedorRepository.GetAll();
            return Ok(proveedor);
        }

        [HttpPost("INSERT ")]
        public async Task<IActionResult> Insert([FromBody] Proveedor proveedor)
        {
            var result = await _proveedorRepository.Insert(proveedor);
            return Ok(result);

        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(int id_proveedor, [FromBody] Proveedor proveedor)
        {
            if (id_proveedor != proveedor.IdProveedor)
                return BadRequest();
            var result = await _proveedorRepository.Update(proveedor);
            return Ok(result);
        }


        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(int id_proveedor)
        {
            var persona = await _proveedorRepository.GetById(id_proveedor);
            if (persona == null)
                return NotFound();
            var result = await _proveedorRepository.Delete(id_proveedor);
            return Ok(result);
        }

    }
}
