using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using bonoeducativo.Modelo.dto;
using bonoeducativo.Modelo;


namespace bonoeducativo.Aplicacion.mapeo
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            CreateMap<associated, associateddto>();
        }
    }
}
