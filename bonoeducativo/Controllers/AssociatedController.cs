using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using bonoeducativo.Aplicacion;
using bonoeducativo.Modelo.dto;

namespace bonoeducativo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssociatedController : ControllerBase
    {

        private readonly IMediator _mediator;

        public AssociatedController (IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<Unit>> crear (Nuevoasociado.Ejecuta data)
        {
            return await _mediator.Send(data);

        }

        [HttpGet]
        public async Task<ActionResult<List<associateddto> >> GetAssociated()
        {
            return await _mediator.Send(new ConsultaAssociated.Listasociado());
        }


    }
}
