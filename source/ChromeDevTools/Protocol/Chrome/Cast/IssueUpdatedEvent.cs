using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Cast
{
	/// <summary>
	/// This is fired whenever the outstanding issue/error message changes.
	/// |issueMessage| is empty if there is no issue.
	/// </summary>
	[Event(ProtocolName.Cast.IssueUpdated)]
	[SupportedBy("Chrome")]
	public class IssueUpdatedEvent
	{
		/// <summary>
		/// Gets or sets IssueMessage
		/// </summary>
		public string IssueMessage { get; set; }
	}
}
