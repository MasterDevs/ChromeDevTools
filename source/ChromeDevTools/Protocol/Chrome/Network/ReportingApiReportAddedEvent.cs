using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Is sent whenever a new report is added.
	/// And after 'enableReportingApi' for all existing reports.
	/// </summary>
	[Event(ProtocolName.Network.ReportingApiReportAdded)]
	[SupportedBy("Chrome")]
	public class ReportingApiReportAddedEvent
	{
		/// <summary>
		/// Gets or sets Report
		/// </summary>
		public ReportingApiReport Report { get; set; }
	}
}
