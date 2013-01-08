using Messages;
using NServiceBus;
using log4net;


namespace HelloWorld
{
    class MessageSender : IWantToRunAtStartup
    {
        public IBus Bus { get; set; }

        public void Run()
        {
            var message = new Request { SaySomething = "Say something againg from config" };
            Bus.Send(message);
            LogManager.GetLogger("MessageSender").Fatal("Sent message.");
        }

        public void Stop()
        {

        }

    }
}
