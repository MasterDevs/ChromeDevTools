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
	[Command(ProtocolName.Page.CaptureSnapshot)]
	[SupportedBy("Chrome")]
	public class CaptureSnapshotCommand: ICommand<CaptureSnapshotCommandResponse>
	{
		/// <summary>
		/// Gets or sets Format (defaults to mhtml).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Format { get; set; }
	}
}
