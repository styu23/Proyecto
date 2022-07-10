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
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _ClienteRepository;
        private readonly IMapper _mapper;

        public ClienteController(IClienteRepository ClienteRepository, IMapper mapper) 
        { 
                _ClienteRepository = ClienteRepository;
                 _mapper = mapper;
         }


        // http get cliente   - api/cliente
        [HttpGet("GetAll")]
        public async Task< IActionResult> GetAll()
        {
            var cliente = await _ClienteRepository.GetAll();
            var clienteList = new List<ClienteDTO>();
            //  foreach (var Cliente in cliente)
            //  {
            //  clienteList.Add(new ClienteDTO
            //  {
            //   IdDni = Cliente.IdDni,
            //   FechaIni = Cliente.FechaIni,
            //   FechaFin = Cliente.FechaFin,
            //   Ocupacion = Cliente.Ocupacion
            //   });
            //}
            //convert cliente 

            clienteList = _mapper.Map<List<ClienteDTO>>(cliente);
                    
            return Ok(clienteList);
        }

        //get: api/cliente/GetById/2
        [HttpGet("GetById/{id_dni}")]

        public async Task<IActionResult> GetById(int id_dni) 
        {
            var cliente = await _ClienteRepository.GetById(id_dni);
            //validar is null
            if(cliente ==null)
                return NotFound();

            return Ok(cliente);
        }


        //POST:  api/cliente/INSERT

        [HttpPost("Insert")]
        public async Task<IActionResult> Insert([FromBody] Cliente cliente)
        {
          var result = await _ClienteRepository.Insert(cliente);
            return Ok(result);
        }

        //PUT: API/CLIENTE/UPDATE

        [HttpPut("Update/{id_dni}")]
        public async Task<IActionResult> Update(int id_dni, [FromBody] Cliente cliente)
        { 
            if(id_dni != cliente.IdDni)
                return BadRequest();

            var result= await _ClienteRepository.Update(cliente);
            return Ok(result);
        
        }


        //delete:api/cliente/delete
        [HttpDelete("Delete/{id_dni}")]
        public async Task<IActionResult> Delete(int id_dni)
        {
            var cliente = await _ClienteRepository.GetById(id_dni);
            //validate is null
            if (cliente == null)
                return NotFound();
            var result = await _ClienteRepository.Delete(id_dni);
            return Ok(result);
        }

    }
}
