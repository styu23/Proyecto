using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoWeb.DOMAIN.Core.Entities;
using ProyectoWeb.DOMAIN.Core.Interfaces;

namespace ProyectoWeb.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntrenadorController : ControllerBase
    {
        private readonly IEntrenadorRepository _entrenadorRepository;

        public EntrenadorController(IEntrenadorRepository entrenadorRepository)
        {
            _entrenadorRepository = entrenadorRepository;
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult>GetAll()
        {
            var entrenador = await _entrenadorRepository.GetAll();
            return Ok(entrenador);
                  
        }

        [HttpPost("Insert")]
        public async Task<IActionResult> Insert([FromBody] Entrenador entrenador)
        { 
            var result = await _entrenadorRepository.Insert(entrenador);
            return Ok(result);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(int id_entrenador, [FromBody] Entrenador entrenador)
        {
            if (id_entrenador != entrenador.IdEntrenador)
                return BadRequest();
            var result = await _entrenadorRepository.Update(entrenador);
            return Ok(result);
        }

     


    }
}
