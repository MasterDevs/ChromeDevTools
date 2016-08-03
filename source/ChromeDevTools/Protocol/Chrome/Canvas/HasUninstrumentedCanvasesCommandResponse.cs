using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Canvas
{
	/// <summary>
	/// Checks if there is any uninstrumented canvas in the inspected page.
	/// </summary>
	[CommandResponse(ProtocolName.Canvas.HasUninstrumentedCanvases)]
	[SupportedBy("Chrome")]
	public class HasUninstrumentedCanvasesCommandResponse
	{
		/// <summary>
		/// Gets or sets Result
		/// </summary>
		public bool Result { get; set; }
	}
}
