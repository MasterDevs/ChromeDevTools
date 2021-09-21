using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAudio
{
	/// <summary>
	/// Disables the WebAudio domain.
	/// </summary>
	[CommandResponse(ProtocolName.WebAudio.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommandResponse
	{
	}
}
