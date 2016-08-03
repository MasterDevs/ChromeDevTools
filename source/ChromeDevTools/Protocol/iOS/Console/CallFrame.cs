using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Console
{
	/// <summary>
	/// Stack entry for console errors and assertions.
	/// </summary>
	[SupportedBy("iOS")]
	public class CallFrame
	{
		/// <summary>
		/// Gets or sets JavaScript function name.
		/// </summary>
		public string FunctionName { get; set; }
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
