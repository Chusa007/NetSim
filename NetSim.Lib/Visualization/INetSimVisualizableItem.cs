﻿
namespace NetSim.Lib.Visualization
{
    using System;
    using System.Linq;

    /// <summary>
    /// The visualize interface for an item.
    /// </summary>
    public interface INetSimVisualizableItem
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        string Id { get; set; }

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        /// <value>
        /// The location.
        /// </value>
        NetSimLocation Location { get; set; }
    }
}