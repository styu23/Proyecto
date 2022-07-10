using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoWeb.DOMAIN.Core.Entities;
using ProyectoWeb.DOMAIN.Core.Interfaces;

namespace ProyectoWeb.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaRepository _personaRepository;
        public PersonaController(IPersonaRepository personaRepository)
        {
            _personaRepository = personaRepository;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var persona = _personaRepository.GetAll();
            return  Ok(persona);
        }

        [HttpPost("iNSERT ")]
        public async Task<IActionResult> Insert([FromBody] Persona persona)
        { 
            var result = await _personaRepository.Insert(persona);
            return Ok(result);
        
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(int id_persona, [FromBody] Persona persona)
        {
            if (id_persona != persona.IdPersona)
                return BadRequest();
            var result = await _personaRepository.Update(persona);
            return Ok(result);
        }


        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(int id_persona)
        { 
            var persona = await _personaRepository.GetById(id_persona);
            if (persona == null)
                return NotFound();
            var result = await _personaRepository.Delete(id_persona);
            return Ok(result);        
        }





    }
}
