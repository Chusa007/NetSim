
namespace NetSim.DetailPages
{
    using System;
    using System.Linq;
    using System.Windows.Controls;

    using NetSim.Lib.Simulator.Components;
    using NetSim.ViewModel;

    /// <summary>
    /// Interaction logic for ClientPage
    /// </summary>
    public partial class ClientPage : Page
    {
        /// <summary>
        /// The client
        /// </summary>
        private NetSimClient client;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientPage"/> class.
        /// </summary>
        public ClientPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Gets or sets the client.
        /// </summary>
        /// <value>
        /// The client.
        /// </value>
        public NetSimClient Client
        {
            get
            {
                return this.client;
            }

            set
            {
                this.client = value;
                this.DataContext = new ClientViewModel(this.client);
            }
        }
    }
}