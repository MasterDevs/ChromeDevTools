using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Highlights given rectangle.
	/// </summary>
	[Command(ProtocolName.DOM.HighlightRect)]
	[SupportedBy("Chrome")]
	public class HighlightRectCommand: ICommand<HighlightRectCommandResponse>
	{
	}
}
