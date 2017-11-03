using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Capture a snapshot of the page within the specified rectangle and coordinate system.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SnapshotRect)]
	[SupportedBy("iOS")]
	public class SnapshotRectCommandResponse
	{
		/// <summary>
		/// Gets or sets Base64-encoded image data (PNG).
		/// </summary>
		public string DataURL { get; set; }
	}
}
