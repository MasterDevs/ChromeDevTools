using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Input
{
	/// <summary>
	/// This method emulates inserting text that doesn't come from a key press,
	/// for example an emoji keyboard or an IME.
	/// </summary>
	[CommandResponse(ProtocolName.Input.InsertText)]
	[SupportedBy("Chrome")]
	public class InsertTextCommandResponse
	{
	}
}
