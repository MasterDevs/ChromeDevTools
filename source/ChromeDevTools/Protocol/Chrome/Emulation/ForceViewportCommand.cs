using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Overrides the visible area of the page. The change is hidden from the page, i.e. the observable scroll position and page scale does not change. In effect, the command moves the specified area of the page into the top-left corner of the frame.
	/// </summary>
	[Command(ProtocolName.Emulation.ForceViewport)]
	[SupportedBy("Chrome")]
	public class ForceViewportCommand
	{
		/// <summary>
		/// Gets or sets X coordinate of top-left corner of the area (CSS pixels).
		/// </summary>
		public double X { get; set; }
		/// <summary>
		/// Gets or sets Y coordinate of top-left corner of the area (CSS pixels).
		/// </summary>
		public double Y { get; set; }
		/// <summary>
		/// Gets or sets Scale to apply to the area (relative to a page scale of 1.0).
		/// </summary>
		public double Scale { get; set; }
	}
}
