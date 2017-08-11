using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Hides any highlight.
	/// </summary>
	[Command(ProtocolName.Overlay.HideHighlight)]
	[SupportedBy("Chrome")]
	public class HideHighlightCommand
	{
	}
}