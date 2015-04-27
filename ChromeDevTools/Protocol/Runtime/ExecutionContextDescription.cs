using ChromeDevTools;using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Description of an isolated world.
	/// </summary>
	public class ExecutionContextDescription
	{
		/// <summary>
		/// Gets or sets Unique id of the execution context. It can be used to specify in which execution context script evaluation should be performed.
		/// </summary>
		public long Id { get; set; }
		/// <summary>
		/// Gets or sets True if this is a context where inpspected web page scripts run. False if it is a content script isolated context.
		/// </summary>
		public bool IsPageContext { get; set; }
		/// <summary>
		/// Gets or sets Execution context origin.
		/// </summary>
		public string Origin { get; set; }
		/// <summary>
		/// Gets or sets Human readable name describing given context.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Id of the owning frame. May be an empty string if the context is not associated with a frame.
		/// </summary>
		public string FrameId { get; set; }
	}
}
