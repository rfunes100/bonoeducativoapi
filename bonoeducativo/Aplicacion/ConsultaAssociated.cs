using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using bonoeducativo.Modelo;
using bonoeducativo.Modelo.dto;
using bonoeducativo.Persistencia;
using AutoMapper;
using System.Threading;
using Microsoft.EntityFrameworkCore;



namespace bonoeducativo.Aplicacion
{
    public class ConsultaAssociated
    {
        public class Listasociado : IRequest<List<associateddto>> { }


        public class Manejador : IRequestHandler<Listasociado, List<associateddto>>
        {
            private readonly Contextobonoeducativo _contexto;
            private readonly IMapper _mapper; 

            public Manejador( Contextobonoeducativo contexto , IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }


            public async Task<List<associateddto>> Handle(Listasociado request, CancellationToken cancellationToken)
            {
                var associado = await _contexto.associated.ToListAsync();
                var ascoaidodto = _mapper.Map<List<associated>, List<associateddto>>(associado);
                return ascoaidodto; 
            }


        }


    }
}
