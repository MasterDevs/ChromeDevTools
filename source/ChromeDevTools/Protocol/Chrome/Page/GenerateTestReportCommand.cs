using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Generates a report for testing.
	/// </summary>
	[Command(ProtocolName.Page.GenerateTestReport)]
	[SupportedBy("Chrome")]
	public class GenerateTestReportCommand: ICommand<GenerateTestReportCommandResponse>
	{
		/// <summary>
		/// Gets or sets Message to be displayed in the report.
		/// </summary>
		public string Message { get; set; }
		/// <summary>
		/// Gets or sets Specifies the endpoint group to deliver the report to.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Group { get; set; }
	}
}
