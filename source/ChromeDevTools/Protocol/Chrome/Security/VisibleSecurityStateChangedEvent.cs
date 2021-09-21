using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Security
{
	/// <summary>
	/// The security state of the page changed.
	/// </summary>
	[Event(ProtocolName.Security.VisibleSecurityStateChanged)]
	[SupportedBy("Chrome")]
	public class VisibleSecurityStateChangedEvent
	{
		/// <summary>
		/// Gets or sets Security state information about the page.
		/// </summary>
		public VisibleSecurityState VisibleSecurityState { get; set; }
	}
}
