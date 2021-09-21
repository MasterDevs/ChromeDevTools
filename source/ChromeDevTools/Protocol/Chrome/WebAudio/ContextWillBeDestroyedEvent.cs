using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAudio
{
	/// <summary>
	/// Notifies that an existing BaseAudioContext will be destroyed.
	/// </summary>
	[Event(ProtocolName.WebAudio.ContextWillBeDestroyed)]
	[SupportedBy("Chrome")]
	public class ContextWillBeDestroyedEvent
	{
		/// <summary>
		/// Gets or sets ContextId
		/// </summary>
		public string ContextId { get; set; }
	}
}
