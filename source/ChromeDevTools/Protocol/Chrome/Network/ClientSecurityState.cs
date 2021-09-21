using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	[SupportedBy("Chrome")]
	public class ClientSecurityState
	{
		/// <summary>
		/// Gets or sets InitiatorIsSecureContext
		/// </summary>
		public bool InitiatorIsSecureContext { get; set; }
		/// <summary>
		/// Gets or sets InitiatorIPAddressSpace
		/// </summary>
		public IPAddressSpace InitiatorIPAddressSpace { get; set; }
		/// <summary>
		/// Gets or sets PrivateNetworkRequestPolicy
		/// </summary>
		public PrivateNetworkRequestPolicy PrivateNetworkRequestPolicy { get; set; }
	}
}
