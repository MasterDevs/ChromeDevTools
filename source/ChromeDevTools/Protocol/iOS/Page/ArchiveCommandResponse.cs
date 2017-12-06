using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Grab an archive of the page.
	/// </summary>
	[CommandResponse(ProtocolName.Page.Archive)]
	[SupportedBy("iOS")]
	public class ArchiveCommandResponse
	{
		/// <summary>
		/// Gets or sets Base64-encoded web archive.
		/// </summary>
		public string Data { get; set; }
	}
}
