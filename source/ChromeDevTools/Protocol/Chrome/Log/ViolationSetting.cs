using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Log
{
	/// <summary>
	/// Violation configuration setting.
	/// </summary>
	[SupportedBy("Chrome")]
	public class ViolationSetting
	{
		/// <summary>
		/// Gets or sets Violation type.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Time threshold to trigger upon.
		/// </summary>
		public double Threshold { get; set; }
	}
}
