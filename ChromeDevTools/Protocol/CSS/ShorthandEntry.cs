using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// 
	/// </summary>
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
