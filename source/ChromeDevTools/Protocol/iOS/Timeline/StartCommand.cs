using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Timeline
{
	/// <summary>
	/// Starts capturing instrumentation events.
	/// </summary>
	[Command(ProtocolName.Timeline.Start)]
	[SupportedBy("iOS")]
	public class StartCommand: ICommand<StartCommandResponse>
	{
		/// <summary>
		/// Gets or sets Samples JavaScript stack traces up to <code>maxCallStackDepth</code>, defaults to 5.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? MaxCallStackDepth { get; set; }
	}
}
