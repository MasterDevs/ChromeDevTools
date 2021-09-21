using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Fired when `Document` has been totally updated. Node ids are no longer valid.
	/// </summary>
	[Event(ProtocolName.DOM.DocumentUpdated)]
	[SupportedBy("Chrome")]
	public class DocumentUpdatedEvent
	{
	}
}
