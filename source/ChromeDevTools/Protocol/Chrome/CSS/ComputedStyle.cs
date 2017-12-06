using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// A subset of the full ComputedStyle as defined by the request whitelist.
	/// </summary>
	[SupportedBy("Chrome")]
	public class ComputedStyle
	{
		/// <summary>
		/// Gets or sets Properties
		/// </summary>
		public CSSComputedStyleProperty[] Properties { get; set; }
	}
}
