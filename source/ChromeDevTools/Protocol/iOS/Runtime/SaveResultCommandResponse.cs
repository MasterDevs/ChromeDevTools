using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Runtime
{
	/// <summary>
	/// Assign a saved result index to this value.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.SaveResult)]
	[SupportedBy("iOS")]
	public class SaveResultCommandResponse
	{
		/// <summary>
		/// Gets or sets If the value was saved, this is the $n index that can be used to access the value.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? SavedResultIndex { get; set; }
	}
}
