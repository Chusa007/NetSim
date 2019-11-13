
namespace NetSim.Lib.Routing.Helpers
{
    using System;
    using System.Linq;
    using NetSim.Lib.Routing.DSDV;
    using NetSim.Lib.Simulator;
    using NetSim.Lib.Simulator.Components;

    /// <summary>
    /// The routing protocol factory.
    /// This class is used to create the routing protocol instances based on the protocol type.
    /// </summary>
    public static class RoutingProtocolFactory
    {
        /// <summary>
        /// Creates the instance.
        /// </summary>
        /// <param name="protocolType">Type of the protocol.</param>
        /// <param name="client">The client.</param>
        /// <returns>The created routing protocol instance.</returns>
        public static NetSimRoutingProtocol CreateInstance(NetSimProtocolType protocolType, NetSimClient client)
        {
            switch (protocolType)
            {
                case NetSimProtocolType.DSDV:
                    return new DsdvRoutingProtocol(client);
            }

            return null;
        }
    }
}