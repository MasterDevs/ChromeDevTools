using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Highlights DOM node.
	/// </summary>
	[Command(ProtocolName.DOM.HighlightNode)]
	[SupportedBy("Chrome")]
	public class HighlightNodeCommand: ICommand<HighlightNodeCommandResponse>
	{
	}
}
