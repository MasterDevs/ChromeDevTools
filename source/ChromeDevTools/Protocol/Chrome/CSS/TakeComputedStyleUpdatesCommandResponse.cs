using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Polls the next batch of computed style updates.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.TakeComputedStyleUpdates)]
	[SupportedBy("Chrome")]
	public class TakeComputedStyleUpdatesCommandResponse
	{
		/// <summary>
		/// Gets or sets The list of node Ids that have their tracked computed styles updated
		/// </summary>
		public long[] NodeIds { get; set; }
	}
}
