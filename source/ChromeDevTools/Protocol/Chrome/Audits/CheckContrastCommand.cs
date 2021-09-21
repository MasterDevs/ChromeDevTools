using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits
{
	/// <summary>
	/// Runs the contrast check for the target page. Found issues are reported
	/// using Audits.issueAdded event.
	/// </summary>
	[Command(ProtocolName.Audits.CheckContrast)]
	[SupportedBy("Chrome")]
	public class CheckContrastCommand: ICommand<CheckContrastCommandResponse>
	{
		/// <summary>
		/// Gets or sets Whether to report WCAG AAA level issues. Default is false.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ReportAAA { get; set; }
	}
}
