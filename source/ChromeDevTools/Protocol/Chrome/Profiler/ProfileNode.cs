using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Profile node. Holds callsite information, execution statistics and child nodes.
	/// </summary>
	[SupportedBy("Chrome")]
	public class ProfileNode
	{
		/// <summary>
		/// Gets or sets Unique id of the node.
		/// </summary>
		public long Id { get; set; }
		/// <summary>
		/// Gets or sets Function location.
		/// </summary>
		public Runtime.CallFrame CallFrame { get; set; }
		/// <summary>
		/// Gets or sets Number of samples where this node was on top of the call stack.
		/// </summary>
		public long HitCount { get; set; }
		/// <summary>
		/// Gets or sets Child node ids.
		/// </summary>
		public long[] Children { get; set; }
		/// <summary>
		/// Gets or sets The reason of being not optimized. The function may be deoptimized or marked as don't optimize.
		/// </summary>
		public string DeoptReason { get; set; }
		/// <summary>
		/// Gets or sets An array of source position ticks.
		/// </summary>
		public PositionTickInfo[] PositionTicks { get; set; }
	}
}
