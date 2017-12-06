using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Fired when <code>Document</code> has been totally updated. Node ids are no longer valid.
	/// </summary>
	[Event(ProtocolName.DOM.DocumentUpdated)]
	[SupportedBy("iOS")]
	public class DocumentUpdatedEvent
	{
	}
}
