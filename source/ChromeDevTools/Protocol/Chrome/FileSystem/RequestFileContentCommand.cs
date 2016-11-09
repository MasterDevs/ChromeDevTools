using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.FileSystem
{
	/// <summary>
	/// Returns content of the file. Result should be sliced into [start, end).
	/// </summary>
	[Command(ProtocolName.FileSystem.RequestFileContent)]
	[SupportedBy("Chrome")]
	public class RequestFileContentCommand
	{
		/// <summary>
		/// Gets or sets URL of the file that the frontend is requesting to read from.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets True if the content should be read as text, otherwise the result will be returned as base64 encoded text.
		/// </summary>
		public bool ReadAsText { get; set; }
		/// <summary>
		/// Gets or sets Specifies the start of range to read.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Start { get; set; }
		/// <summary>
		/// Gets or sets Specifies the end of range to read exclusively.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? End { get; set; }
		/// <summary>
		/// Gets or sets Overrides charset of the content when content is served as text.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Charset { get; set; }
	}
}
