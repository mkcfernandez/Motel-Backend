using MediatR;
using Microsoft.AspNetCore.Mvc;
using Motel.Application.Features.Motel.Queries;
using System.Net;

namespace Motel.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class MotelController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MotelController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name = "MotelListado")]
        [ProducesResponseType(typeof(IEnumerable<MotelsVm>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<MotelsVm>>> MotelListado()
        {
            try
            {
                var response = await _mediator.Send(new MotelesListaQuery());
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
