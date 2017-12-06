using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Fired for top level page lifecycle events such as navigation, load, paint, etc.
	/// </summary>
	[Event(ProtocolName.Page.LifecycleEvent)]
	[SupportedBy("Chrome")]
	public class LifecycleEventEvent
	{
		/// <summary>
		/// Gets or sets Name
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Timestamp
		/// </summary>
		public double Timestamp { get; set; }
	}
}
