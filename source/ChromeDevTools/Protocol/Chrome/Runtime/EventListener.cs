using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Object event listener.
	/// </summary>
	[SupportedBy("Chrome")]
	public class EventListener
	{
		/// <summary>
		/// Gets or sets <code>EventListener</code>'s type.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets <code>EventListener</code>'s useCapture.
		/// </summary>
		public bool UseCapture { get; set; }
		/// <summary>
		/// Gets or sets Handler code location.
		/// </summary>
		public Debugger.Location Location { get; set; }
		/// <summary>
		/// Gets or sets Event handler function value.
		/// </summary>
		public Runtime.RemoteObject Handler { get; set; }
	}
}
