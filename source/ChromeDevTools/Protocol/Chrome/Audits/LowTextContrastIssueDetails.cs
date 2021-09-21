using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits
{
	[SupportedBy("Chrome")]
	public class LowTextContrastIssueDetails
	{
		/// <summary>
		/// Gets or sets ViolatingNodeId
		/// </summary>
		public long ViolatingNodeId { get; set; }
		/// <summary>
		/// Gets or sets ViolatingNodeSelector
		/// </summary>
		public string ViolatingNodeSelector { get; set; }
		/// <summary>
		/// Gets or sets ContrastRatio
		/// </summary>
		public double ContrastRatio { get; set; }
		/// <summary>
		/// Gets or sets ThresholdAA
		/// </summary>
		public double ThresholdAA { get; set; }
		/// <summary>
		/// Gets or sets ThresholdAAA
		/// </summary>
		public double ThresholdAAA { get; set; }
		/// <summary>
		/// Gets or sets FontSize
		/// </summary>
		public string FontSize { get; set; }
		/// <summary>
		/// Gets or sets FontWeight
		/// </summary>
		public string FontWeight { get; set; }
	}
}
