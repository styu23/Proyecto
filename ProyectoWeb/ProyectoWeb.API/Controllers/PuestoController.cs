using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoWeb.DOMAIN.Core.Entities;
using ProyectoWeb.DOMAIN.Core.Interfaces;

namespace ProyectoWeb.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PuestoController : ControllerBase
    {
        private readonly IPuestoRepository _puestoRepository;
        public PuestoController(IPuestoRepository puestoRepository)
        {
            _puestoRepository = puestoRepository;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var puesto = _puestoRepository.GetAll();
            return Ok(puesto);
        }

        [HttpPost("INSERT ")]
        public async Task<IActionResult> Insert([FromBody] Puesto puesto)
        {
            var result = await _puestoRepository.Insert(puesto);
            return Ok(result);

        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(int id_puesto, [FromBody] Puesto puesto)
        {
            if (id_puesto != puesto.IdPuesto)
                return BadRequest();
            var result = await _puestoRepository.Update(puesto);
            return Ok(result);
        }


        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(int id_puesto)
        {
            var puesto = await _puestoRepository.GetById(id_puesto);
            if (puesto == null)
                return NotFound();
            var result = await _puestoRepository.Delete(id_puesto);
            return Ok(result);
        }
    }
}
