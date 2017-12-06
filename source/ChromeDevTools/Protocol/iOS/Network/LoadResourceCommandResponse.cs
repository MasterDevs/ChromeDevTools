using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	/// Loads a resource in the context of a frame on the inspected page without cross origin checks.
	/// </summary>
	[CommandResponse(ProtocolName.Network.LoadResource)]
	[SupportedBy("iOS")]
	public class LoadResourceCommandResponse
	{
		/// <summary>
		/// Gets or sets Resource content.
		/// </summary>
		public string Content { get; set; }
		/// <summary>
		/// Gets or sets Resource mimeType.
		/// </summary>
		public string MimeType { get; set; }
		/// <summary>
		/// Gets or sets HTTP response status code.
		/// </summary>
		public double Status { get; set; }
	}
}
