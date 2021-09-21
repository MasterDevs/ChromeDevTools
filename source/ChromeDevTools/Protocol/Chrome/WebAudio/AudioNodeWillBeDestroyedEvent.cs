using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAudio
{
	/// <summary>
	/// Notifies that an existing AudioNode has been destroyed.
	/// </summary>
	[Event(ProtocolName.WebAudio.AudioNodeWillBeDestroyed)]
	[SupportedBy("Chrome")]
	public class AudioNodeWillBeDestroyedEvent
	{
		/// <summary>
		/// Gets or sets ContextId
		/// </summary>
		public string ContextId { get; set; }
		/// <summary>
		/// Gets or sets NodeId
		/// </summary>
		public string NodeId { get; set; }
	}
}
