using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Media query descriptor.
	/// </summary>
	[SupportedBy("Chrome")]
	public class MediaQuery
	{
		/// <summary>
		/// Gets or sets Array of media query expressions.
		/// </summary>
		public MediaQueryExpression[] Expressions { get; set; }
		/// <summary>
		/// Gets or sets Whether the media query condition is satisfied.
		/// </summary>
		public bool Active { get; set; }
	}
}
