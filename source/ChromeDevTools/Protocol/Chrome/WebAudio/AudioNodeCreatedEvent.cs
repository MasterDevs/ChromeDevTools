using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAudio
{
	/// <summary>
	/// Notifies that a new AudioNode has been created.
	/// </summary>
	[Event(ProtocolName.WebAudio.AudioNodeCreated)]
	[SupportedBy("Chrome")]
	public class AudioNodeCreatedEvent
	{
		/// <summary>
		/// Gets or sets Node
		/// </summary>
		public AudioNode Node { get; set; }
	}
}
