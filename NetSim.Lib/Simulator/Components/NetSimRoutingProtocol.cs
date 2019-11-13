﻿
namespace NetSim.Lib.Simulator.Components
{
    using System;
    using System.Linq;

    /// <summary>
    /// The base class for every routing protocol implementation in the simulator.
    /// </summary>
    public abstract class NetSimRoutingProtocol
    {
        /// <summary>
        /// The not reachable
        /// </summary>
        protected const int NotReachable = -1;

        /// <summary>
        /// The client
        /// </summary>
        protected readonly NetSimClient Client;

        /// <summary>
        /// Initializes a new instance of the <see cref="NetSimRoutingProtocol"/> class.
        /// </summary>
        /// <param name="client">The client.</param>
        protected NetSimRoutingProtocol(NetSimClient client)
        {
            this.Client = client;
            this.StepCounter = 0;
        }

        /// <summary>
        /// Gets the routing data.
        /// </summary>
        /// <value>
        /// The routing data.
        /// </value>
        public string RoutingData => this.GetRoutingData();

        /// <summary>
        /// Gets or sets the step counter.
        /// </summary>
        /// <value>
        /// The step counter.
        /// </value>
        public int StepCounter { get; set; }

        /// <summary>
        /// Gets or sets the table.
        /// </summary>
        /// <value>
        /// The table.
        /// </value>
        public NetSimTable Table { get; set; }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public virtual void Initialize()
        {
            // reset stepcounter
            this.StepCounter = 0;
        }

        /// <summary>
        /// Performs the routing step.
        /// </summary>
        public abstract void PerformRoutingStep();

        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <param name="message">The message.</param>
        public abstract void SendMessage(NetSimMessage message);

        /// <summary>
        /// Gets the route.
        /// </summary>
        /// <param name="destinationId">The destination identifier.</param>
        /// <returns>The found route for the destination or null.</returns>
        protected virtual string GetRoute(string destinationId)
        {
            return this.Table.GetRouteFor(destinationId)?.NextHop;
        }

        /// <summary>
        /// Gets the routing data.
        /// </summary>
        /// <returns>The string representation of the protocol specific routing data.</returns>
        protected abstract string GetRoutingData();

        /// <summary>
        /// Determines whether the connection with the specified endpoint identifier is reachable.
        /// Client has this connection (e.g. not deleted) and connection is not offline
        /// </summary>
        /// <param name="destinationId">The endpoint identifier.</param>
        /// <returns>
        ///   <c>true</c> if connection is reachable; otherwise, <c>false</c>.
        /// </returns>
        protected virtual bool IsConnectionReachable(string destinationId)
        {
            return this.Client?.Connections != null && this.Client.Connections.ContainsKey(destinationId)
                   && !this.Client.Connections[destinationId].IsOffline;
        }
    }
}