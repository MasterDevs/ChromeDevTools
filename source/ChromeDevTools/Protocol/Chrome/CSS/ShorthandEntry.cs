using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// 
	/// </summary>
	[SupportedBy("Chrome")]
	public class ShorthandEntry
	{
		/// <summary>
		/// Gets or sets Shorthand name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Shorthand value.
		/// </summary>
		public string Value { get; set; }
	}
}
