using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Information about the function.
	/// </summary>
	[SupportedBy("Chrome")]
	public class FunctionDetails
	{
		/// <summary>
		/// Gets or sets Location of the function, none for native functions.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Location Location { get; set; }
		/// <summary>
		/// Gets or sets Name of the function.
		/// </summary>
		public string FunctionName { get; set; }
		/// <summary>
		/// Gets or sets Whether this is a generator function.
		/// </summary>
		public bool IsGenerator { get; set; }
		/// <summary>
		/// Gets or sets Scope chain for this closure.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Scope[] ScopeChain { get; set; }
	}
}
