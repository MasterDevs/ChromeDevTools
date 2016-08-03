using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Specifies a number of samples attributed to a certain source position.
	/// </summary>
	[SupportedBy("Chrome")]
	public class PositionTickInfo
	{
		/// <summary>
		/// Gets or sets Source line number (1-based).
		/// </summary>
		public long Line { get; set; }
		/// <summary>
		/// Gets or sets Number of samples attributed to the source line.
		/// </summary>
		public long Ticks { get; set; }
	}
}
