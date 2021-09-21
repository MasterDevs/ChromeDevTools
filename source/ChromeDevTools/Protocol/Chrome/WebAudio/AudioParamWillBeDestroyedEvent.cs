using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAudio
{
	/// <summary>
	/// Notifies that an existing AudioParam has been destroyed.
	/// </summary>
	[Event(ProtocolName.WebAudio.AudioParamWillBeDestroyed)]
	[SupportedBy("Chrome")]
	public class AudioParamWillBeDestroyedEvent
	{
		/// <summary>
		/// Gets or sets ContextId
		/// </summary>
		public string ContextId { get; set; }
		/// <summary>
		/// Gets or sets NodeId
		/// </summary>
		public string NodeId { get; set; }
		/// <summary>
		/// Gets or sets ParamId
		/// </summary>
		public string ParamId { get; set; }
	}
}
