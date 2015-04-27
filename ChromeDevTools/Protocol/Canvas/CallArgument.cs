using ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChromeDevTools.Protocol.Canvas
{
	/// <summary>
	/// 
	/// </summary>
	public class CallArgument
	{
		/// <summary>
		/// Gets or sets String representation of the object.
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// Gets or sets Enum name, if any, that stands for the value (for example, a WebGL enum name).
		/// </summary>
		public string EnumName { get; set; }
		/// <summary>
		/// Gets or sets Resource identifier. Specified for <code>Resource</code> objects only.
		/// </summary>
		public string ResourceId { get; set; }
		/// <summary>
		/// Gets or sets Object type. Specified for non <code>Resource</code> objects only.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets Object subtype hint. Specified for <code>object</code> type values only.
		/// </summary>
		public string Subtype { get; set; }
		/// <summary>
		/// Gets or sets The <code>RemoteObject</code>, if requested.
		/// </summary>
		public Runtime.RemoteObject RemoteObject { get; set; }
	}
}
