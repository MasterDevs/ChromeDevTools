using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Type profile data collected during runtime for a JavaScript script.
	/// </summary>
	[SupportedBy("Chrome")]
	public class ScriptTypeProfile
	{
		/// <summary>
		/// Gets or sets JavaScript script id.
		/// </summary>
		public string ScriptId { get; set; }
		/// <summary>
		/// Gets or sets JavaScript script name or url.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Type profile entries for parameters and return values of the functions in the script.
		/// </summary>
		public TypeProfileEntry[] Entries { get; set; }
	}
}
