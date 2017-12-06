using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Coverage data for a JavaScript function.
	/// </summary>
	[SupportedBy("Chrome")]
	public class FunctionCoverage
	{
		/// <summary>
		/// Gets or sets JavaScript function name.
		/// </summary>
		public string FunctionName { get; set; }
		/// <summary>
		/// Gets or sets Source ranges inside the function with coverage data.
		/// </summary>
		public CoverageRange[] Ranges { get; set; }
		/// <summary>
		/// Gets or sets Whether coverage data for this function has block granularity.
		/// </summary>
		public bool IsBlockCoverage { get; set; }
	}
}
