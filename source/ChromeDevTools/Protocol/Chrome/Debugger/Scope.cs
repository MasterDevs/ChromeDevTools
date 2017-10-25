using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Scope description.
	/// </summary>
	[SupportedBy("Chrome")]
	public class Scope
	{
		/// <summary>
		/// Gets or sets Scope type.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets Object representing the scope. For <code>global</code> and <code>with</code> scopes it represents the actual object; for the rest of the scopes, it is artificial transient object enumerating scope variables as its properties.
		/// </summary>
		public Runtime.RemoteObject Object { get; set; }
		/// <summary>
		/// Gets or sets Name
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Location in the source code where scope starts
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Location StartLocation { get; set; }
		/// <summary>
		/// Gets or sets Location in the source code where scope ends
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Location EndLocation { get; set; }
	}
}
