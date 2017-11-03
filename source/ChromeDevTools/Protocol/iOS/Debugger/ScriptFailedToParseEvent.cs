using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	/// Fired when virtual machine fails to parse the script.
	/// </summary>
	[Event(ProtocolName.Debugger.ScriptFailedToParse)]
	[SupportedBy("iOS")]
	public class ScriptFailedToParseEvent
	{
		/// <summary>
		/// Gets or sets URL of the script that failed to parse.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Source text of the script that failed to parse.
		/// </summary>
		public string ScriptSource { get; set; }
		/// <summary>
		/// Gets or sets Line offset of the script within the resource.
		/// </summary>
		public long StartLine { get; set; }
		/// <summary>
		/// Gets or sets Line with error.
		/// </summary>
		public long ErrorLine { get; set; }
		/// <summary>
		/// Gets or sets Parse error message.
		/// </summary>
		public string ErrorMessage { get; set; }
	}
}
