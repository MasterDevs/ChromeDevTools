using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Accessibility
{
	[SupportedBy("Chrome")]
	public class AXProperty
	{
		/// <summary>
		/// Gets or sets The name of this property.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets The value of this property.
		/// </summary>
		public AXValue Value { get; set; }
	}
}
