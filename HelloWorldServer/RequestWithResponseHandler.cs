using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus;
using Messages;
using log4net;

namespace HelloWorldServer
{
    public class RequestWithResponseHandler : IHandleMessages<RequestWithResponse>
    {
        public IBus Bus { get; set; }

        public void Handle(RequestWithResponse message)
        {
            LogManager.GetLogger("RequestHandler").Fatal("Here is the message" + message.SaySomething);
            Bus.Return(123);
        }
    }
}
