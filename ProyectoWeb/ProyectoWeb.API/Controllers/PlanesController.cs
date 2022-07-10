using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoWeb.DOMAIN.Core.Entities;
using ProyectoWeb.DOMAIN.Core.Interfaces;

namespace ProyectoWeb.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanesController : ControllerBase
    {
        private readonly IPlanesRepository _planesRepository;
        public PlanesController(IPlanesRepository planesRepository)
        {
            _planesRepository = planesRepository;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var planes = _planesRepository.GetAll();
            return Ok(planes);
        }



        [HttpPost("INSERT ")]
        public async Task<IActionResult> Insert([FromBody] Planes planes)
        {
            var result = await _planesRepository.Insert(planes);
            return Ok(result);

        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(int IdPlanes, [FromBody] Planes planes)
        {
            if (IdPlanes != planes.IdPlanes)
                return BadRequest();
            var result = await _planesRepository.Update(planes);
            return Ok(result);
        }


        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(int IdPlanes)
        {
            var persona = await _planesRepository.GetById(IdPlanes);
            if (persona == null)
                return NotFound();
            var result = await _planesRepository.Delete(IdPlanes);
            return Ok(result);
        }






    }
}
