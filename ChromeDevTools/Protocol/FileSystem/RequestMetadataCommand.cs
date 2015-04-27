using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.FileSystem
{
	/// <summary>
	/// Returns metadata of the entry.
	/// </summary>
	[Command(ProtocolName.FileSystem.RequestMetadata)]
	public class RequestMetadataCommand
	{
		/// <summary>
		/// Gets or sets URL of the entry that the frontend is requesting to get metadata from.
		/// </summary>
		public string Url { get; set; }
	}
}
