using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus;
using log4net;
using Messages;

namespace HelloWorldConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            SendMessage();
        }

        static void SendMessage()
        {
            var Bus = Configure.With()
                     .DefaultBuilder()
                     .XmlSerializer()
                     .MsmqTransport()
                       .IsTransactional(false)
                       .PurgeOnStartup(false)
                     .UnicastBus()
                       .ImpersonateSender(false)
                     .CreateBus()
                     .Start();

            var message = new Request { SaySomething = "Say something again fro a console application" };
            Bus.Send(message);
            LogManager.GetLogger("MessageSender").Fatal("Sent message.");



        }
    }
}
