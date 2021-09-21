using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Issued for every compilation cache generated. Is only available
	/// if Page.setGenerateCompilationCache is enabled.
	/// </summary>
	[Event(ProtocolName.Page.CompilationCacheProduced)]
	[SupportedBy("Chrome")]
	public class CompilationCacheProducedEvent
	{
		/// <summary>
		/// Gets or sets Url
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Base64-encoded data (Encoded as a base64 string when passed over JSON)
		/// </summary>
		public string Data { get; set; }
	}
}
