using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAudio
{
	/// <summary>
	/// Fields in AudioContext that change in real-time.
	/// </summary>
	[SupportedBy("Chrome")]
	public class ContextRealtimeData
	{
		/// <summary>
		/// Gets or sets The current context time in second in BaseAudioContext.
		/// </summary>
		public double CurrentTime { get; set; }
		/// <summary>
		/// Gets or sets The time spent on rendering graph divided by render quantum duration,
		/// and multiplied by 100. 100 means the audio renderer reached the full
		/// capacity and glitch may occur.
		/// </summary>
		public double RenderCapacity { get; set; }
		/// <summary>
		/// Gets or sets A running mean of callback interval.
		/// </summary>
		public double CallbackIntervalMean { get; set; }
		/// <summary>
		/// Gets or sets A running variance of callback interval.
		/// </summary>
		public double CallbackIntervalVariance { get; set; }
	}
}
