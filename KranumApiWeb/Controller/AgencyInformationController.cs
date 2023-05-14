using KranumCore.Mediator.AgencyInform;
using KranumCore.ViewResource.AgencyInorm;
using KranumCore.ViewResource.User;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KranumApiWeb.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgencyInformationController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AgencyInformationController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        [ActionName("Create")]
        public async Task<ActionResult<AgencyInormResponseViewResource>> Create([FromForm] CreateAgencyUserRequestViewResource viewResource)
        {
            return await _mediator.Send(new AgencyInform.Command { CreateAgencyUserRequestViewResource = viewResource });
        }
    }
}
