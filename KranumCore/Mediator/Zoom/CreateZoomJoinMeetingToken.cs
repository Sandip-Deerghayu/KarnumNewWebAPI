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
    public class CreateZoomJoinMeetingToken
    {
        public class Command : IRequest<object>
        {
            public CreateZoomTokenRequestViewResource viewResource { get; set; }
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
                string apiKey = Constants.ZOOM_API_KEY;
                string apiSecret = Constants.ZOOM_API_SECRET;
                string meetingNumber = request.viewResource.MeetingId;
                String ts = (ToTimestamp(DateTime.UtcNow.ToUniversalTime()) - 30000).ToString();
                string role = request.viewResource.Role;
                string token = _jwtTokenGenerator.CreateZoomJoinMeetingToken(apiKey, apiSecret, meetingNumber, ts, role);
                return await Task.FromResult(new { Signature = token });
            }

            private static long ToTimestamp(DateTime value)
            {
                long epoch = (value.Ticks - 621355968000000000) / 10000;
                return epoch;
            }
        }
    }
}
