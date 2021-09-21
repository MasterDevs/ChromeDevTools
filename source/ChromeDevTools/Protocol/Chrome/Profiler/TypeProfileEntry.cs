using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Source offset and types for a parameter or return value.
	/// </summary>
	[SupportedBy("Chrome")]
	public class TypeProfileEntry
	{
		/// <summary>
		/// Gets or sets Source offset of the parameter or end of function for return values.
		/// </summary>
		public long Offset { get; set; }
		/// <summary>
		/// Gets or sets The types for this parameter or return value.
		/// </summary>
		public TypeObject[] Types { get; set; }
	}
}
