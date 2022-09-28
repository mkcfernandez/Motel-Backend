using MediatR;
using Microsoft.AspNetCore.Mvc;
using Motel.Application.Features.Tarifa.Queries.ListaTarifas;
using System.Net;

namespace Motel.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarifaController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TarifaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{motel_id}", Name = "TarifaListado")]
        [ProducesResponseType(typeof(IEnumerable<TarifaVm>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<TarifaVm>>> TarifaListado(int motel_id)
        {
            try
            {
                var response = await _mediator.Send(new TarifaListaQuery(motel_id));
                if (response == null)
                {
                    return NotFound();
                }

                return Ok(response);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
