using log4net;
using Messages;
using NServiceBus;


namespace HelloWorldServer
{
    public class RequestHandler : IHandleMessages<Request>
    {
        public void Handle(Request message)
        {
            LogManager.GetLogger("RequestHandler").Info(message.SaySomething);
        }

    }
}
