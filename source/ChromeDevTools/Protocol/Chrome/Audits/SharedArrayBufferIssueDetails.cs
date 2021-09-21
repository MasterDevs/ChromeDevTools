using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits
{
	/// <summary>
	/// Details for a issue arising from an SAB being instantiated in, or
	/// transferred to a context that is not cross-origin isolated.
	/// </summary>
	[SupportedBy("Chrome")]
	public class SharedArrayBufferIssueDetails
	{
		/// <summary>
		/// Gets or sets SourceCodeLocation
		/// </summary>
		public SourceCodeLocation SourceCodeLocation { get; set; }
		/// <summary>
		/// Gets or sets IsWarning
		/// </summary>
		public bool IsWarning { get; set; }
		/// <summary>
		/// Gets or sets Type
		/// </summary>
		public SharedArrayBufferIssueType Type { get; set; }
	}
}
