using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Fires if any of the regionOverset values changed in a Named Flow's region chain.
	/// </summary>
	[Event(ProtocolName.CSS.RegionOversetChanged)]
	[SupportedBy("iOS")]
	public class RegionOversetChangedEvent
	{
		/// <summary>
		/// Gets or sets The Named Flow containing the regions whose regionOverset values changed.
		/// </summary>
		public NamedFlow NamedFlow { get; set; }
	}
}
