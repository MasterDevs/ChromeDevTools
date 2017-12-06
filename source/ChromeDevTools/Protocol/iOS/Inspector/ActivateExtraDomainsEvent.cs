using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Inspector
{
	/// <summary>
	/// Fired when the backend has alternate domains that need to be activated.
	/// </summary>
	[Event(ProtocolName.Inspector.ActivateExtraDomains)]
	[SupportedBy("iOS")]
	public class ActivateExtraDomainsEvent
	{
		/// <summary>
		/// Gets or sets Domain names that need activation
		/// </summary>
		public string[] Domains { get; set; }
	}
}
