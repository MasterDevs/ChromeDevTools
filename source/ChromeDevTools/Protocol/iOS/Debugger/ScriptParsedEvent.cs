using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	/// Fired when virtual machine parses script. This event is also fired for all known and uncollected scripts upon enabling debugger.
	/// </summary>
	[Event(ProtocolName.Debugger.ScriptParsed)]
	[SupportedBy("iOS")]
	public class ScriptParsedEvent
	{
		/// <summary>
		/// Gets or sets Identifier of the script parsed.
		/// </summary>
		public string ScriptId { get; set; }
		/// <summary>
		/// Gets or sets URL or name of the script parsed (if any).
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Line offset of the script within the resource with given URL (for script tags).
		/// </summary>
		public long StartLine { get; set; }
		/// <summary>
		/// Gets or sets Column offset of the script within the resource with given URL.
		/// </summary>
		public long StartColumn { get; set; }
		/// <summary>
		/// Gets or sets Last line of the script.
		/// </summary>
		public long EndLine { get; set; }
		/// <summary>
		/// Gets or sets Length of the last line of the script.
		/// </summary>
		public long EndColumn { get; set; }
		/// <summary>
		/// Gets or sets Determines whether this script is a user extension script.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IsContentScript { get; set; }
		/// <summary>
		/// Gets or sets URL of source map associated with script (if any).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SourceMapURL { get; set; }
		/// <summary>
		/// Gets or sets True, if this script has sourceURL.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? HasSourceURL { get; set; }
	}
}
