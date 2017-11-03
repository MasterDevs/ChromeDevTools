using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Fired when virtual machine fails to parse the script.
	/// </summary>
	[Event(ProtocolName.Debugger.ScriptFailedToParse)]
	[SupportedBy("Chrome")]
	public class ScriptFailedToParseEvent
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
		/// Gets or sets Specifies script creation context.
		/// </summary>
		public long ExecutionContextId { get; set; }
		/// <summary>
		/// Gets or sets Content hash of the script.
		/// </summary>
		public string Hash { get; set; }
		/// <summary>
		/// Gets or sets Embedder-specific auxiliary data.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public object ExecutionContextAuxData { get; set; }
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
		/// <summary>
		/// Gets or sets True, if this script is ES6 module.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IsModule { get; set; }
		/// <summary>
		/// Gets or sets This script length.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Length { get; set; }
		/// <summary>
		/// Gets or sets JavaScript top stack frame of where the script parsed event was triggered if available.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Runtime.StackTrace StackTrace { get; set; }
	}
}
