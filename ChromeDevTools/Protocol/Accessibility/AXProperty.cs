using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Accessibility
{
	/// <summary>
	/// 
	/// </summary>
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
