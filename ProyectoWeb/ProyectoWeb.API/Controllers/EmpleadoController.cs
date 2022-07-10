//using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoWeb.DOMAIN.Core.Interfaces;
using ProyectoWeb.DOMAIN.Core.Entities;



namespace ProyectoWeb.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private readonly IEmpleadoRepository _EmpleadoRepository;
        //private readonly IMapper _mapper;

        public EmpleadoController(IEmpleadoRepository empleadoRepository)
        {
            _EmpleadoRepository = empleadoRepository;

        }

        //GET
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var empleado = await _EmpleadoRepository.GetAll();
            return Ok(empleado);
        }

        //GET API 
        [HttpPost("Insert")]
        public async Task<IActionResult> Insert([FromBody]Empleado empleado)
            {
               var result = await _EmpleadoRepository.Insert(empleado);
               return Ok(empleado);            
            }

        [HttpPut("Update/{id_empleado}")]
        public async Task<IActionResult> Update(int id_empleado, [FromBody] Empleado empleado)
        { 
            if(id_empleado != empleado.IdEmpleado)
                return BadRequest();
            var result = await _EmpleadoRepository.Update(empleado);
            return Ok(result);
        }

        // [HttpDelete("Delete/{id_empleado}")]
        //public async Task<IActionResult> Delete (int id_empleado)
        // {
        //var empleado = await _EmpleadoRepository.GetById(id_empleado);
        //if (empleado == null)
        //      return NotFound();
        //   var result = await _EmpleadoRepository.Delete(id_empleado);
        //return Ok(result);
        //}

    }
}
