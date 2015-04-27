using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Canvas
{
	/// <summary>
	/// Checks if there is any uninstrumented canvas in the inspected page.
	/// </summary>
	[Command(ProtocolName.Canvas.HasUninstrumentedCanvases)]
	public class HasUninstrumentedCanvasesCommand
	{
	}
}
