using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Describes a type collected during runtime.
	/// </summary>
	[SupportedBy("Chrome")]
	public class TypeObject
	{
		/// <summary>
		/// Gets or sets Name of a type collected with type profiling.
		/// </summary>
		public string Name { get; set; }
	}
}
