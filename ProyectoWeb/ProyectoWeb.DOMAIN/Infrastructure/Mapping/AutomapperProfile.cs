
using AutoMapper;
using ProyectoWeb.DOMAIN.Core.DTOs;
using ProyectoWeb.DOMAIN.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWeb.DOMAIN.Infrastructure.Mapping
{
    public  class AutomapperProfile: Profile
    {

        public AutomapperProfile()
        {
            CreateMap<Cliente, ClienteDTO>();
            CreateMap<ClienteDTO, Cliente>();
            CreateMap<Areas, AreasDTO>();

         }

    }
}
