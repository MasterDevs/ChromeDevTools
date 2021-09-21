using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAudio
{
	/// <summary>
	/// Protocol object for AudioParam
	/// </summary>
	[SupportedBy("Chrome")]
	public class AudioParam
	{
		/// <summary>
		/// Gets or sets ParamId
		/// </summary>
		public string ParamId { get; set; }
		/// <summary>
		/// Gets or sets NodeId
		/// </summary>
		public string NodeId { get; set; }
		/// <summary>
		/// Gets or sets ContextId
		/// </summary>
		public string ContextId { get; set; }
		/// <summary>
		/// Gets or sets ParamType
		/// </summary>
		public string ParamType { get; set; }
		/// <summary>
		/// Gets or sets Rate
		/// </summary>
		public AutomationRate Rate { get; set; }
		/// <summary>
		/// Gets or sets DefaultValue
		/// </summary>
		public double DefaultValue { get; set; }
		/// <summary>
		/// Gets or sets MinValue
		/// </summary>
		public double MinValue { get; set; }
		/// <summary>
		/// Gets or sets MaxValue
		/// </summary>
		public double MaxValue { get; set; }
	}
}
