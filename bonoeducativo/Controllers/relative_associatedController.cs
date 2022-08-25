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
    public class relative_associatedController : ControllerBase
    {


        private readonly IMediator _mediator;


        [HttpGet]
        public async Task<ActionResult<List<relative_associateddto>>> GetAssociated()
        {
            return await _mediator.Send(new Consultarelative_associated.Listasrelativo());
        }



    }
}
