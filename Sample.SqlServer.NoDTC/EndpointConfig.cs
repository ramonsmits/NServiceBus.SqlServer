using NServiceBus;

namespace Sample.SqlServer.NoDTC
{
    public class EndpointConfig : IConfigureThisEndpoint, AsA_Server, UsingTransport<NServiceBus.SqlServer>
    {
        public void Customize(ConfigurationBuilder builder)
        {
        }
    }
}