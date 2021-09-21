using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Notification is issued every time when binding is called.
	/// </summary>
	[Event(ProtocolName.Runtime.BindingCalled)]
	[SupportedBy("Chrome")]
	public class BindingCalledEvent
	{
		/// <summary>
		/// Gets or sets Name
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Payload
		/// </summary>
		public string Payload { get; set; }
		/// <summary>
		/// Gets or sets Identifier of the context where the call was made.
		/// </summary>
		public long ExecutionContextId { get; set; }
	}
}
