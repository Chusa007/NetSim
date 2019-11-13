namespace NetSim.Lib.Storage
{
    /// <summary>
    /// The storage network is representation of the network for saving.
    /// </summary>
    public class StorageNetwork
    {
        /// <summary>
        /// Gets or sets the clients.
        /// </summary>
        /// <value>
        /// The clients.
        /// </value>
        public StorageClient[] Clients { get; set; }

        /// <summary>
        /// Gets or sets the connections.
        /// </summary>
        /// <value>
        /// The connections.
        /// </value>
        public StorageConnection[] Connections { get; set; }
    }
}