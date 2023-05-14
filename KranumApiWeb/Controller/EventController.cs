using KranumCore.Mediator.Event;
using KranumCore.ViewResource.Event;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace KranumApiWeb.Controllers
{
    /// <summary>
    /// Manage the Event Actions
    /// </summary>
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class EventController : ControllerBase
    {
        private readonly IMediator _mediator;
        public EventController(IMediator mediator) 
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<Unit>>  GetAllEvent()
        {
            var result =  await _mediator.Send(new GetEvents.Query { });
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<List<EventResponseViewResource>>> GetAll()
        {
            return await _mediator.Send(new GetEvents.Query { });
        }
         
    }
}
    