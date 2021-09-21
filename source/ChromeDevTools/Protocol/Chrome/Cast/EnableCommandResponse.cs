using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Cast
{
	/// <summary>
	/// Starts observing for sinks that can be used for tab mirroring, and if set,
	/// sinks compatible with |presentationUrl| as well. When sinks are found, a
	/// |sinksUpdated| event is fired.
	/// Also starts observing for issue messages. When an issue is added or removed,
	/// an |issueUpdated| event is fired.
	/// </summary>
	[CommandResponse(ProtocolName.Cast.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}
