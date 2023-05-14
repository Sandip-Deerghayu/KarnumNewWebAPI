using KranumCore.Common;
using KranumCore.Security;
using KranumCore.ViewResource.Zoom;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KranumCore.Mediator.Zoom
{
    public class CreateZoomJWToken
    {
        public class Command : IRequest<object>
        {
        }

        public class Handler : IRequestHandler<Command, object>
        {
            private readonly IJwtTokenGenerator _jwtTokenGenerator;
            public Handler(IJwtTokenGenerator jwtTokenGenerator)
            {
                _jwtTokenGenerator = jwtTokenGenerator;
            }

            public async Task<object> Handle(Command request, CancellationToken cancellationToken)
            {
                string apiKey = Constants.ZOOM_JWT_API_KEY;
                string apiSecret = Constants.ZOOM_JWT_API_SECRET;
                string token = _jwtTokenGenerator.CreateZoomJWTToken(apiKey, apiSecret);
                return await Task.FromResult(new { token = token });
            }

        }
    }
}
