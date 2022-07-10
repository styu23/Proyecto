using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoWeb.DOMAIN.Core.Entities;
using ProyectoWeb.DOMAIN.Core.Interfaces;

namespace ProyectoWeb.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoRepository _productoRepository;
        public ProductoController(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var producto = _productoRepository.GetAll();
            return Ok(producto);
        }

        [HttpPost("INSERT ")]
        public async Task<IActionResult> Insert([FromBody] Producto producto)
        {
            var result = await _productoRepository.Insert(producto);
            return Ok(result);

        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(int id_producto, [FromBody] Producto producto)
        {
            if (id_producto != producto.IdProducto)
                return BadRequest();
            var result = await _productoRepository.Update(producto);
            return Ok(result);
        }


        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(int id_producto)
        {
            var producto = await _productoRepository.GetById(id_producto);
            if (producto == null)
                return NotFound();
            var result = await _productoRepository.Delete(id_producto);
            return Ok(result);
        }



    }
}
