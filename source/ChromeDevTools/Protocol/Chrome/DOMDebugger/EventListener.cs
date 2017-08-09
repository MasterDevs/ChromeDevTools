using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMDebugger
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
		/// Gets or sets <code>EventListener</code>'s passive flag.
		/// </summary>
		public bool Passive { get; set; }
		/// <summary>
		/// Gets or sets <code>EventListener</code>'s once flag.
		/// </summary>
		public bool Once { get; set; }
		/// <summary>
		/// Gets or sets Script id of the handler code.
		/// </summary>
		public string ScriptId { get; set; }
		/// <summary>
		/// Gets or sets Line number in the script (0-based).
		/// </summary>
		public long LineNumber { get; set; }
		/// <summary>
		/// Gets or sets Column number in the script (0-based).
		/// </summary>
		public long ColumnNumber { get; set; }
		/// <summary>
		/// Gets or sets Event handler function value.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Runtime.RemoteObject Handler { get; set; }
		/// <summary>
		/// Gets or sets Event original handler function value.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Runtime.RemoteObject OriginalHandler { get; set; }
		/// <summary>
		/// Gets or sets Node the listener is added to (if any).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? BackendNodeId { get; set; }
	}
}
