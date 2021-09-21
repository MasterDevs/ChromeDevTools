using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Security
{
	[SupportedBy("Chrome")]
	public class SafetyTipInfo
	{
		/// <summary>
		/// Gets or sets Describes whether the page triggers any safety tips or reputation warnings. Default is unknown.
		/// </summary>
		public SafetyTipStatus SafetyTipStatus { get; set; }
		/// <summary>
		/// Gets or sets The URL the safety tip suggested ("Did you mean?"). Only filled in for lookalike matches.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SafeUrl { get; set; }
	}
}
