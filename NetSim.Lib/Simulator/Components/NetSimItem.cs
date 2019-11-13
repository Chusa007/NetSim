
namespace NetSim.Lib.Simulator.Components
{
    using System;
    using System.Linq;
    using NetSim.Lib.Visualization;

    /// <summary>
    /// The Simulator Item base class with identifier and location.
    /// </summary>
    public abstract class NetSimItem : INetSimVisualizableItem
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        /// <value>
        /// The location.
        /// </value>
        public NetSimLocation Location { get; set; }
    }
}