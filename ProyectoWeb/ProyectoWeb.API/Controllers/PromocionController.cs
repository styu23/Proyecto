using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoWeb.DOMAIN.Core.Entities;
using ProyectoWeb.DOMAIN.Core.Interfaces;

namespace ProyectoWeb.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromocionController : ControllerBase
    {
        private readonly IPromocionRepository _PromocionRepository;
        public PromocionController(IPromocionRepository promocionRepository)
        {
            _PromocionRepository = promocionRepository;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var promocion = _PromocionRepository.GetAll();
            return Ok(promocion);
        }

        [HttpPost("INSERT ")]
        public async Task<IActionResult> Insert([FromBody] Promocion promocion )
        {
            var result = await _PromocionRepository.Insert(promocion);
            return Ok(result);

        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(int id_promocion, [FromBody] Promocion promocion)
        {
            if (id_promocion != promocion.IdPromocion)
                return BadRequest();
            var result = await _PromocionRepository.Update(promocion);
            return Ok(result);
        }


        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(int id_planes)
        {
            var persona = await _PromocionRepository.GetById(id_planes);
            if (persona == null)
                return NotFound();
            var result = await _PromocionRepository.Delete(id_planes);
            return Ok(result);
        }






    }
}
