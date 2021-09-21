using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits
{
	[SupportedBy("Chrome")]
	public class SourceCodeLocation
	{
		/// <summary>
		/// Gets or sets ScriptId
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ScriptId { get; set; }
		/// <summary>
		/// Gets or sets Url
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets LineNumber
		/// </summary>
		public long LineNumber { get; set; }
		/// <summary>
		/// Gets or sets ColumnNumber
		/// </summary>
		public long ColumnNumber { get; set; }
	}
}
