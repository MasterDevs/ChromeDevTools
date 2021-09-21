using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAudio
{
	/// <summary>
	/// Protocol object for BaseAudioContext
	/// </summary>
	[SupportedBy("Chrome")]
	public class BaseAudioContext
	{
		/// <summary>
		/// Gets or sets ContextId
		/// </summary>
		public string ContextId { get; set; }
		/// <summary>
		/// Gets or sets ContextType
		/// </summary>
		public ContextType ContextType { get; set; }
		/// <summary>
		/// Gets or sets ContextState
		/// </summary>
		public ContextState ContextState { get; set; }
		/// <summary>
		/// Gets or sets RealtimeData
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ContextRealtimeData RealtimeData { get; set; }
		/// <summary>
		/// Gets or sets Platform-dependent callback buffer size.
		/// </summary>
		public double CallbackBufferSize { get; set; }
		/// <summary>
		/// Gets or sets Number of output channels supported by audio hardware in use.
		/// </summary>
		public double MaxOutputChannelCount { get; set; }
		/// <summary>
		/// Gets or sets Context sample rate.
		/// </summary>
		public double SampleRate { get; set; }
	}
}
