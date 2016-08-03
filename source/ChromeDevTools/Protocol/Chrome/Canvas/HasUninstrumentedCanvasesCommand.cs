using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Canvas
{
	/// <summary>
	/// Checks if there is any uninstrumented canvas in the inspected page.
	/// </summary>
	[Command(ProtocolName.Canvas.HasUninstrumentedCanvases)]
	[SupportedBy("Chrome")]
	public class HasUninstrumentedCanvasesCommand
	{
	}
}
