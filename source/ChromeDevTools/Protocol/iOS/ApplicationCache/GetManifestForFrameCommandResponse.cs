using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.ApplicationCache
{
	/// <summary>
	/// Returns manifest URL for document in the given frame.
	/// </summary>
	[CommandResponse(ProtocolName.ApplicationCache.GetManifestForFrame)]
	[SupportedBy("iOS")]
	public class GetManifestForFrameCommandResponse
	{
		/// <summary>
		/// Gets or sets Manifest URL for document in the given frame.
		/// </summary>
		public string ManifestURL { get; set; }
	}
}
