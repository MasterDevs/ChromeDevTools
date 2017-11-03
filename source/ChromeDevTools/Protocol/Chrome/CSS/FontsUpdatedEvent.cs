using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Fires whenever a web font gets loaded.
	/// </summary>
	[Event(ProtocolName.CSS.FontsUpdated)]
	[SupportedBy("Chrome")]
	public class FontsUpdatedEvent
	{
	}
}
