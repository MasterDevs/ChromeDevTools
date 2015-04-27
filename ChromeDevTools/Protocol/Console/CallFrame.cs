using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Console
{
	/// <summary>
	/// Stack entry for console errors and assertions.
	/// </summary>
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
		/// Gets or sets JavaScript script line number.
		/// </summary>
		public long LineNumber { get; set; }
		/// <summary>
		/// Gets or sets JavaScript script column number.
		/// </summary>
		public long ColumnNumber { get; set; }
	}
}
