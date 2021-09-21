using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits
{
	/// <summary>
	/// Details for issues about documents in Quirks Mode
	/// or Limited Quirks Mode that affects page layouting.
	/// </summary>
	[SupportedBy("Chrome")]
	public class QuirksModeIssueDetails
	{
		/// <summary>
		/// Gets or sets If false, it means the document's mode is "quirks"
		/// instead of "limited-quirks".
		/// </summary>
		public bool IsLimitedQuirksMode { get; set; }
		/// <summary>
		/// Gets or sets DocumentNodeId
		/// </summary>
		public long DocumentNodeId { get; set; }
		/// <summary>
		/// Gets or sets Url
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets FrameId
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or sets LoaderId
		/// </summary>
		public string LoaderId { get; set; }
	}
}
