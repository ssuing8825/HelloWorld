using Messages;
using NServiceBus;
using log4net;
using System;


namespace HelloWorld
{
    class MessageSender : IWantToRunAtStartup
    {
        public IBus Bus { get; set; }

        public void Run()
        {
            Bus.Send<RequestWithResponse>(m => m.SaySomething = "Say 'Request with Response'.")
            .Register<int>(response =>
            {
                Console.WriteLine("Response received:" + response);
                // LogManager.GetLogger("MessageSender").Fatal("Response received:" + response);
            });
            LogManager.GetLogger("MessageSender").Fatal("Sent message.");
        }

        public void Stop()
        {

        }

    }
}
