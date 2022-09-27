using MediatR;
using Microsoft.AspNetCore.Mvc;
using Motel.Application.Features.MovimientoHabitacion.Commands.MovimientoHabitacionRegistrarEntrada;
using System.Net;

namespace Motel.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class MovimientoHabitacionController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MovimientoHabitacionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "RegistrarEntrada")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateStreamer([FromBody] MovimientoHabitacionRegistrarEntradaCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}
