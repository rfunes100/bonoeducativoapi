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
    public class Consultarelative_associated
    {

        public class Listasrelativo : IRequest<List<relative_associateddto>> { }


        public class Manejador : IRequestHandler<Listasrelativo, List<relative_associateddto>>
        {
            private readonly Contextobonoeducativo _contexto;
            private readonly IMapper _mapper;

            public Manejador(Contextobonoeducativo contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }


            public async Task<List<relative_associateddto>> Handle(Listasrelativo request, CancellationToken cancellationToken)
            {
                var relative = await _contexto.relative_associated.ToListAsync();
                var relativedto = _mapper.Map<List<relative_associated>, List<relative_associateddto>>(relative);
                return relativedto;
            }

           
        }

    }
}
