using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Enables promise tracking, information about <code>Promise</code>s created or updated will now be stored on the backend.
	/// </summary>
	[Command(ProtocolName.Debugger.EnablePromiseTracker)]
	[SupportedBy("Chrome")]
	public class EnablePromiseTrackerCommand
	{
		/// <summary>
		/// Gets or sets Whether to capture stack traces for promise creation and settlement events (default: false).
		/// </summary>
		public bool CaptureStacks { get; set; }
	}
}
