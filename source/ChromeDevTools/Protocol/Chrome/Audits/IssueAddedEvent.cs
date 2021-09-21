using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits
{
	[Event(ProtocolName.Audits.IssueAdded)]
	[SupportedBy("Chrome")]
	public class IssueAddedEvent
	{
		/// <summary>
		/// Gets or sets Issue
		/// </summary>
		public InspectorIssue Issue { get; set; }
	}
}
