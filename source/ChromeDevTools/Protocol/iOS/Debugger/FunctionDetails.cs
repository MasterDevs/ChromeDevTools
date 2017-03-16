using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	/// Information about the function.
	/// </summary>
	[SupportedBy("iOS")]
	public class FunctionDetails
	{
		/// <summary>
		/// Gets or sets Location of the function.
		/// </summary>
		public Location Location { get; set; }
		/// <summary>
		/// Gets or sets Name of the function. Not present for anonymous functions.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Display name of the function(specified in 'displayName' property on the function object).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string DisplayName { get; set; }
		/// <summary>
		/// Gets or sets Name of the function inferred from its initial assignment.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string InferredName { get; set; }
		/// <summary>
		/// Gets or sets Scope chain for this closure.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Scope[] ScopeChain { get; set; }
	}
}
