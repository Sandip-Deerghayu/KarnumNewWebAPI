using KranumCore.Mediator.AgencyInform;
using KranumCore.Mediator.UserNotes;
using KranumCore.ViewResource.AgencyInorm;
using KranumCore.ViewResource.User;
using KranumCore.ViewResource.UserNotes;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KranumApiWeb.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserNotesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UserNotesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        [ActionName("Create")]
        public async Task<ActionResult<UserNotesResponseViewResource>> Create(UserNotesRequsetViewResource viewResource)
        {
            return await _mediator.Send(new UserNotes.Command { CreateUserNotesRequsetViewResource = viewResource });
        }

        [HttpGet]
        [ActionName("GetAll")]
        public async Task<ActionResult<List<UserNotesViewResource>>> GetAll()
        {
            return await _mediator.Send(new GetUserNotes.Query());
        }

        [HttpDelete("{id}")]
        [ActionName("Delete")]
        public async Task<ActionResult<bool>> Delete(string id)
        {
            return await _mediator.Send(new DeleteUserNotes.Command { Id = id });
        }

        [HttpPut]
        [ActionName("Update")]
        public async Task<ActionResult<UserNotesResponseViewResource>> Update(UpdateUserNotesViewResource viewResource)
        {
            return await _mediator.Send(new UpdateUserNotes.Command { UpdateUserNotesViewResource = viewResource });
        }
    }
}
