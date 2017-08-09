using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Description of an isolated world.
	/// </summary>
	[SupportedBy("Chrome")]
	public class ExecutionContextDescription
	{
		/// <summary>
		/// Gets or sets Unique id of the execution context. It can be used to specify in which execution context script evaluation should be performed.
		/// </summary>
		public long Id { get; set; }
		/// <summary>
		/// Gets or sets Execution context origin.
		/// </summary>
		public string Origin { get; set; }
		/// <summary>
		/// Gets or sets Human readable name describing given context.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Embedder-specific auxiliary data.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public object AuxData { get; set; }
	}
}
