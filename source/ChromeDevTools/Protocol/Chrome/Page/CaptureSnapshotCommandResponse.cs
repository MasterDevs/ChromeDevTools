using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Returns a snapshot of the page as a string. For MHTML format, the serialization includes
	/// iframes, shadow DOM, external resources, and element-inline styles.
	/// </summary>
	[CommandResponse(ProtocolName.Page.CaptureSnapshot)]
	[SupportedBy("Chrome")]
	public class CaptureSnapshotCommandResponse
	{
		/// <summary>
		/// Gets or sets Serialized page data.
		/// </summary>
		public string Data { get; set; }
	}
}
