using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.PerformanceTimeline
{
	/// <summary>
	/// Previously buffered events would be reported before method returns.
	/// See also: timelineEventAdded
	/// </summary>
	[Command(ProtocolName.PerformanceTimeline.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommand: ICommand<EnableCommandResponse>
	{
		/// <summary>
		/// Gets or sets The types of event to report, as specified in
		/// https://w3c.github.io/performance-timeline/#dom-performanceentry-entrytype
		/// The specified filter overrides any previous filters, passing empty
		/// filter disables recording.
		/// Note that not all types exposed to the web platform are currently supported.
		/// </summary>
		public string[] EventTypes { get; set; }
	}
}
