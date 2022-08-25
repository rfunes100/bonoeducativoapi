using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using FluentValidation;
using bonoeducativo.Persistencia;
using bonoeducativo.Modelo;
using System.Threading;

namespace bonoeducativo.Aplicacion
{
    public class Nuevoasociado
    {

        public class Ejecuta : IRequest
        {
            public Guid? aso_id { get; set; }
            public int aso_code { get; set; }
            public int? aso_cia { get; set; }
            public string? aso_name { get; set; }
            public DateTime? aso_date_born { get; set; }
            public string? aso_sex { get; set; }
            public string? aso_state { get; set; }
            public string? aso_alter_code { get; set; }
            public int? aso_expedient { get; set; }

        }

        public class EjecutaValidacion : AbstractValidator<Ejecuta>
        {
            public EjecutaValidacion()
            {
                RuleFor(x => x.aso_code).NotEmpty();
                RuleFor(x => x.aso_name).NotEmpty();
                RuleFor(x => x.aso_alter_code).NotEmpty();

            }
        }

        public class Manejador : IRequestHandler<Ejecuta>
        {
            private readonly Contextobonoeducativo _contexto;

            public Manejador(Contextobonoeducativo contexto)
            {
                _contexto = contexto; 
            }


            public async  Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {

                var associate = new associated
                {
                    aso_code = request.aso_code,
                    aso_cia = request.aso_cia,
                    aso_name = request.aso_name,
                    aso_date_born = request.aso_date_born,
                    aso_sex = request.aso_sex,
                    aso_state = request.aso_state,
                    aso_alter_code = request.aso_alter_code,
                    aso_expedient = request.aso_expedient,


                };
                _contexto.associated.Add(associate);
                var value = await _contexto.SaveChangesAsync();
                if(value > 0)
                {
                    return Unit.Value;
                }
                throw new NotImplementedException("no, can not save associated");
            }
        }
 

    }

}
