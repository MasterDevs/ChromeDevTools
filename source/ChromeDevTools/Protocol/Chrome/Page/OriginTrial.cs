using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	[SupportedBy("Chrome")]
	public class OriginTrial
	{
		/// <summary>
		/// Gets or sets TrialName
		/// </summary>
		public string TrialName { get; set; }
		/// <summary>
		/// Gets or sets Status
		/// </summary>
		public OriginTrialStatus Status { get; set; }
		/// <summary>
		/// Gets or sets TokensWithStatus
		/// </summary>
		public OriginTrialTokenWithStatus[] TokensWithStatus { get; set; }
	}
}
