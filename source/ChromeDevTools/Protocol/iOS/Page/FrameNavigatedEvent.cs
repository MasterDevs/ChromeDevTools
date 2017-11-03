using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Fired once navigation of the frame has completed. Frame is now associated with the new loader.
	/// </summary>
	[Event(ProtocolName.Page.FrameNavigated)]
	[SupportedBy("iOS")]
	public class FrameNavigatedEvent
	{
		/// <summary>
		/// Gets or sets Frame object.
		/// </summary>
		public Frame Frame { get; set; }
	}
}
