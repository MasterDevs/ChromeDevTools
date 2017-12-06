using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	[SupportedBy("Chrome")]
	public class CSSComputedStyleProperty
	{
		/// <summary>
		/// Gets or sets Computed style property name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Computed style property value.
		/// </summary>
		public string Value { get; set; }
	}
}
