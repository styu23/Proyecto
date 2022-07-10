using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoWeb.DOMAIN.Core.DTOs;
using ProyectoWeb.DOMAIN.Core.Entities;
using ProyectoWeb.DOMAIN.Core.Interfaces;

namespace ProyectoWeb.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AreasController : ControllerBase
    {

        private readonly IAreaRepository _areaRepository;
        private readonly IMapper _mapper;
        public AreasController(IAreaRepository areaRepository, IMapper mapper)

        {
           _areaRepository = areaRepository;
            _mapper = mapper;
        }

        //get api/Area
        [HttpGet("GetAll")]
        public async Task< IActionResult> GetAll()
        { 
            var area = await _areaRepository.GetAll();
            var areaList = new List<AreasDTO>();

            areaList = _mapper.Map<List<AreasDTO>>(area);
            return Ok(areaList);
        }


        //get: api/cliente/GetById/2
        [HttpGet("GetById/{id_area}")]
        public async Task<IActionResult> GetById(int IdAreas)
        {
            var area = await _areaRepository.GetById(IdAreas);
            //validar is null
            if (area == null)
                return NotFound();
            return Ok(area);
        }




        // POST: API/AREA/INSERT
        [HttpPost("Insert")]
        public async Task<IActionResult> Insert([FromBody] Areas area)
        { 
            var result = await _areaRepository.Insert(area);
            return Ok(result);
        }

        //PUT: API/AREA/UPDATE
        [HttpPut("Update/{id_puesto}")]
        public async Task<IActionResult> Update([FromBody] Areas area)
        { 
            var result = await _areaRepository.Update(area);
            return Ok(result);
        }

        //DELETE: API/AREA/DELETE
        [HttpDelete("Delete/{id_puesto}")]
        public async Task<IActionResult>Delete(int id_area)
        {
            
            var result = await _areaRepository.Delete(id_area);
            return Ok(result);

        }
    }
}
