using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Input
{
	/// <summary>
	/// Emitted only when `Input.setInterceptDrags` is enabled. Use this data with `Input.dispatchDragEvent` to
	/// restore normal drag and drop behavior.
	/// </summary>
	[Event(ProtocolName.Input.DragIntercepted)]
	[SupportedBy("Chrome")]
	public class DragInterceptedEvent
	{
		/// <summary>
		/// Gets or sets Data
		/// </summary>
		public DragData Data { get; set; }
	}
}
