using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.PerformanceTimeline
{
	/// <summary>
	/// See https://wicg.github.io/layout-instability/#sec-layout-shift and layout_shift.idl
	/// </summary>
	[SupportedBy("Chrome")]
	public class LayoutShift
	{
		/// <summary>
		/// Gets or sets Score increment produced by this event.
		/// </summary>
		public double Value { get; set; }
		/// <summary>
		/// Gets or sets HadRecentInput
		/// </summary>
		public bool HadRecentInput { get; set; }
		/// <summary>
		/// Gets or sets LastInputTime
		/// </summary>
		public double LastInputTime { get; set; }
		/// <summary>
		/// Gets or sets Sources
		/// </summary>
		public LayoutShiftAttribution[] Sources { get; set; }
	}
}
