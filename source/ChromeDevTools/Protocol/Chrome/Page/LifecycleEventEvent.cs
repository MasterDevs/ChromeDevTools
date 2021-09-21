using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Fired for top level page lifecycle events such as navigation, load, paint, etc.
	/// </summary>
	[Event(ProtocolName.Page.LifecycleEvent)]
	[SupportedBy("Chrome")]
	public class LifecycleEventEvent
	{
		/// <summary>
		/// Gets or sets Id of the frame.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or sets Loader identifier. Empty string if the request is fetched from worker.
		/// </summary>
		public string LoaderId { get; set; }
		/// <summary>
		/// Gets or sets Name
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Timestamp
		/// </summary>
		public double Timestamp { get; set; }
	}
}
