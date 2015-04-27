using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Media query descriptor.
	/// </summary>
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
