namespace HelloWorld
{
    using NServiceBus;
    using log4net;

	/*
		This class configures this endpoint as a Server. More information about how to configure the NServiceBus host
		can be found here: http://nservicebus.com/GenericHost.aspx
	*/
    public class EndpointConfig : IConfigureThisEndpoint, AsA_Client, IWantCustomInitialization
    {
        public void Init()
        {
            NServiceBus.Configure.With()
                .DefaultBuilder()
                .XmlSerializer("http://acme.com/");
        }

        public void Run()
        {
            LogManager.GetLogger("EndpointConfig").Info("Hello World!");
        }

        public void Stop()
        {

        }

    }
}