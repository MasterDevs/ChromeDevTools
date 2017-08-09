using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Stack entry for runtime errors and assertions.
	/// </summary>
	[SupportedBy("Chrome")]
	public class CallFrame
	{
		/// <summary>
		/// Gets or sets JavaScript function name.
		/// </summary>
		public string FunctionName { get; set; }
		/// <summary>
		/// Gets or sets JavaScript script id.
		/// </summary>
		public string ScriptId { get; set; }
		/// <summary>
		/// Gets or sets JavaScript script name or url.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets JavaScript script line number (0-based).
		/// </summary>
		public long LineNumber { get; set; }
		/// <summary>
		/// Gets or sets JavaScript script column number (0-based).
		/// </summary>
		public long ColumnNumber { get; set; }
	}
}
