using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAudio
{
	/// <summary>
	/// Protocol object for AudioNode
	/// </summary>
	[SupportedBy("Chrome")]
	public class AudioNode
	{
		/// <summary>
		/// Gets or sets NodeId
		/// </summary>
		public string NodeId { get; set; }
		/// <summary>
		/// Gets or sets ContextId
		/// </summary>
		public string ContextId { get; set; }
		/// <summary>
		/// Gets or sets NodeType
		/// </summary>
		public string NodeType { get; set; }
		/// <summary>
		/// Gets or sets NumberOfInputs
		/// </summary>
		public double NumberOfInputs { get; set; }
		/// <summary>
		/// Gets or sets NumberOfOutputs
		/// </summary>
		public double NumberOfOutputs { get; set; }
		/// <summary>
		/// Gets or sets ChannelCount
		/// </summary>
		public double ChannelCount { get; set; }
		/// <summary>
		/// Gets or sets ChannelCountMode
		/// </summary>
		public ChannelCountMode ChannelCountMode { get; set; }
		/// <summary>
		/// Gets or sets ChannelInterpretation
		/// </summary>
		public ChannelInterpretation ChannelInterpretation { get; set; }
	}
}
